/****** Select the all employees from Sales Department  ******/
SELECT *
  FROM HackCompany.dbo.Employee e
  WHERE e.Departament=1
  ORDER BY e.Name

  --SELECT *
  --FROM HackCompany.dbo.Departament
