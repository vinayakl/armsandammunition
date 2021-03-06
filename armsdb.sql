IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'armsdb')
	DROP DATABASE [armsdb]
GO

CREATE DATABASE [armsdb]  ON (NAME = N'armsdb_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\data\armsdb_Data.MDF' , SIZE = 1, FILEGROWTH = 10%) LOG ON (NAME = N'armsdb_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\data\armsdb_Log.LDF' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO

exec sp_dboption N'armsdb', N'autoclose', N'false'
GO

exec sp_dboption N'armsdb', N'bulkcopy', N'false'
GO

exec sp_dboption N'armsdb', N'trunc. log', N'false'
GO

exec sp_dboption N'armsdb', N'torn page detection', N'true'
GO

exec sp_dboption N'armsdb', N'read only', N'false'
GO

exec sp_dboption N'armsdb', N'dbo use', N'false'
GO

exec sp_dboption N'armsdb', N'single', N'false'
GO

exec sp_dboption N'armsdb', N'autoshrink', N'false'
GO

exec sp_dboption N'armsdb', N'ANSI null default', N'false'
GO

exec sp_dboption N'armsdb', N'recursive triggers', N'false'
GO

exec sp_dboption N'armsdb', N'ANSI nulls', N'false'
GO

exec sp_dboption N'armsdb', N'concat null yields null', N'false'
GO

exec sp_dboption N'armsdb', N'cursor close on commit', N'false'
GO

exec sp_dboption N'armsdb', N'default to local cursor', N'false'
GO

exec sp_dboption N'armsdb', N'quoted identifier', N'false'
GO

exec sp_dboption N'armsdb', N'ANSI warnings', N'false'
GO

exec sp_dboption N'armsdb', N'auto create statistics', N'true'
GO

exec sp_dboption N'armsdb', N'auto update statistics', N'true'
GO

if( (@@microsoftversion / power(2, 24) = 8) and (@@microsoftversion & 0xffff >= 724) )
	exec sp_dboption N'armsdb', N'db chaining', N'false'
GO

use [armsdb]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ARMS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ARMS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Assign]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Assign]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AssignBullets]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[AssignBullets]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Bullet]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Bullet]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BulletRecord]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BulletRecord]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Login]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Login]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Officer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Officer]
GO

if not exists (select * from dbo.sysusers where name = N'guest' and hasdbaccess = 1)
	EXEC sp_grantdbaccess N'guest'
GO

CREATE TABLE [dbo].[ARMS] (
	[SerialNo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ModelNo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Type] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Capacity] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BatchNo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PurchaseDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PurchasePrice] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Manufacturer] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MfgCountry] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MfgDate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Cartridge] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BarrelLength] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Assign] (
	[AssignId] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[EmployeeId] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ArmsId] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EmployeeName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AmmunitionName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AssignDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[AssignBullets] (
	[AssignId] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[EmpID] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BulletName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[noofbullets] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[dateassigned] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Bullet] (
	[ID] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[BulletName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Type] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Brand] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Price] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Weight] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BulletCase] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Velocity] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Powder] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Amount] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Jacket] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[BulletRecord] (
	[ID] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[AssignId] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Record] [varchar] (5000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RecordDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Login] (
	[uname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[pass] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Officer] (
	[ID] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[OfficerName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Post] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Age] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DOB] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DOJ] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PoliceStation] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Assign] WITH NOCHECK ADD 
	CONSTRAINT [PK_Assign] PRIMARY KEY  CLUSTERED 
	(
		[AssignId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[AssignBullets] WITH NOCHECK ADD 
	CONSTRAINT [PK_AssignBullets] PRIMARY KEY  CLUSTERED 
	(
		[AssignId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Bullet] WITH NOCHECK ADD 
	CONSTRAINT [PK_Bullet] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BulletRecord] WITH NOCHECK ADD 
	CONSTRAINT [PK_record] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Login] WITH NOCHECK ADD 
	CONSTRAINT [PK_Login] PRIMARY KEY  CLUSTERED 
	(
		[uname]
	)  ON [PRIMARY] 
GO

