USE master
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name='GuildBlog')
DROP DATABASE GuildBlog
GO

CREATE DATABASE GuildBlog
GO