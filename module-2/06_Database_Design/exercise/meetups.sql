USE [master]
GO

DROP DATABASE IF EXISTS Meetups;

CREATE DATABASE Meetups;
GO

USE Meetups;
GO

CREATE TABLE Member (
	member_id INT IDENTITY(1,1),
	last_name VARCHAR(100) NOT NULL,
	first_name VARCHAR(100) NOT NULL,
	email_address VARCHAR(100) NOT NULL,
	phone_number VARCHAR(100) NULL,
	date_of_birth DATE NOT NULL,
	reminder_emails BIT NOT NULL,
	CONSTRAINT PK_member PRIMARY KEY (member_id)
);

CREATE TABLE Interest_Group (
	group_id INT IDENTITY(1,1),
	group_name VARCHAR(100) NOT NULL,
	CONSTRAINT PK_group PRIMARY KEY (group_id),
	UNIQUE (group_name)
);

CREATE TABLE Group_Members (
	member_id INT NOT NULL,
	group_id INT NOT NULL,
	--CONSTRAINT PK_gm_id PRIMARY KEY (member_id),
	CONSTRAINT FK_gm_member FOREIGN KEY (member_id) REFERENCES Member(member_id),
	CONSTRAINT FK_gm_group FOREIGN KEY (group_id) REFERENCES Interest_Group(group_id)
);

CREATE TABLE Event (
	event_id INT IDENTITY(1,1),
	event_name VARCHAR(100) NOT NULL,
	description NVARCHAR(MAX) NOT NULL,
	start_date_and_time DATETIME NOT NULL,
	duration_in_minutes INT NOT NULL,
	group_id INT NOT NULL,
	CONSTRAINT PK_event PRIMARY KEY (event_id),
	CONSTRAINT FK_event_group FOREIGN KEY (group_id) REFERENCES Interest_Group(group_id)
);

CREATE TABLE Event_Members (
	event_id INT NOT NULL,
	member_id INT NOT NULL,
	CONSTRAINT PK_event_member PRIMARY KEY (event_id, member_id),
	CONSTRAINT FK_em_event FOREIGN KEY (event_id) REFERENCES Event(event_id),
	CONSTRAINT FK_em_member FOREIGN KEY (member_id) REFERENCES Member(member_id)
);


INSERT INTO Member ( last_name, first_name, email_address, phone_number, date_of_birth, reminder_emails)
VALUES	( 'Stewart', 'Patrick', 'pstew@aol.com', '555-555-1701', '1940/07/13', 1);

INSERT INTO Member ( last_name, first_name, email_address, phone_number, date_of_birth, reminder_emails)
VALUES ( 'Brooks', 'Avery', 'sisco@gmail.com', '555-555-5559', '1948/10/02', 0);

INSERT INTO Member ( last_name, first_name, email_address, phone_number, date_of_birth, reminder_emails)
VALUES ( 'Shatner', 'William', 'theshat@yahoo.com', '555-555-0001', '1931/03/22', 1);

INSERT INTO Member ( last_name, first_name, email_address, phone_number, date_of_birth, reminder_emails)
VALUES ( 'Mulgrew', 'Katherine', 'janeway@gmail.com', '555-557-4656', '1955/04/29', 0);

INSERT INTO Member ( last_name, first_name, email_address, phone_number, date_of_birth, reminder_emails)
VALUES ( 'Martin-Green', 'Sonequa', 'burnham@icloud.com', '555-555-1031', '1985/03/21', 1);

INSERT INTO Member ( last_name, first_name, email_address, date_of_birth, reminder_emails)
VALUES ( 'Takei', 'George', 'ohmy@georgetakei.com', '1937/04/20', 1);

INSERT INTO Member ( last_name, first_name, email_address, phone_number, date_of_birth, reminder_emails)
VALUES ( 'Burton', 'LeVar', 'geordi@gmail.com', '555-555-1994', '1957/02/16', 1);

INSERT INTO Member ( last_name, first_name, email_address, phone_number, date_of_birth, reminder_emails)
VALUES ( 'Dorn', 'Michael', 'mogh@me.com', '555-555-0000', '1952/12/09', 0);

INSERT INTO Interest_Group (group_name)
VALUES ('Enterprise alumni');

INSERT INTO Interest_Group (group_name)
VALUES ('DS9 alumni');

INSERT INTO Interest_Group (group_name)
VALUES ('Discovery alumni');

INSERT INTO Interest_Group (group_name)
VALUES ('Starfleet Academy');

INSERT INTO Interest_Group ( group_name)
VALUES ('Klingon Speakers');

INSERT INTO Event (event_name, description, start_date_and_time, duration_in_minutes, group_id)
VALUES
('Captains Support Group', 'Life after command.', '2020-06-01 10:30:00 AM', 120, 4),
('Quonos Cuisine', 'Fine dining, Klingon Style.', '2020-04-20 12:00:00 PM', 180, 5),
('Female empowerment in Science Fiction', 'Engaging stereotypes through role modeling.', '2020-07-01 06:00:00 PM', 180, 3),
('Tribute to Aron Eisenberg', 'Celebrating the life of the first Starfleet Academy Ferengi', '2020-09-21 08:00:00 PM', 240, 2);

INSERT INTO Group_Members (member_id, group_id)
VALUES
(1, 1),
(1, 2),
(1, 4),
(2, 2),
(2, 4),
(3, 1),
(3, 4),
(4, 4),
(5, 3),
(5, 4),
(5, 5),
(6, 1),
(6, 4),
(7, 1),
(7, 4),
(8, 1),
(8, 2),
(8, 4),
(8, 5);

INSERT INTO Event_Members(event_id, member_id)
VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(2, 3),
(2, 5),
(2, 8),
(3, 4),
(3, 5),
(4, 2),
(4, 8);


SELECT first_name + ' ' + last_name AS attendee
FROM Member m
JOIN Event_Members em
ON em.member_id = m.member_id
WHERE event_id = 1;



