--Display all columns for everyone whose first name contains "Mary"
SELECT *
FROM [AdventureWorks2012].[Person].[Person]
WHERE FirstName LIKE '%Mary%'