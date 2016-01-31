USE [HackCompany]
GO

/****** Object:  Table [dbo].[Departament]    Script Date: 29.1.2016 ã. 23:06:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Departament](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Departament] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


