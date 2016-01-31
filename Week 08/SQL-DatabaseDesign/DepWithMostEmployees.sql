/****** Select the department having the most employees  ******/
SELECT TOP 1 count(e.Id) as EmployeeCount,d.Name as DepartmentName
  FROM HackCompany.dbo.Departament d
JOIN HackCompany.dbo.Employee e
ON e.Departament = d.Id
GROUP BY d.Id,d.Name
ORDER BY EmployeeCount DESC

	

