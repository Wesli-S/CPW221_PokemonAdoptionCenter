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

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(128) NOT NULL,
    [ProviderKey] nvarchar(128) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(128) NOT NULL,
    [Name] nvarchar(128) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'00000000000000_CreateIdentitySchema', N'8.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [pokemons] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [PokemonType] nvarchar(max) NOT NULL,
    [Age] int NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [IsAvailable] bit NOT NULL,
    CONSTRAINT [PK_pokemons] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Age', N'Description', N'IsAvailable', N'Name', N'PokemonType') AND [object_id] = OBJECT_ID(N'[pokemons]'))
    SET IDENTITY_INSERT [pokemons] ON;
INSERT INTO [pokemons] ([Id], [Age], [Description], [IsAvailable], [Name], [PokemonType])
VALUES (1, 307, N'Super sweet and a bit shy. Molla was found still in her ball after her owner had passed away, and now hopes to find a new playmate. She enjoys night walks and hide-and-seek', CAST(1 AS bit), N'Molla', N'Haunter'),
(2, 4, N'Coming all the way from the Paldea region, Kinito has a naturally upbeat personality. Kinito enjoys swimming, splashing in puddles, and long afternoon naps.', CAST(1 AS bit), N'Kinito', N'Paldean Wooper'),
(3, 7, N'Apollo was dropped off at our center by his owner who was ''displeased'' about Apollo''s evolutionary choices. Nevertheless, Apollo continues to be incredibly affectionate and loving.', CAST(1 AS bit), N'Apollo', N'Sylveon (Shiny)'),
(4, 10, N'This Pokémon has been choosen! Best of luck, buddy!', CAST(0 AS bit), N'Captain Sushi', N'Galarian Meowth'),
(5, 8, N'Cleo is one of the most bubbly Pokémon we''ve ever met (both figuratively and literally) She was dropped off by her pervious owner who could no longer care for her.', CAST(1 AS bit), N'Cleo', N'Azumarill'),
(6, 5, N'Found tangled in beach debris. When she refused to return to the sea, she was brought to us to find a home. Chompee is incredibly affectionate and adores physical contact. Just watch out for those spikes, as they may hurt.', CAST(1 AS bit), N'Chompee', N'Mareanie'),
(7, 13, N'This Pokémon has been choosen! Best of luck, buddy!', CAST(0 AS bit), N'Oliver', N'Carnivine'),
(8, 3, N'This Pokémon has been choosen! Best of luck, buddy!', CAST(0 AS bit), N'Lilo', N'Flabébé'),
(9, 9, N'Crystal spends most of his time in the pond behind our center, most often dozing or floating in circles. He will occasionally leave the pond to spend time with other Pokémon, but he most often prefers to loaf around. If you''re looking for a good couch companion, this is your guy!', CAST(1 AS bit), N'Crystal', N'Vaporeon'),
(10, 102, N'Found in an abandoned house, Theodore was brought into our care after it was determined he could not provide for himself in the wild. While he may seem incredibly shy and closed off at first, Theodore is actually very sweet once you get to know him.', CAST(1 AS bit), N'Theodore', N'Phantump'),
(11, 4, N'Dropped off at our center as an egg, Oakley is fairly mild mannered and prefers to be alone most days. However, despite not wanting to play with the other Pokémon, Oakley will often be found close by to an employee, most often just watching as we go about our work.', CAST(1 AS bit), N'Oakley', N'Espurr'),
(12, 13, N'This Pokémon is currently still in rehabilitation. Please be patient with her!', CAST(0 AS bit), N'Jade', N'Kirlia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Age', N'Description', N'IsAvailable', N'Name', N'PokemonType') AND [object_id] = OBJECT_ID(N'[pokemons]'))
    SET IDENTITY_INSERT [pokemons] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240417211839_AddedMons', N'8.0.4');
GO

COMMIT;
GO

