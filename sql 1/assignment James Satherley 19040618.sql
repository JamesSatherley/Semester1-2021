DROP TABLE course CASCADE;
DROP TABLE offering CASCADE;
DROP TABLE offering_mode CASCADE;
DROP TABLE student CASCADE;
DROP TABLE prereq CASCADE;
DROP TABLE enrolled CASCADE;

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




ALTER TABLE course 
ADD CONSTRAINT code_pk PRIMARY KEY (code),
ADD UNIQUE (title);

ALTER TABLE offering 
ADD CONSTRAINT offering_offer_id_pk PRIMARY KEY (offer_id),  
ADD FOREIGN KEY (course_code) REFERENCES course(code);   

ALTER TABLE offering_mode 
ADD FOREIGN KEY (offer_id) REFERENCES offering(offer_id),
ADD CHECK (mode IN ('INT','DIS'));

ALTER TABLE student 
ADD CONSTRAINT student_id_pk PRIMARY KEY (student_id);   

ALTER TABLE prereq
ADD FOREIGN KEY (offer_id) REFERENCES offering(offer_id),
ADD FOREIGN KEY (prereq_code) REFERENCES course(code);   

ALTER TABLE enrolled
ADD FOREIGN KEY (student_id) REFERENCES student(student_id),
ADD FOREIGN KEY (offer_id) REFERENCES offering(offer_id),
ADD FOREIGN KEY (code) REFERENCES course(code);   


INSERT INTO course(code, title) VALUES
    ('159.171', 'Computational Thinking and Programming'),
    ('159.271', 'Computational Thinking for Problem Solving'),
    ('158.147', 'Database Design 1'),
    ('158.247', 'Database Design 2');
INSERT INTO offering(offer_id, course_code, year) VALUES
    (0, '159.171', '2020'),
    (1, '158.147', '2020'),
    (2, '159.271', '2021'),
    (3, '158.247', '2021');
INSERT INTO offering_mode(offer_id, mode) VALUES
    (0, 'DIS'), 
    (1, 'INT'), 
    (1, 'DIS'), 
    (2, 'INT'), 
    (2, 'DIS');
INSERT INTO student (student_id, name) VALUES
    (123456, 'John Doe'), 
    (654321, 'Joel Smith');
INSERT INTO prereq (offer_id, prereq_code) VALUES
    (2, '159.171'), 
    (3, '158.147');
INSERT INTO enrolled (student_id, offer_id, code) VALUES
    (123456, 0, '159.171'),
    (123456, 2, '159.271'),
    (654321, 2, '159.271');

SELECT DISTINCT
    e1.student_id, 
    e1.code
FROM enrolled e1
JOIN prereq pr1  ON e1.offer_id = pr1.offer_id
JOIN offering o1 on e1.offer_id =  o1.offer_id

WHERE o1.year = 2021 AND NOT EXISTS(
    SELECT 1
    FROM enrolled e2 

	JOIN offering o2 ON e2.code = o2.course_code
	
    WHERE e1.student_id   = e2.student_id
	AND   pr1.prereq_code = o2.course_code
);

SELECT 
	SUM(CASE WHEN mode = 'INT' THEN 1 ELSE 0 END) AS internal,
	SUM(CASE WHEN mode = 'DIS' THEN 1 ELSE 0 END) AS distance,
	offering.year,
	offering.course_code
FROM offering_mode
JOIN offering ON offering_mode.offer_id=offering.offer_id
GROUP BY offering.year, offering.course_code;