
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2023 14:28:07
-- Generated from EDMX file: C:\Users\hungs\Desktop\Volunteers2\VolunteerProject\VolunProject\Data\EntityADO.NET\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VolunteersDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Event__CategoryI__571DF1D5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Event] DROP CONSTRAINT [FK__Event__CategoryI__571DF1D5];
GO
IF OBJECT_ID(N'[dbo].[FK__Registrat__Event__59063A47]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Registration] DROP CONSTRAINT [FK__Registrat__Event__59063A47];
GO
IF OBJECT_ID(N'[dbo].[FK__Registrat__Volun__59FA5E80]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Registration] DROP CONSTRAINT [FK__Registrat__Volun__59FA5E80];
GO
IF OBJECT_ID(N'[dbo].[FK__ReviewLis__Revie__5BE2A6F2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReviewList] DROP CONSTRAINT [FK__ReviewLis__Revie__5BE2A6F2];
GO
IF OBJECT_ID(N'[dbo].[FK__Volunteer__Event__5FB337D6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VolunteerLikeEvent] DROP CONSTRAINT [FK__Volunteer__Event__5FB337D6];
GO
IF OBJECT_ID(N'[dbo].[FK__Volunteer__Rewar__619B8048]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VolunteerReward] DROP CONSTRAINT [FK__Volunteer__Rewar__619B8048];
GO
IF OBJECT_ID(N'[dbo].[FK__Volunteer__Volun__60A75C0F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VolunteerLikeEvent] DROP CONSTRAINT [FK__Volunteer__Volun__60A75C0F];
GO
IF OBJECT_ID(N'[dbo].[FK__Volunteer__Volun__628FA481]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VolunteerReward] DROP CONSTRAINT [FK__Volunteer__Volun__628FA481];
GO
IF OBJECT_ID(N'[dbo].[FK_Organization_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Account] DROP CONSTRAINT [FK_Organization_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_QuanHuyen_TinhThanhPho_tinhThanhPhoId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuanHuyen] DROP CONSTRAINT [FK_QuanHuyen_TinhThanhPho_tinhThanhPhoId];
GO
IF OBJECT_ID(N'[dbo].[FK_Rank_Volunteer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Volunteer] DROP CONSTRAINT [FK_Rank_Volunteer];
GO
IF OBJECT_ID(N'[dbo].[FK_Review_Volunteer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Review] DROP CONSTRAINT [FK_Review_Volunteer];
GO
IF OBJECT_ID(N'[dbo].[FK_TinhThanhPho_QuocGia_quocGiaId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TinhThanhPho] DROP CONSTRAINT [FK_TinhThanhPho_QuocGia_quocGiaId];
GO
IF OBJECT_ID(N'[dbo].[FK_Volunteer_Account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Volunteer] DROP CONSTRAINT [FK_Volunteer_Account];
GO
IF OBJECT_ID(N'[dbo].[FK_XaPhuong_QuanHuyen_quanHuyenId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[XaPhuong] DROP CONSTRAINT [FK_XaPhuong_QuanHuyen_quanHuyenId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Account];
GO
IF OBJECT_ID(N'[dbo].[Event]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Event];
GO
IF OBJECT_ID(N'[dbo].[EventCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventCategory];
GO
IF OBJECT_ID(N'[dbo].[Organization]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Organization];
GO
IF OBJECT_ID(N'[dbo].[QuanHuyen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuanHuyen];
GO
IF OBJECT_ID(N'[dbo].[QuocGia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuocGia];
GO
IF OBJECT_ID(N'[dbo].[Ranking]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ranking];
GO
IF OBJECT_ID(N'[dbo].[Registration]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Registration];
GO
IF OBJECT_ID(N'[dbo].[Review]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Review];
GO
IF OBJECT_ID(N'[dbo].[ReviewList]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReviewList];
GO
IF OBJECT_ID(N'[dbo].[Reward]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reward];
GO
IF OBJECT_ID(N'[dbo].[SysIndex]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SysIndex];
GO
IF OBJECT_ID(N'[dbo].[TinhThanhPho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TinhThanhPho];
GO
IF OBJECT_ID(N'[dbo].[Volunteer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Volunteer];
GO
IF OBJECT_ID(N'[dbo].[VolunteerLikeEvent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VolunteerLikeEvent];
GO
IF OBJECT_ID(N'[dbo].[VolunteerReward]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VolunteerReward];
GO
IF OBJECT_ID(N'[dbo].[XaPhuong]', 'U') IS NOT NULL
    DROP TABLE [dbo].[XaPhuong];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [AccountID] nchar(100)  NOT NULL,
    [AccountName] varchar(50)  NULL,
    [Password] nvarchar(500)  NULL,
    [RoleName] varchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [state] bit  NULL,
    [ImageUS] varbinary(max)  NULL,
    [OrganizationID] nchar(100)  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [EventID] nchar(100)  NOT NULL,
    [EventName] nvarchar(200)  NULL,
    [DistrictId] int  NULL,
    [CityId] int  NULL,
    [WardId] int  NULL,
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [Status] nchar(1)  NULL,
    [CategoryId] nchar(100)  NULL,
    [state] bit  NULL,
    [description] nvarchar(500)  NULL,
    [purpose] nvarchar(500)  NULL,
    [time] varchar(50)  NULL,
    [EventImage] varbinary(max)  NULL,
    [DetailAddress] nvarchar(200)  NULL,
    [OrganizationID] nchar(100)  NULL
);
GO

-- Creating table 'EventCategories'
CREATE TABLE [dbo].[EventCategories] (
    [CategoryID] nchar(100)  NOT NULL,
    [CategoryImage] nvarchar(max)  NULL,
    [CategoryName] nvarchar(100)  NULL,
    [state] bit  NULL
);
GO

-- Creating table 'Organizations'
CREATE TABLE [dbo].[Organizations] (
    [OrganizationID] nchar(100)  NOT NULL,
    [OrganizationName] nvarchar(100)  NULL,
    [state] bit  NULL,
    [COCK] varchar(50)  NULL
);
GO

-- Creating table 'QuanHuyens'
CREATE TABLE [dbo].[QuanHuyens] (
    [ID] int  NOT NULL,
    [tenQuanHuyen] nvarchar(100)  NOT NULL,
    [tinhThanhPhoId] int  NOT NULL
);
GO

-- Creating table 'QuocGias'
CREATE TABLE [dbo].[QuocGias] (
    [ID] int  NOT NULL,
    [tenQuocGia] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Rankings'
CREATE TABLE [dbo].[Rankings] (
    [RankId] nchar(100)  NOT NULL,
    [RankName] nchar(100)  NULL,
    [RankImage] varbinary(max)  NULL,
    [PointRequire] int  NULL,
    [state] bit  NULL
);
GO

-- Creating table 'Registrations'
CREATE TABLE [dbo].[Registrations] (
    [RegistrationID] nchar(100)  NOT NULL,
    [VolunteerID] nchar(100)  NULL,
    [EventID] nchar(100)  NULL,
    [RegistrationDate] datetime  NULL,
    [CheckIn] bit  NULL,
    [CheckOut] bit  NULL,
    [CheckInDate] datetime  NULL,
    [CheckOutDate] datetime  NULL,
    [state] bit  NULL,
    [status] varchar(50)  NULL
);
GO

-- Creating table 'Reviews'
CREATE TABLE [dbo].[Reviews] (
    [ReviewID] nchar(100)  NOT NULL,
    [VolunteerID] nchar(100)  NULL,
    [ReviewPoint] int  NULL,
    [Comment] nvarchar(1000)  NULL,
    [ReviewDate] datetime  NULL,
    [state] varchar(50)  NULL
);
GO

-- Creating table 'ReviewLists'
CREATE TABLE [dbo].[ReviewLists] (
    [ReviewID] nchar(100)  NOT NULL,
    [ReviewerID] nchar(100)  NULL,
    [State] bit  NULL
);
GO

-- Creating table 'Rewards'
CREATE TABLE [dbo].[Rewards] (
    [RewardID] nchar(100)  NOT NULL,
    [RewardName] nvarchar(200)  NULL,
    [RedeemPoint] int  NULL,
    [state] bit  NULL,
    [RewardImg] varbinary(max)  NULL
);
GO

-- Creating table 'SysIndexes'
CREATE TABLE [dbo].[SysIndexes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Prefix] varchar(20)  NULL,
    [IndexName] varchar(50)  NULL,
    [currentIndex] int  NULL
);
GO

-- Creating table 'TinhThanhPhoes'
CREATE TABLE [dbo].[TinhThanhPhoes] (
    [ID] int  NOT NULL,
    [tenTinhThanhPho] nvarchar(100)  NOT NULL,
    [quocGiaId] int  NOT NULL
);
GO

-- Creating table 'Volunteers'
CREATE TABLE [dbo].[Volunteers] (
    [VolunteerID] nchar(100)  NOT NULL,
    [Name] nvarchar(100)  NULL,
    [Email] varchar(100)  NULL,
    [PhoneNumber] varchar(30)  NULL,
    [DistrictId] int  NULL,
    [CityId] int  NULL,
    [WardId] int  NULL,
    [BirthDate] datetime  NULL,
    [AccountID] nchar(100)  NULL,
    [Gender] bit  NULL,
    [Description] nvarchar(1000)  NULL,
    [PrestigeScore] int  NULL,
    [RewardPoint] int  NULL,
    [state] bit  NULL,
    [AddressDetail] nvarchar(200)  NULL,
    [RankId] nchar(100)  NULL
);
GO

-- Creating table 'VolunteerLikeEvents'
CREATE TABLE [dbo].[VolunteerLikeEvents] (
    [VolunteerID] nchar(100)  NOT NULL,
    [EventID] nchar(100)  NOT NULL,
    [LikeDate] datetime  NULL,
    [LikeState] bit  NULL
);
GO

-- Creating table 'VolunteerRewards'
CREATE TABLE [dbo].[VolunteerRewards] (
    [VolunteerID] nchar(100)  NOT NULL,
    [RewardID] nchar(100)  NOT NULL,
    [RedeemDate] datetime  NULL,
    [RedeemCount] int  NULL,
    [state] bit  NULL
);
GO

-- Creating table 'XaPhuongs'
CREATE TABLE [dbo].[XaPhuongs] (
    [ID] int  NOT NULL,
    [tenXaPhuong] nvarchar(100)  NOT NULL,
    [quanHuyenId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AccountID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([AccountID] ASC);
GO

-- Creating primary key on [EventID] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([EventID] ASC);
GO

-- Creating primary key on [CategoryID] in table 'EventCategories'
ALTER TABLE [dbo].[EventCategories]
ADD CONSTRAINT [PK_EventCategories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [OrganizationID] in table 'Organizations'
ALTER TABLE [dbo].[Organizations]
ADD CONSTRAINT [PK_Organizations]
    PRIMARY KEY CLUSTERED ([OrganizationID] ASC);
GO

-- Creating primary key on [ID] in table 'QuanHuyens'
ALTER TABLE [dbo].[QuanHuyens]
ADD CONSTRAINT [PK_QuanHuyens]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'QuocGias'
ALTER TABLE [dbo].[QuocGias]
ADD CONSTRAINT [PK_QuocGias]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [RankId] in table 'Rankings'
ALTER TABLE [dbo].[Rankings]
ADD CONSTRAINT [PK_Rankings]
    PRIMARY KEY CLUSTERED ([RankId] ASC);
GO

-- Creating primary key on [RegistrationID] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [PK_Registrations]
    PRIMARY KEY CLUSTERED ([RegistrationID] ASC);
GO

-- Creating primary key on [ReviewID] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [PK_Reviews]
    PRIMARY KEY CLUSTERED ([ReviewID] ASC);
GO

-- Creating primary key on [ReviewID] in table 'ReviewLists'
ALTER TABLE [dbo].[ReviewLists]
ADD CONSTRAINT [PK_ReviewLists]
    PRIMARY KEY CLUSTERED ([ReviewID] ASC);
GO

-- Creating primary key on [RewardID] in table 'Rewards'
ALTER TABLE [dbo].[Rewards]
ADD CONSTRAINT [PK_Rewards]
    PRIMARY KEY CLUSTERED ([RewardID] ASC);
GO

-- Creating primary key on [ID] in table 'SysIndexes'
ALTER TABLE [dbo].[SysIndexes]
ADD CONSTRAINT [PK_SysIndexes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TinhThanhPhoes'
ALTER TABLE [dbo].[TinhThanhPhoes]
ADD CONSTRAINT [PK_TinhThanhPhoes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [VolunteerID] in table 'Volunteers'
ALTER TABLE [dbo].[Volunteers]
ADD CONSTRAINT [PK_Volunteers]
    PRIMARY KEY CLUSTERED ([VolunteerID] ASC);
GO

-- Creating primary key on [VolunteerID], [EventID] in table 'VolunteerLikeEvents'
ALTER TABLE [dbo].[VolunteerLikeEvents]
ADD CONSTRAINT [PK_VolunteerLikeEvents]
    PRIMARY KEY CLUSTERED ([VolunteerID], [EventID] ASC);
GO

-- Creating primary key on [VolunteerID], [RewardID] in table 'VolunteerRewards'
ALTER TABLE [dbo].[VolunteerRewards]
ADD CONSTRAINT [PK_VolunteerRewards]
    PRIMARY KEY CLUSTERED ([VolunteerID], [RewardID] ASC);
GO

-- Creating primary key on [ID] in table 'XaPhuongs'
ALTER TABLE [dbo].[XaPhuongs]
ADD CONSTRAINT [PK_XaPhuongs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OrganizationID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK_Organization_Account]
    FOREIGN KEY ([OrganizationID])
    REFERENCES [dbo].[Organizations]
        ([OrganizationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Organization_Account'
CREATE INDEX [IX_FK_Organization_Account]
ON [dbo].[Accounts]
    ([OrganizationID]);
GO

-- Creating foreign key on [AccountID] in table 'Volunteers'
ALTER TABLE [dbo].[Volunteers]
ADD CONSTRAINT [FK_Volunteer_Account]
    FOREIGN KEY ([AccountID])
    REFERENCES [dbo].[Accounts]
        ([AccountID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Volunteer_Account'
CREATE INDEX [IX_FK_Volunteer_Account]
ON [dbo].[Volunteers]
    ([AccountID]);
GO

-- Creating foreign key on [CategoryId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK__Event__CategoryI__571DF1D5]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[EventCategories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Event__CategoryI__571DF1D5'
CREATE INDEX [IX_FK__Event__CategoryI__571DF1D5]
ON [dbo].[Events]
    ([CategoryId]);
GO

-- Creating foreign key on [EventID] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK__Registrat__Event__59063A47]
    FOREIGN KEY ([EventID])
    REFERENCES [dbo].[Events]
        ([EventID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Registrat__Event__59063A47'
CREATE INDEX [IX_FK__Registrat__Event__59063A47]
ON [dbo].[Registrations]
    ([EventID]);
GO

-- Creating foreign key on [EventID] in table 'VolunteerLikeEvents'
ALTER TABLE [dbo].[VolunteerLikeEvents]
ADD CONSTRAINT [FK__Volunteer__Event__5FB337D6]
    FOREIGN KEY ([EventID])
    REFERENCES [dbo].[Events]
        ([EventID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Volunteer__Event__5FB337D6'
CREATE INDEX [IX_FK__Volunteer__Event__5FB337D6]
ON [dbo].[VolunteerLikeEvents]
    ([EventID]);
GO

-- Creating foreign key on [tinhThanhPhoId] in table 'QuanHuyens'
ALTER TABLE [dbo].[QuanHuyens]
ADD CONSTRAINT [FK_QuanHuyen_TinhThanhPho_tinhThanhPhoId]
    FOREIGN KEY ([tinhThanhPhoId])
    REFERENCES [dbo].[TinhThanhPhoes]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuanHuyen_TinhThanhPho_tinhThanhPhoId'
CREATE INDEX [IX_FK_QuanHuyen_TinhThanhPho_tinhThanhPhoId]
ON [dbo].[QuanHuyens]
    ([tinhThanhPhoId]);
GO

-- Creating foreign key on [quanHuyenId] in table 'XaPhuongs'
ALTER TABLE [dbo].[XaPhuongs]
ADD CONSTRAINT [FK_XaPhuong_QuanHuyen_quanHuyenId]
    FOREIGN KEY ([quanHuyenId])
    REFERENCES [dbo].[QuanHuyens]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_XaPhuong_QuanHuyen_quanHuyenId'
CREATE INDEX [IX_FK_XaPhuong_QuanHuyen_quanHuyenId]
ON [dbo].[XaPhuongs]
    ([quanHuyenId]);
GO

-- Creating foreign key on [quocGiaId] in table 'TinhThanhPhoes'
ALTER TABLE [dbo].[TinhThanhPhoes]
ADD CONSTRAINT [FK_TinhThanhPho_QuocGia_quocGiaId]
    FOREIGN KEY ([quocGiaId])
    REFERENCES [dbo].[QuocGias]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TinhThanhPho_QuocGia_quocGiaId'
CREATE INDEX [IX_FK_TinhThanhPho_QuocGia_quocGiaId]
ON [dbo].[TinhThanhPhoes]
    ([quocGiaId]);
GO

-- Creating foreign key on [RankId] in table 'Volunteers'
ALTER TABLE [dbo].[Volunteers]
ADD CONSTRAINT [FK_Rank_Volunteer]
    FOREIGN KEY ([RankId])
    REFERENCES [dbo].[Rankings]
        ([RankId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Rank_Volunteer'
CREATE INDEX [IX_FK_Rank_Volunteer]
ON [dbo].[Volunteers]
    ([RankId]);
GO

-- Creating foreign key on [VolunteerID] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK__Registrat__Volun__59FA5E80]
    FOREIGN KEY ([VolunteerID])
    REFERENCES [dbo].[Volunteers]
        ([VolunteerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Registrat__Volun__59FA5E80'
CREATE INDEX [IX_FK__Registrat__Volun__59FA5E80]
ON [dbo].[Registrations]
    ([VolunteerID]);
GO

-- Creating foreign key on [VolunteerID] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [FK_Review_Volunteer]
    FOREIGN KEY ([VolunteerID])
    REFERENCES [dbo].[Volunteers]
        ([VolunteerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Review_Volunteer'
CREATE INDEX [IX_FK_Review_Volunteer]
ON [dbo].[Reviews]
    ([VolunteerID]);
GO

-- Creating foreign key on [ReviewerID] in table 'ReviewLists'
ALTER TABLE [dbo].[ReviewLists]
ADD CONSTRAINT [FK__ReviewLis__Revie__5BE2A6F2]
    FOREIGN KEY ([ReviewerID])
    REFERENCES [dbo].[Volunteers]
        ([VolunteerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ReviewLis__Revie__5BE2A6F2'
CREATE INDEX [IX_FK__ReviewLis__Revie__5BE2A6F2]
ON [dbo].[ReviewLists]
    ([ReviewerID]);
GO

-- Creating foreign key on [RewardID] in table 'VolunteerRewards'
ALTER TABLE [dbo].[VolunteerRewards]
ADD CONSTRAINT [FK__Volunteer__Rewar__619B8048]
    FOREIGN KEY ([RewardID])
    REFERENCES [dbo].[Rewards]
        ([RewardID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Volunteer__Rewar__619B8048'
CREATE INDEX [IX_FK__Volunteer__Rewar__619B8048]
ON [dbo].[VolunteerRewards]
    ([RewardID]);
GO

-- Creating foreign key on [VolunteerID] in table 'VolunteerLikeEvents'
ALTER TABLE [dbo].[VolunteerLikeEvents]
ADD CONSTRAINT [FK__Volunteer__Volun__60A75C0F]
    FOREIGN KEY ([VolunteerID])
    REFERENCES [dbo].[Volunteers]
        ([VolunteerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [VolunteerID] in table 'VolunteerRewards'
ALTER TABLE [dbo].[VolunteerRewards]
ADD CONSTRAINT [FK__Volunteer__Volun__628FA481]
    FOREIGN KEY ([VolunteerID])
    REFERENCES [dbo].[Volunteers]
        ([VolunteerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------