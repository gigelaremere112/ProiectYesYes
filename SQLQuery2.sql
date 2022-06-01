USE [AdminFrmDB]
GO

UPDATE [dbo].[admin]
   SET [FirstName] = <FirstName, varchar(50),>
      ,[LastName] = <LastName, varchar(50),>
      ,[NrLicense] = <NrLicense, varchar(50),>
      ,[Locality] = <Locality, varchar(50),>
 WHERE <Search Conditions,,>
GO

USE [AdminFrmDB]
GO

DELETE FROM [dbo].[admin]
	WHERE admin.ID=1;
GO

DELETE FROM [dbo].[admin]
	WHERE admin.ID=2;
GO

DELETE FROM [dbo].[admin]
	WHERE admin.ID=3;
GO
DELETE FROM [dbo].[admin]
	WHERE admin.ID=4;
GO

DELETE FROM [dbo].[admin]
	WHERE admin.ID=6;
GO

DELETE FROM [dbo].[admin]
	WHERE admin.ID=7;
GO