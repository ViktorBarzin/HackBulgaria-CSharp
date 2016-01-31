/****** Select all departments who have more than 3 employees  ******/
SELECT *
  FROM HackCompany.dbo.Departament d
  WHERE (Select count(*)
		FROM HackCompany.dbo.Employee
		WHERE Employee.Departament = d.Id 
		) > 3

