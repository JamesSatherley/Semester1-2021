DROP TABLE employee;

CREATE TABLE employee (
emp_id     integer     NOT NULL,                                                   /* int for id                                                       */
first_name varchar(20) NOT NULL,                                                   /* char limit 20 len for first name                                 */
last_name  varchar(20) NOT NULL,                                                   /* char limit 20 len for second name                                */
manager    integer                                                                 /* int for manager, no not null as manager cannot have manager      */
);

ALTER TABLE employee
ADD CONSTRAINT id_primary_key PRIMARY KEY (emp_id);                                /* makes sure employee id is unique                                  */

ALTER TABLE employee
ADD CONSTRAINT id_foreign_key FOREIGN KEY (manager) REFERENCES employee (emp_id);  /* check if manager is an employee                                   */

ALTER TABLE employee
ADD CONSTRAINT employee_not_manager CHECK (emp_id != manager);                     /* check if manager id is not employee id                            */

INSERT INTO employee VALUES(0, 'Jermery', 'Johnson', 0);                           /* errors as manager id and employee id are same: cannot manage self */
INSERT INTO employee VALUES(0, 'Albert', 'Thereallycoolguy', 1);                   /* doesn't error as manager id and employee id are different         */