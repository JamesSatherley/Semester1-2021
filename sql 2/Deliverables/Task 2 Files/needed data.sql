CREATE TABLE availability(
    doctor varchar(20) NOT NULL
    , avl_date date NOT NULL
    , avl_start time NOT NULL
    , avl_end time NOT NULL
    , CONSTRAINT pk_availability PRIMARY KEY (doctor, avl_date)
);

CREATE TABLE appointments(
    patient varchar(20) NOT NULL
    , doctor varchar(20) NOT NULL
    , apt_date date NOT NULL
    , apt_start time NOT NULL
    , apt_end time NOT NULL
    , CONSTRAINT pk_appointments PRIMARY KEY (patient, apt_date)
);

INSERT INTO availability VALUES
    ('Dr Arthur', '2021-05-01', '9:00', '16:30')
    , ('Dr Bertha', '2021-05-01', '9:00', '16:30')
    , ('Dr Carlos', '2021-05-01', '9:00', '16:30')
    , ('Dr Arthur', '2021-05-02', '11:00', '16:00')
;

INSERT INTO appointments VALUES
    ('Alice', 'Dr Arthur' , '2021-05-01', '11:00', '16:00')
    , ('Bob', 'Dr Bertha', '2021-05-01', '11:00', '12:15')
    , ('Eve', 'Dr Bertha', '2021-05-01', '13:00', '15:00')
    , ('Jim', 'Dr Carlos', '2021-05-01', '11:00', '13:00')
    , ('Joe', 'Dr Carlos', '2021-05-01', '14:00', '15:30')
    , ('Ron', 'Dr Arthur', '2021-05-02', '13:00', '15:00')
;

CREATE USER "158.247-app" WITH PASSWORD ’foobar’;
GRANT USAGE ON SCHEMA public TO "158.247-app";
GRANT SELECT ON TABLE appointments TO "158.247-app";
GRANT SELECT ON TABLE availability TO "158.247-app";
GRANT SELECT ON fully_booked TO "158.247-app";

ALTER TABLE appointments
ADD CHECK (apt_start >= '8:00' AND apt_end <= '17:00' AND apt_start + '00:15' <= apt_end);

CREATE OR REPLACE FUNCTION apt_count(
IN date_input date, IN time_input time)
RETURNS INTEGER AS $$
BEGIN
    RETURN(
    SELECT COUNT(*)
    FROM appointments
    WHERE apt_start <= time_input
    AND   apt_end > time_input
    AND   date_input = apt_date);
END;
$$ LANGUAGE plpgsql;

SELECT apt_count('2021-05-01', '12:00:00');
SELECT * FROM apt_count('2021-05-01', '11:00')

CREATE OR REPLACE VIEW fully_booked AS
	SELECT a1.apt_date, a1.apt_start, a1.apt_end
	FROM appointments a1
	WHERE apt_count(a1.apt_date, a1.apt_start) = avl_count(a1.apt_date, a1.apt_start)
	AND a1.apt_end <=
		(SELECT MIN(a2.apt_end)
		FROM appointments a2
		WHERE a1.apt_start = a2.apt_start)
	GROUP BY a1.apt_date, a1.apt_start, a1.apt_end;

SELECT *
FROM fully_booked;

CREATE OR REPLACE FUNCTION avl_count(
IN date_input date, IN time_input time)
RETURNS INTEGER AS $$
BEGIN
    RETURN(
    SELECT COUNT(*)
    FROM availability
    WHERE avl_start <= time_input
    AND   avl_end > time_input
    AND   date_input = avl_date);
END;
$$ LANGUAGE plpgsql;

SELECT avl_count('2021-05-01', '12:00:00');

CREATE OR REPLACE FUNCTION dates_between(
IN low date, IN high date)
RETURNS TABLE (
	booked_date date
) LANGUAGE plpgsql AS $$
BEGIN
    RETURN QUERY
		SELECT apt_date
		FROM fully_booked
		WHERE apt_date BETWEEN low AND high;
END;$$;
SELECT dates_between('2021-05-01', '2021-05-02');

CREATE OR REPLACE FUNCTION insert_check(
IN username varchar, doctor varchar, date_in date, start_time time, IN end_time time)
RETURNS VOID
LANGUAGE plpgsql AS $$
BEGIN
	IF avl_count(date_in, start_time) > apt_count(date_in, start_time) AND doctor = check_doctor(doctor, date_in) THEN
    	INSERT INTO appointments VALUES(username, doctor, date_in, start_time, end_time);
	END IF;
END;$$;

CREATE OR REPLACE FUNCTION check_doctor(
IN doctor_in varchar, date_in date)
RETURNS varchar
LANGUAGE plpgsql AS $$
BEGIN
	RETURN(
		SELECT doctor
		FROM availability
		WHERE doctor = doctor_in
		AND avl_date = date_in);
END;$$;

