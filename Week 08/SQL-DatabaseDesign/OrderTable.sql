USE [HackCompany]
GO

/****** Object:  Table [dbo].[Order]    Script Date: 29.1.2016 ã. 23:07:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Order](
	[Id] [uniqueidentifier] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Customer] [int] NOT NULL,
	[Total Price] [money] NOT NULL
) ON [PRIMARY]

GO


