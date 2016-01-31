/****** Double the discount of the customer with most orders  ******/
UPDATE HackCompany.dbo.Customer
SET Discount=Discount * 2
WHERE HackCompany.dbo.Customer.Id =(SELECT TOP 1 o.CustomerId
FROM HackCompany.dbo.[Order] o
GROUP BY o.CustomerId
ORDER BY count(*) DESC
)

