--Display the first and last names for everyone whose last name ends in an "ay"
SELECT [FirstName],
		[LastName]
FROM [AdventureWorks2012].[Person].[Person]
WHERE [LastName] LIKE '%ay'