/****** Double the discount of the customer with most orders  ******/
-- TODO !
UPDATE HackCompany.dbo.Customer
SET Discount=Discount * 2
WHERE HackCompany.dbo.Customer.Id=(SELECT Customer AS CustomerId
									FROM HackCompany.dbo.[Order] o
									GROUP BY Customer
									ORDER BY CustomerId DESC
);


--INSERT INTO HackCompany.dbo.[Order] (Date,Customer,[Total Price])
--VALUES ('20150213',2,400)

SELECT *
FROM HackCompany.dbo.[Order]

