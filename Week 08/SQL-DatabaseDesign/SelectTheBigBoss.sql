/****** Select the Big Boss  ******/
SELECT TOP 1000 *
  FROM [HackCompany].[dbo].Employee
  WHERE Manager IS NULL AND Departament IS NULL
