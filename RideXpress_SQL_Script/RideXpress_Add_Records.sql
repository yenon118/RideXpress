USE RideXpress

SELECT * FROM Car SELECT * FROM IncidentReport

INSERT INTO IncidentReport (CarID, DateOfIncident, ReportName, ReportDescription, DateOfReport) 
VALUES (6, '20120618 10:34:09 AM', 'Jacky', 'Tires puncture causing highway accident', '20120619 10:00:00 AM')

INSERT INTO IncidentReport (CarID, DateOfIncident, ReportName, ReportDescription, DateOfReport) 
VALUES (6, '8/6/2016 9:48 PM', 'Rocky', 'Tires puncture causing highway accident', '20170619 10:00:00 AM')

INSERT INTO Employee (FirstName, LastName, Gender, BirthDate, JobTitle, StartDate, EndDate) 
VALUES ('Joshua', 'Jacobson', 1, '8/6/1996', 'Tech Manager', '5/3/2015', NULL)

SELECT Car.*, IncidentReport.* FROM Car
RIGHT OUTER JOIN IncidentReport ON Car.CarID = IncidentReport.CarID

alter table Task alter column DateComplete datetime NULL

INSERT INTO Task (CarID, EmployeeID, TaskTitle, TaskDescription, DateAssigned, TaskStatus) 
VALUES (15, 68, 'Need A Ride', 'I need a ride to Walmart', '2015-6-4', 1)

DELETE FROM Task WHERE TaskID=4

SELECT Task.*, Car.Name, Employee.FirstName, Employee.LastName FROM Task
RIGHT OUTER JOIN Car ON Task.CarID = Car.CarID
INNER JOIN Employee ON Task.EmployeeID = Employee.EmployeeID

