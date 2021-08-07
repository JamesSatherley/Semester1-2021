CREATE TABLE appointment (
    emp_id      integer         NOT NULL,
    jobtitle    varchar(128)    NOT NULL,
    salary      decimal(10,2)   NOT NULL,
    start_date  date            NOT NULL,
    end_date    date            NULL
);
ALTER TABLE appointment ADD CONSTRAINT pkey_appointment PRIMARY KEY (emp_id, jobtitle, start_date);
ALTER TABLE appointment ADD CONSTRAINT chk_appointment_period CHECK (start_date <= end_date);

INSERT INTO appointment VALUES
  (1, 'tutor', 40000, '2008-01-01', '2009-02-01'),
  (1, 'tutor', 42000, '2009-01-01', '2010-09-30'),
  (1, 'tutor', 45000, '2012-04-01', '2013-12-31'),
  (1, 'tutor', 46000, '2014-01-01', '2014-12-31'),
  (1, 'lecturer', 65000, '2014-06-01', NULL),
  (2, 'librarian', 35000, '2014-01-01', NULL),
  (2, 'tutor', 20000, '2014-01-01', NULL),
  (3, 'lecturer', 65000, '2014-06-01', '2015-01-01');

WITH current_employees AS (
    SELECT DISTINCT emp_id
    FROM appointment
    WHERE end_date IS NULL
),
appointments_2015 AS (
    SELECT a.emp_id, salary,
        CASE WHEN start_date < '2015-01-01' THEN '2015-01-01' ELSE start_date END AS start_date,
        CASE WHEN end_date < '2016-01-01' THEN end_date ELSE '2015-12-31' END AS end_date
    FROM appointment a
        JOIN current_employees ce ON a.emp_id = ce.emp_id
    WHERE start_date < '2016-01-01' AND (end_date >= '2015-01-01' OR end_date IS NULL)
)
SELECT
    emp_id,
    SUM( salary * (end_date - start_date + 1) / 365 ) AS total
FROM appointments_2015
GROUP BY emp_id




CREATE TABLE course (
    code            text    not null,
    title           text    not null
);
CREATE TABLE offering (
    offer_id        int     not null,
    course_code     text    not null,
    year            int     not null
);
CREATE TABLE offering_mode (
    offer_id        int     not null,
    mode            text    not null
);
CREATE TABLE student (
    student_id      int     not null,
    name            text    not null
);
CREATE TABLE prereq (
    offer_id        int     not null,
    prereq_code     text    not null
);
CREATE TABLE enrolled (
    student_id      int     not null,
    offer_id        int     not null,
    code            text    not null
);


