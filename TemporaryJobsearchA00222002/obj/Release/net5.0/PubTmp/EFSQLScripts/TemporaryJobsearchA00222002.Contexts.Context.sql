IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    CREATE TABLE [Candidates] (
        [ID] int NOT NULL IDENTITY,
        [CandidateName] nvarchar(max) NULL,
        [Education] nvarchar(max) NULL,
        [Description] nvarchar(4000) NULL,
        [ContactNumber] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [Region] nvarchar(max) NULL,
        [PostalCode] nvarchar(max) NULL,
        [Country] nvarchar(max) NULL,
        CONSTRAINT [PK_Candidates] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    CREATE TABLE [Employers] (
        [ID] int NOT NULL IDENTITY,
        [EmployerName] nvarchar(max) NULL,
        [EmployerPost] nvarchar(max) NULL,
        [Description] nvarchar(4000) NULL,
        [ContactNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_Employers] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    CREATE TABLE [JobApplications] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        [PostalCode] nvarchar(max) NULL,
        [Phonenumber] nvarchar(max) NULL,
        [Emailaddress] nvarchar(max) NULL,
        [SocialSecurityNumber] int NOT NULL,
        CONSTRAINT [PK_JobApplications] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    CREATE TABLE [JobPostings] (
        [ID] int NOT NULL IDENTITY,
        [JobName] nvarchar(max) NULL,
        [Salary] nvarchar(max) NULL,
        [CompanyName] nvarchar(max) NULL,
        [JobSpecifications] nvarchar(4000) NULL,
        [jobRequirment] nvarchar(max) NULL,
        [CompanyNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_JobPostings] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    CREATE TABLE [Notifications] (
        [ID] int NOT NULL IDENTITY,
        CONSTRAINT [PK_Notifications] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    CREATE TABLE [Resumes] (
        [ID] int NOT NULL IDENTITY,
        [ApplicantNmae] nvarchar(max) NULL,
        [EmailAddress] nvarchar(max) NULL,
        [ContctNumber] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [Objective] nvarchar(4000) NULL,
        [Education] nvarchar(4000) NULL,
        [Experience] nvarchar(4000) NULL,
        [Skill] nvarchar(4000) NULL,
        [Activities] nvarchar(4000) NULL,
        CONSTRAINT [PK_Resumes] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    CREATE TABLE [SavedSearches] (
        [ID] int NOT NULL IDENTITY,
        [JobName] nvarchar(max) NULL,
        [CompanyName] nvarchar(max) NULL,
        CONSTRAINT [PK_SavedSearches] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210330033331_AddMeasurementTimestamp')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210330033331_AddMeasurementTimestamp', N'5.0.4');
END;
GO

COMMIT;
GO

