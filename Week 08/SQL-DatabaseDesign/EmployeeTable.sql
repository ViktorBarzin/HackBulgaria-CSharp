USE [HackCompany]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 29.1.2016 ã. 23:07:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Email] [nchar](50) NULL,
	[Date Of Birth] [datetime] NOT NULL,
	[Manager] [int] NULL,
	[Departament] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Employee] FOREIGN KEY([Id])
REFERENCES [dbo].[Employee] ([Id])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Employee]
GO


