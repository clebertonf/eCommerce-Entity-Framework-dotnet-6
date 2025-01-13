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

CREATE TABLE [ProductDepartments] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ProductDepartments] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Sex] nvarchar(max) NULL,
    [Rg] nvarchar(max) NULL,
    [Cpf] nvarchar(max) NOT NULL,
    [MotherName] nvarchar(max) NULL,
    [RegistrationStatus] nvarchar(max) NULL,
    [RegistrationDate] datetimeoffset NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Contacts] (
    [Id] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [Phone] nvarchar(max) NULL,
    [CellPhone] nvarchar(max) NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Contacts_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [DeliveryAddresses] (
    [Id] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [AddressName] nvarchar(max) NULL,
    [ZipCode] nvarchar(max) NULL,
    [State] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [Neighborhood] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [AddressNumber] nvarchar(max) NULL,
    [Complement] nvarchar(max) NULL,
    CONSTRAINT [PK_DeliveryAddresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DeliveryAddresses_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ProductDepartmentUser] (
    [ProductDepartmentsId] int NOT NULL,
    [UsersId] int NOT NULL,
    CONSTRAINT [PK_ProductDepartmentUser] PRIMARY KEY ([ProductDepartmentsId], [UsersId]),
    CONSTRAINT [FK_ProductDepartmentUser_ProductDepartments_ProductDepartmentsId] FOREIGN KEY ([ProductDepartmentsId]) REFERENCES [ProductDepartments] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ProductDepartmentUser_Users_UsersId] FOREIGN KEY ([UsersId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [IX_Contacts_UserId] ON [Contacts] ([UserId]);
GO

CREATE INDEX [IX_DeliveryAddresses_UserId] ON [DeliveryAddresses] ([UserId]);
GO

CREATE INDEX [IX_ProductDepartmentUser_UsersId] ON [ProductDepartmentUser] ([UsersId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250113202352_Initial_migration_project', N'6.0.36');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Users] ADD [FatherName] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250113211642_collum_father_name', N'6.0.36');
GO

COMMIT;
GO

