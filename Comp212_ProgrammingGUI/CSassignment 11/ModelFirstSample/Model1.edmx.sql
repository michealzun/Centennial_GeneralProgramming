
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/15/2018 17:16:05
-- Generated from EDMX file: C:\Users\300933625\source\repos\ModelFirstSample\ModelFirstSample\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst.Blogging];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BlogPost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts] DROP CONSTRAINT [FK_BlogPost];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Blogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Blogs];
GO
IF OBJECT_ID(N'[dbo].[Posts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Blogs'
CREATE TABLE [dbo].[Blogs] (
    [BlogId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Url] nvarchar(max)  NULL
);
GO

-- Creating table 'Posts'
CREATE TABLE [dbo].[Posts] (
    [PostId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [BlogBlogId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Username] nvarchar(50)  NOT NULL,
    [DisplayName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BlogId] in table 'Blogs'
ALTER TABLE [dbo].[Blogs]
ADD CONSTRAINT [PK_Blogs]
    PRIMARY KEY CLUSTERED ([BlogId] ASC);
GO

-- Creating primary key on [PostId] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [PK_Posts]
    PRIMARY KEY CLUSTERED ([PostId] ASC);
GO

-- Creating primary key on [Username] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BlogBlogId] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [FK_BlogPost]
    FOREIGN KEY ([BlogBlogId])
    REFERENCES [dbo].[Blogs]
        ([BlogId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogPost'
CREATE INDEX [IX_FK_BlogPost]
ON [dbo].[Posts]
    ([BlogBlogId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------