/****** Select the all Department managers  ******/
SELECT *
  FROM HackCompany.dbo.Employee e
  JOIN HackCompany.dbo.DepartamentManager
  ON DepartamentManager.ManagerId = e.Id
