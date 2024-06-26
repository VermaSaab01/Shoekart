USE [Shoe_Kart_Shopping1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[City] [nvarchar](max) NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[PostalCode] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[StreetAddress] [nvarchar](max) NULL,
	[CompanyId] [int] NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[StreetAddress] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[PostalCode] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[IsAuthorizedCompany] [bit] NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderHeaders]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHeaders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationUserId] [nvarchar](450) NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[ShippingDate] [datetime2](7) NOT NULL,
	[OrderTotal] [float] NOT NULL,
	[TrackingNumber] [nvarchar](max) NULL,
	[Carrier] [nvarchar](max) NULL,
	[OrderStatus] [nvarchar](max) NULL,
	[PaymentStatus] [nvarchar](max) NULL,
	[PaymentDate] [datetime2](7) NOT NULL,
	[PaymentDueDate] [datetime2](7) NOT NULL,
	[TransactionId] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NOT NULL,
	[StreetAddress] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[State] [nvarchar](max) NOT NULL,
	[PostalCode] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_OrderHeaders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SerialNo] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[ListPrice] [float] NOT NULL,
	[Price50] [float] NOT NULL,
	[Price] [float] NOT NULL,
	[ImageURL] [nvarchar](max) NULL,
	[BrandId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ShoeSizeId] [int] NOT NULL,
	[Gender] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoeSizes]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoeSizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ShoeSizes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoeSizeSelectors]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoeSizeSelectors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShoeSizeSelectors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCarts]    Script Date: 07-06-2023 16:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCarts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationUserId] [nvarchar](450) NULL,
	[ProductId] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[Size] [int] NOT NULL,
	[ShoeSizeSelectorId] [int] NOT NULL,
 CONSTRAINT [PK_ShoppingCarts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220315054921_Initload', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220315062450_AddCategoryToTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220315064233_AddBrandToTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220315115551_AddShoeSize', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220317052435_AddProductTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220319064807_GenderTypeToProductTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220322052228_AddApplicationUserTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220322053440_AddCompanyTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220322053733_AddForeignKeyAppUser', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220405044601_AddShoppingCartTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220405044830_AddOrderHeaderTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220405045111_AddOrderDetailsTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220407044955_AddSizeTypeTable', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230511133056_Add_ShoeSizeSelector', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230511135023_Add_columnSelector_To_ShopCart', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230511143419_ShoeSizeSelector_ShoppingCart_NameChage', N'5.0.12')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'76670d83-48cc-46e5-ae32-16dfcb179235', N'Admin', N'ADMIN', N'a39f9297-56d7-4416-b54c-b84f69295c8f')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8d83aaec-9655-43e0-aa6d-5553918e4b8b', N'Company user', N'COMPANY USER', N'922e6f3b-753f-4474-9707-35e32b6a501f')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8e2fc187-e4bb-44e7-a0b4-c344958624b8', N'Individual User', N'INDIVIDUAL USER', N'a048dda5-d6ec-400c-8c10-468e08352a12')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c653f1d2-d4a0-4f8e-9949-cdfa22b3018a', N'Employee', N'EMPLOYEE', N'e8d19fa0-91cd-43a9-b622-8c8ee380c898')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'045b0ae7-7802-4cd0-b472-1452414a3e2a', N'76670d83-48cc-46e5-ae32-16dfcb179235')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5f152a08-2a88-4179-909f-ecb99df6d7ad', N'8d83aaec-9655-43e0-aa6d-5553918e4b8b')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd48c280d-d967-42b1-bb97-be11a7c2a797', N'8d83aaec-9655-43e0-aa6d-5553918e4b8b')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e852ef5b-a818-49d9-ad15-74d15a5b74f6', N'8e2fc187-e4bb-44e7-a0b4-c344958624b8')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City], [Discriminator], [Name], [PostalCode], [State], [StreetAddress], [CompanyId]) VALUES (N'045b0ae7-7802-4cd0-b472-1452414a3e2a', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGj5v+urzLfUfZFYiUIkAzfsf6mi9ub9mZwjLbee1+6EKP5GwILzVfv0QwiaId6jjA==', N'55VTJMFMYUTJIWOSZRETR4PXD5RTKYRJ', N'b2f18d34-a90f-487c-861a-c09896b22dde', N'987654321', 0, 0, NULL, 1, 0, N'Amb', N'ApplicationUser', N'Admin', N'177203', N'HP', N'UNA', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City], [Discriminator], [Name], [PostalCode], [State], [StreetAddress], [CompanyId]) VALUES (N'5f152a08-2a88-4179-909f-ecb99df6d7ad', N'Company@gmail.com', N'COMPANY@GMAIL.COM', N'Company@gmail.com', N'COMPANY@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEN8D4HIy9JtBAVfFbnK3OAFoFIo4x/FDQ5Iia12aVdlTtwDWdPFHmunMx04YpLKEKw==', N'KC2SWEDZYTMPCBS4FY3SN5AC6DUEF6CH', N'cd208305-a0a1-4938-91a1-245ba04b5b23', N'8887766', 0, 0, CAST(N'2023-05-27T11:50:33.6876218+05:30' AS DateTimeOffset), 1, 0, N'chd', N'ApplicationUser', N'Company', N'87655', N'chd', N'chd', 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City], [Discriminator], [Name], [PostalCode], [State], [StreetAddress], [CompanyId]) VALUES (N'd48c280d-d967-42b1-bb97-be11a7c2a797', N'Employee@gmail.com', N'EMPLOYEE@GMAIL.COM', N'Employee@gmail.com', N'EMPLOYEE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEN369TjbPMcH7AvqQWTQpZLNE9+V+zRc4QKjvugy86bOtWOunnPI7JoUzQfYCzTLGg==', N'6DVK42DSMZ2CUPXPJQY6N3WTIAKOK4NT', N'fcca610e-0637-4865-b194-e1dffc94d557', N'66666', 0, 0, NULL, 1, 0, N'UNA', N'ApplicationUser', N'Employee', N'87655', N'HP', N'AMB', 2)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City], [Discriminator], [Name], [PostalCode], [State], [StreetAddress], [CompanyId]) VALUES (N'e852ef5b-a818-49d9-ad15-74d15a5b74f6', N'individual@gmail.com', N'INDIVIDUAL@GMAIL.COM', N'individual@gmail.com', N'INDIVIDUAL@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEPydc+FQO4TdhUcuhZ/C4lw2VnKe32m/KLW4NDZnfkAsVq+FL0FhYicRhl1gECoutQ==', N'I72RGQPT5YSDJRFGAPEGSZG7C7Y7GPTL', N'2b9aa055-1cd4-436a-8bfe-bd297357045c', N'3456765433', 0, 0, NULL, 1, 0, N'chd', N'ApplicationUser', N'individual', N'16092', N'chd', N'chd', NULL)
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([id], [Name]) VALUES (1, N'Nike')
INSERT [dbo].[Brands] ([id], [Name]) VALUES (2, N'jordan')
INSERT [dbo].[Brands] ([id], [Name]) VALUES (3, N'jimmychoo')
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([id], [Name]) VALUES (1, N'First copy')
INSERT [dbo].[Categories] ([id], [Name]) VALUES (2, N'Second copy')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([Id], [Name], [StreetAddress], [City], [State], [PostalCode], [PhoneNumber], [IsAuthorizedCompany]) VALUES (1, N'firstCompany', N'chd', N'chd', N'chd', N'12343', N'65444444', 0)
INSERT [dbo].[Companies] ([Id], [Name], [StreetAddress], [City], [State], [PostalCode], [PhoneNumber], [IsAuthorizedCompany]) VALUES (2, N'seccompany', N'ji', N'ji', N'ji', N'8768', N'999999', 0)
SET IDENTITY_INSERT [dbo].[Companies] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (1, 1, 1, 1, 888)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [Price]) VALUES (2, 2, 3, 1, 500)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderHeaders] ON 

