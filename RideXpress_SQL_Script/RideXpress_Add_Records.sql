USE RideXpress
SELECT * FROM Car
INSERT INTO IncidentReport (CarID, DateOfIncident, ReportName, ReportDescription, DateOfReport) 
VALUES (6, '20120618 10:34:09 AM', 'Jacky', 'Tires puncture causing highway accident', '20120619 10:00:00 AM')
SELECT * FROM IncidentReport