/****** Update all employees adding 1 year to their birth date  ******/
UPDATE HackCompany.dbo.Employee
SET [Date Of Birth]=DATEADD(YEAR,1,[Date Of Birth])