--Display all columns for everyone that is over 40 years old.
select *
FROM [AdventureWorks2012].[HumanResources].[Employee]
WHERE cast(datediff(DAY, [BirthDate], '2016-01-17 10:00:01') / (365.23076923074) as int) > 40