USE RideXpress

SELECT * FROM Car


INSERT INTO IncidentReport (CarID, DateOfIncident, ReportName, ReportDescription, DateOfReport) 
VALUES (6, '20120618 10:34:09 AM', 'Jacky', 'Tires puncture causing highway accident', '20120619 10:00:00 AM')


INSERT INTO IncidentReport (CarID, DateOfIncident, ReportName, ReportDescription, DateOfReport) 
VALUES (6, '8/6/2016 9:48 PM', 'Rocky', 'Tires puncture causing highway accident', '20170619 10:00:00 AM')


SELECT * FROM IncidentReport

INSERT INTO Employee (FirstName, LastName, Gender, BirthDate, JobTitle, StartDate, EndDate) 
VALUES ('Joshua', 'Jacobson', 1, '8/6/1996', 'Tech Manager', '5/3/2015', '')
