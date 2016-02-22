--Jay Weber just got married to Bob Williams. She has requested that her last name be updated to Weber-Williams
SELECT [Person].[FirstName],
		[Person].[LastName]
FROM [AdventureWorks2012].[Person].[Person]
WHERE  [FirstName] = 'Jay' AND[LastName] = 'Weber';

UPDATE [Person].[Person]
SET [LastName] = 'Weber-Williams'
WHERE [FirstName] = 'Jay' AND[LastName] = 'Weber';

SELECT [Person].[FirstName],
		[Person].[LastName]
FROM [AdventureWorks2012].[Person].[Person]
WHERE  [FirstName] = 'Jay' AND[LastName] = 'Weber-Williams';