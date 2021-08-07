DROP TABLE car_rentals;

CREATE TABLE car_rentals(
    plate      varchar(10) NOT NULL,
    start_date date        NOT NULL,
    end_date   date        NOT NULL,
    license_nr varchar(10) NOT NULL,
    CONSTRAINT unq_car_rentals_start UNIQUE (plate, start_date),
    CONSTRAINT unq_car_rentals_end   UNIQUE (plate, end_date)
);



CREATE TRIGGER trigger_overlap_check_insert
BEFORE INSERT ON car_rentals FOR EACH ROW
CALL check_overlap_insert();

CREATE FUNCTION check_overlap_insert()
    RETURNS trigger AS $$
BEGIN
    SELECT * FROM car_rentals
    IF plate = NEW.plate and end_date >= NEW.start_date and =start_date <= NEW.end_date THEN
        RAISE unique_violation USING MESSAGE = 'ERROR; insert is overlapping';
    ELSE
        INSERT INTO car_rentals VALUES (NEW.plate, NEW.start_date, NEW.end_date, NEW.license_nr)
        RETURN NEW;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_overlap_check_update_date
BEFORE INSERT ON car_rentals FOR EACH ROW
CALL check_overlap_update_date();

CREATE FUNCTION check_overlap_insert_date()
    RETURNS trigger AS $$
BEGIN
    SELECT * FROM car_rentals
    IF end_date >= NEW.start_date and start_date <= NEW.end_date THEN
        RAISE unique_violation USING MESSAGE = 'ERROR; time overlaps';
    ELSE
        UPDATE car_rentals SET start_date = NEW.start_date, end_date = NEW.end_date;
        RETURN NEW;
$$ LANGUAGE plpgsql;



CREATE TRIGGER trigger_overlap_check_update_plate
BEFORE INSERT ON car_rentals FOR EACH ROW
CALL check_overlap_update_plate();

CREATE FUNCTION check_overlap_insert_plate()
    RETURNS trigger AS $$
BEGIN
    SELECT * FROM car_rentals
    IF plate = NEW.plate  THEN
        RAISE unique_violation USING MESSAGE = 'ERROR; update, plate in database';
    ELSE
        UPDATE car_rentals SET plate = NEW.plate;
        RETURN NEW;
$$ LANGUAGE plpgsql;



INSERT INTO car_rentals VALUES ('2-F4ST', '2015-02-02', '2015-02-11', 'DI123');
UPDATE car_rentals SET start_date = '2015-02-01', end_date = '2015-02-10';
INSERT INTO car_rentals VALUES ('SP33DY', '2015-01-20', '2015-02-05', 'DI234');
-- should fail (test individually)
UPDATE car_rentals SET plate = '2-F4ST' WHERE plate = 'SP33DY';
INSERT INTO car_rentals VALUES ('2-F4ST', '2015-02-10', '2015-02-15', 'DI234');
INSERT INTO car_rentals VALUES ('2-F4ST', '2015-01-20', '2015-02-15', 'DI234');
INSERT INTO car_rentals VALUES ('2-F4ST', '2015-02-02', '2015-02-09', 'DI234');
-- should work
INSERT INTO car_rentals VALUES ('2-F4ST', '2015-03-01', '2015-03-10', 'DI234');