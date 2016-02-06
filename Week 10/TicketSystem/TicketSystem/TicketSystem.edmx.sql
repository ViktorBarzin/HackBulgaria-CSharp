
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/06/2016 14:59:54
-- Generated from EDMX file: C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 10\TicketSystem\TicketSystem\TicketSystem.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HackTrainCompany];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ScheduleCity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CitySet] DROP CONSTRAINT [FK_ScheduleCity];
GO
IF OBJECT_ID(N'[dbo].[FK_ScheduleTain]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TainSet] DROP CONSTRAINT [FK_ScheduleTain];
GO
IF OBJECT_ID(N'[dbo].[FK_ScheduleTicket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketSet] DROP CONSTRAINT [FK_ScheduleTicket];
GO
IF OBJECT_ID(N'[dbo].[FK_UserDiscountCard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DiscountCardSet] DROP CONSTRAINT [FK_UserDiscountCard];
GO
IF OBJECT_ID(N'[dbo].[FK_TicketUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet] DROP CONSTRAINT [FK_TicketUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CitySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CitySet];
GO
IF OBJECT_ID(N'[dbo].[TainSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TainSet];
GO
IF OBJECT_ID(N'[dbo].[ScheduleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScheduleSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[TicketSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TicketSet];
GO
IF OBJECT_ID(N'[dbo].[DiscountCardSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiscountCardSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CitySet'
CREATE TABLE [dbo].[CitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Schedule_Id] int  NOT NULL
);
GO

-- Creating table 'TainSet'
CREATE TABLE [dbo].[TainSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Seats] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Schedule_Id] int  NOT NULL
);
GO

-- Creating table 'ScheduleSet'
CREATE TABLE [dbo].[ScheduleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartCity] nvarchar(max)  NOT NULL,
    [EndCity] nvarchar(max)  NOT NULL,
    [TravelTime] int  NOT NULL,
    [TrainId] int  NOT NULL,
    [TicketPrice] int  NOT NULL,
    [TicketId] int  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [PasswordHash] nvarchar(max)  NOT NULL,
    [DiscountCardNumber] bigint  NOT NULL,
    [CreditCardNumberHash] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [ZipCode] int  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [TickedId] int  NOT NULL,
    [Ticket_Id] int  NOT NULL
);
GO

-- Creating table 'TicketSet'
CREATE TABLE [dbo].[TicketSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TripDateAndTime] datetime  NOT NULL,
    [OriginlaPrice] int  NOT NULL,
    [PriceSold] int  NOT NULL,
    [UserSoldTo] int  NOT NULL,
    [SeatNumber] int  NOT NULL,
    [Schedule_Id] int  NOT NULL
);
GO

-- Creating table 'DiscountCardSet'
CREATE TABLE [dbo].[DiscountCardSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Discount] int  NOT NULL,
    [FirstClass] bit  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CitySet'
ALTER TABLE [dbo].[CitySet]
ADD CONSTRAINT [PK_CitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TainSet'
ALTER TABLE [dbo].[TainSet]
ADD CONSTRAINT [PK_TainSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScheduleSet'
ALTER TABLE [dbo].[ScheduleSet]
ADD CONSTRAINT [PK_ScheduleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [PK_TicketSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiscountCardSet'
ALTER TABLE [dbo].[DiscountCardSet]
ADD CONSTRAINT [PK_DiscountCardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Schedule_Id] in table 'CitySet'
ALTER TABLE [dbo].[CitySet]
ADD CONSTRAINT [FK_ScheduleCity]
    FOREIGN KEY ([Schedule_Id])
    REFERENCES [dbo].[ScheduleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScheduleCity'
CREATE INDEX [IX_FK_ScheduleCity]
ON [dbo].[CitySet]
    ([Schedule_Id]);
GO

-- Creating foreign key on [Schedule_Id] in table 'TainSet'
ALTER TABLE [dbo].[TainSet]
ADD CONSTRAINT [FK_ScheduleTain]
    FOREIGN KEY ([Schedule_Id])
    REFERENCES [dbo].[ScheduleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScheduleTain'
CREATE INDEX [IX_FK_ScheduleTain]
ON [dbo].[TainSet]
    ([Schedule_Id]);
GO

-- Creating foreign key on [Schedule_Id] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_ScheduleTicket]
    FOREIGN KEY ([Schedule_Id])
    REFERENCES [dbo].[ScheduleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScheduleTicket'
CREATE INDEX [IX_FK_ScheduleTicket]
ON [dbo].[TicketSet]
    ([Schedule_Id]);
GO

-- Creating foreign key on [User_Id] in table 'DiscountCardSet'
ALTER TABLE [dbo].[DiscountCardSet]
ADD CONSTRAINT [FK_UserDiscountCard]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDiscountCard'
CREATE INDEX [IX_FK_UserDiscountCard]
ON [dbo].[DiscountCardSet]
    ([User_Id]);
GO

-- Creating foreign key on [Ticket_Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_TicketUser]
    FOREIGN KEY ([Ticket_Id])
    REFERENCES [dbo].[TicketSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TicketUser'
CREATE INDEX [IX_FK_TicketUser]
ON [dbo].[UserSet]
    ([Ticket_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------