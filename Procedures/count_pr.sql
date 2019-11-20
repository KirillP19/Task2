CREATE PROCEDURE count_pr @employment_type int, @status_name varchar(50), @date_from varchar(50), @date_to varchar(50)
AS
SELECT COUNT(*) FROM dbo.persons
WHERE (@employment_type = 0) OR
(@employment_type = 1 AND
CONVERT(VARCHAR, persons.date_employ ,121) BETWEEN CONVERT(VARCHAR, CAST(@date_from AS DATETIME),121)  AND  CONVERT(VARCHAR, CAST(@date_to AS DATETIME),121))
OR
(@employment_type = 2 AND
persons.date_unemploy IS NOT NULL AND
CONVERT(VARCHAR, persons.date_unemploy ,121) BETWEEN CONVERT(VARCHAR, CAST(@date_from AS DATETIME),121)  AND  CONVERT(VARCHAR, CAST(@date_to AS DATETIME),121))
GO

