--Display the first name, last name, and city for everyone that's not from Payson.
SELECT Person.FirstName,
		Person.LastName,
		Address.City
  FROM [AdventureWorks2012].[Person].[Person],[AdventureWorks2012].[Person].[Address]
  Where Address.City != 'Payson'