INSERT [dbo].[OrderHeaders] ([id], [ApplicationUserId], [OrderDate], [ShippingDate], [OrderTotal], [TrackingNumber], [Carrier], [OrderStatus], [PaymentStatus], [PaymentDate], [PaymentDueDate], [TransactionId], [Name], [StreetAddress], [City], [State], [PostalCode], [PhoneNumber]) VALUES (1, N'045b0ae7-7802-4cd0-b472-1452414a3e2a', CAST(N'2023-04-22T10:14:36.2215510' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 888, NULL, NULL, N'Approved', N'Approved', CAST(N'2023-04-22T10:14:39.3791820' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'txn_3MzYJMSIPn2LIZd01fseR1fR', N'Admin', N'UNA', N'Amb', N'HP', N'177203', N'987654321')
INSERT [dbo].[OrderHeaders] ([id], [ApplicationUserId], [OrderDate], [ShippingDate], [OrderTotal], [TrackingNumber], [Carrier], [OrderStatus], [PaymentStatus], [PaymentDate], [PaymentDueDate], [TransactionId], [Name], [StreetAddress], [City], [State], [PostalCode], [PhoneNumber]) VALUES (2, N'045b0ae7-7802-4cd0-b472-1452414a3e2a', CAST(N'2023-05-12T08:19:45.7303727' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 500, NULL, NULL, N'Approved', N'Approved', CAST(N'2023-05-12T08:19:47.9515555' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'txn_3N6m3BSIPn2LIZd00voNCcv6', N'Admin', N'UNA', N'Amb', N'HP', N'177203', N'987654321')
SET IDENTITY_INSERT [dbo].[OrderHeaders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [SerialNo], [Description], [ListPrice], [Price50], [Price], [ImageURL], [BrandId], [CategoryId], [ShoeSizeId], [Gender]) VALUES (1, N'335', N'<p><span style="background-color: rgba(80, 151, 255, 0.18); color: #040c28; font-family: ''Google Sans'', arial, sans-serif; font-size: 20px;">The world''s largest athletic apparel company</span><span style="color: #202124; font-family: ''Google Sans'', arial, sans-serif; font-size: 20px; background-color: #ffffff;">, Nike is best known for its footwear, apparel, and equipment. Founded in 1964 as Blue Ribbon Sports, the company became Nike in 1971 after the Greek goddess of victory. One of the most valuable brands among sport businesses, Nike employs over 76,000 people worldwide.</span></p>', 7800, 677, 888, N'\images\products\7eee1099-517f-493b-84d9-97af63328408.jpg', 1, 1, 1, 1)
INSERT [dbo].[Products] ([Id], [SerialNo], [Description], [ListPrice], [Price50], [Price], [ImageURL], [BrandId], [CategoryId], [ShoeSizeId], [Gender]) VALUES (2, N'334', N'<p><span style="color: #202124; font-family: ''Google Sans'', arial, sans-serif; font-size: 20px; background-color: #ffffff;">Jimmy Choo is&nbsp;</span><span style="background-color: rgba(80, 151, 255, 0.18); color: #040c28; font-family: ''Google Sans'', arial, sans-serif; font-size: 20px;">a leading global luxury brand with an empowered sense of glamour and a playfully daring spirit</span><span style="color: #202124; font-family: ''Google Sans'', arial, sans-serif; font-size: 20px; background-color: #ffffff;">. The brand traces its roots to a bespoke shoemaker named Jimmy Choo, based in the East End of London in the early 1990s, who catered to the global jet set, including Princess Diana.</span></p>', 6800, 800, 777, N'\images\products\247e203f-593a-47ba-bb07-50aa157c4e1f.jpg', 3, 2, 2, 2)
INSERT [dbo].[Products] ([Id], [SerialNo], [Description], [ListPrice], [Price50], [Price], [ImageURL], [BrandId], [CategoryId], [ShoeSizeId], [Gender]) VALUES (3, N'677', N'<p><span style="background-color: rgba(80, 151, 255, 0.18); color: #040c28; font-family: ''Google Sans'', arial, sans-serif; font-size: 16px;">they provide great comfort and support</span><span style="color: #4d5156; font-family: ''Google Sans'', arial, sans-serif; font-size: 16px; background-color: #ffffff;">, unlike other products in the market. As such, people can wear them for a long time without having any discomfort. People are always looking for shoes that will offer them extra support and comfort, making the Air Jordan quite popular.</span></p>', 6000, 600, 500, N'\images\products\1d24f7d1-62d5-4e89-bf7f-334f907546f9.jpg', 2, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ShoeSizes] ON 

INSERT [dbo].[ShoeSizes] ([Id], [Name]) VALUES (1, N'7')
INSERT [dbo].[ShoeSizes] ([Id], [Name]) VALUES (2, N'6')
INSERT [dbo].[ShoeSizes] ([Id], [Name]) VALUES (3, N'5')
SET IDENTITY_INSERT [dbo].[ShoeSizes] OFF
GO
SET IDENTITY_INSERT [dbo].[ShoeSizeSelectors] ON 

INSERT [dbo].[ShoeSizeSelectors] ([Id], [Name]) VALUES (1, N'5')
INSERT [dbo].[ShoeSizeSelectors] ([Id], [Name]) VALUES (2, N'6')
INSERT [dbo].[ShoeSizeSelectors] ([Id], [Name]) VALUES (3, N'7')
INSERT [dbo].[ShoeSizeSelectors] ([Id], [Name]) VALUES (4, N'8')
INSERT [dbo].[ShoeSizeSelectors] ([Id], [Name]) VALUES (5, N'9')
SET IDENTITY_INSERT [dbo].[ShoeSizeSelectors] OFF
GO
SET IDENTITY_INSERT [dbo].[ShoppingCarts] ON 

INSERT [dbo].[ShoppingCarts] ([Id], [ApplicationUserId], [ProductId], [Count], [Size], [ShoeSizeSelectorId]) VALUES (8, N'045b0ae7-7802-4cd0-b472-1452414a3e2a', 1, 1, 0, 1)
SET IDENTITY_INSERT [dbo].[ShoppingCarts] OFF
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Discriminator]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [Gender]
GO
ALTER TABLE [dbo].[ShoppingCarts] ADD  DEFAULT ((0)) FOR [Size]
GO
ALTER TABLE [dbo].[ShoppingCarts] ADD  DEFAULT ((0)) FOR [ShoeSizeSelectorId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUsers_Companies_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([Id])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_AspNetUsers_Companies_CompanyId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_OrderHeaders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderHeaders] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_OrderHeaders_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[OrderHeaders]  WITH CHECK ADD  CONSTRAINT [FK_OrderHeaders_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[OrderHeaders] CHECK CONSTRAINT [FK_OrderHeaders_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands_BrandId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ShoeSizes_ShoeSizeId] FOREIGN KEY([ShoeSizeId])
REFERENCES [dbo].[ShoeSizes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ShoeSizes_ShoeSizeId]
GO
ALTER TABLE [dbo].[ShoppingCarts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCarts_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ShoppingCarts] CHECK CONSTRAINT [FK_ShoppingCarts_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[ShoppingCarts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCarts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShoppingCarts] CHECK CONSTRAINT [FK_ShoppingCarts_Products_ProductId]
GO
ALTER TABLE [dbo].[ShoppingCarts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCarts_ShoeSizeSelectors_ShoeSizeSelectorId] FOREIGN KEY([ShoeSizeSelectorId])
REFERENCES [dbo].[ShoeSizeSelectors] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShoppingCarts] CHECK CONSTRAINT [FK_ShoppingCarts_ShoeSizeSelectors_ShoeSizeSelectorId]
GO
