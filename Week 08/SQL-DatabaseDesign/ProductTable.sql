USE [HackCompany]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 29.1.2016 ã. 23:07:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Single Price] [money] NOT NULL,
	[Category] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


