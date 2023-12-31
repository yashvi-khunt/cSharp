USE [master]
GO
/****** Object:  Database [Invoice]    Script Date: 25-12-2023 13:09:07 ******/
CREATE DATABASE [Invoice]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Invoice', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Invoice.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Invoice_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Invoice_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Invoice] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Invoice].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Invoice] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Invoice] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Invoice] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Invoice] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Invoice] SET ARITHABORT OFF 
GO
ALTER DATABASE [Invoice] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Invoice] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Invoice] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Invoice] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Invoice] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Invoice] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Invoice] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Invoice] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Invoice] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Invoice] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Invoice] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Invoice] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Invoice] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Invoice] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Invoice] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Invoice] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Invoice] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Invoice] SET RECOVERY FULL 
GO
ALTER DATABASE [Invoice] SET  MULTI_USER 
GO
ALTER DATABASE [Invoice] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Invoice] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Invoice] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Invoice] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Invoice] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Invoice] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Invoice', N'ON'
GO
ALTER DATABASE [Invoice] SET QUERY_STORE = ON
GO
ALTER DATABASE [Invoice] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Invoice]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] IDENTITY(100,1) NOT NULL,
	[PartyID] [int] NOT NULL,
	[invoiceDate] [date] NOT NULL,
	[GrandTotal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[InvoiceID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Total] [int] NOT NULL,
	[DetailsID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Party]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Party](
	[PartyID] [int] IDENTITY(1,1) NOT NULL,
	[PartyName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PartyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartyProductMapping]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartyProductMapping](
	[PartyID] [int] NOT NULL,
	[ProductID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductRate] [int] NOT NULL,
	[ProductDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](16) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[PartyID] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (151, 8, CAST(N'2023-10-27' AS Date), 90)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (155, 6, CAST(N'2023-10-27' AS Date), 210)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (159, 8, CAST(N'2023-10-27' AS Date), 175)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (160, 8, CAST(N'2023-10-27' AS Date), 70)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (161, 3, CAST(N'2023-10-27' AS Date), 20)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (162, 6, CAST(N'2023-10-27' AS Date), 175)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (163, 3, CAST(N'2023-10-27' AS Date), 50)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (168, 8, CAST(N'2023-10-27' AS Date), 60)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (169, 8, CAST(N'2023-10-27' AS Date), 70)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (170, 8, CAST(N'2023-10-27' AS Date), 50)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (172, 7, CAST(N'2023-10-30' AS Date), 245)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (173, 8, CAST(N'2023-10-30' AS Date), NULL)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (174, 7, CAST(N'2023-10-30' AS Date), 275)
INSERT [dbo].[Invoice] ([InvoiceID], [PartyID], [invoiceDate], [GrandTotal]) VALUES (175, 6, CAST(N'2023-12-21' AS Date), 35)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[InvoiceDetails] ON 

INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (151, 6, 5, 50, 53)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (155, 7, 6, 210, 59)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (155, 7, 7, 245, 60)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (159, 7, 5, 175, 65)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (160, 7, 2, 70, 67)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (161, 6, 2, 20, 69)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (162, 7, 5, 175, 71)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (163, 6, 5, 50, 73)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (168, 6, 6, 60, 76)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (168, 6, 3, 30, 77)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (169, 6, 7, 70, 78)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (170, 6, 5, 50, 79)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (172, 6, 10, 100, 81)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (172, 7, 7, 245, 82)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (173, 6, 7, 70, 83)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (173, 7, 5, 175, 84)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (174, 6, 10, 100, 85)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (174, 7, 5, 175, 86)
INSERT [dbo].[InvoiceDetails] ([InvoiceID], [ProductID], [Quantity], [Total], [DetailsID]) VALUES (175, 7, 1, 35, 87)
SET IDENTITY_INSERT [dbo].[InvoiceDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Party] ON 

INSERT [dbo].[Party] ([PartyID], [PartyName]) VALUES (8, N'Ayaz')
INSERT [dbo].[Party] ([PartyID], [PartyName]) VALUES (9, N'Party1')
INSERT [dbo].[Party] ([PartyID], [PartyName]) VALUES (3, N'party2')
INSERT [dbo].[Party] ([PartyID], [PartyName]) VALUES (4, N'Party3')
INSERT [dbo].[Party] ([PartyID], [PartyName]) VALUES (6, N'Priyank')
INSERT [dbo].[Party] ([PartyID], [PartyName]) VALUES (7, N'Yashvi')
SET IDENTITY_INSERT [dbo].[Party] OFF
GO
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (3, 6)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (3, 5)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (3, 3)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (4, 3)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (4, 6)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (6, 6)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (6, 7)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (7, 6)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (7, 7)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (8, 6)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (8, 7)
INSERT [dbo].[PartyProductMapping] ([PartyID], [ProductID]) VALUES (8, 8)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductRate], [ProductDate]) VALUES (3, N'Product2', 57, CAST(N'2023-10-03' AS Date))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductRate], [ProductDate]) VALUES (5, N'Product3', 456, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductRate], [ProductDate]) VALUES (6, N'Biscuits', 10, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductRate], [ProductDate]) VALUES (7, N'Chocolate', 35, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductRate], [ProductDate]) VALUES (8, N'Icecream', 40, CAST(N'2023-10-26' AS Date))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
/****** Object:  Index [IX_tblInvoiceDetails_ProductName]    Script Date: 25-12-2023 13:09:08 ******/
CREATE NONCLUSTERED INDEX [IX_tblInvoiceDetails_ProductName] ON [dbo].[InvoiceDetails]
(
	[InvoiceID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Party__A9C88632E6294329]    Script Date: 25-12-2023 13:09:08 ******/
ALTER TABLE [dbo].[Party] ADD UNIQUE NONCLUSTERED 
(
	[PartyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblParty_PartyName]    Script Date: 25-12-2023 13:09:08 ******/
CREATE NONCLUSTERED INDEX [IX_tblParty_PartyName] ON [dbo].[Party]
(
	[PartyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Product__DD5A978A84D67B70]    Script Date: 25-12-2023 13:09:08 ******/
ALTER TABLE [dbo].[Product] ADD UNIQUE NONCLUSTERED 
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblProduct_ProductName]    Script Date: 25-12-2023 13:09:08 ******/
CREATE NONCLUSTERED INDEX [IX_tblProduct_ProductName] ON [dbo].[Product]
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([PartyID])
REFERENCES [dbo].[Party] ([PartyID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PartyProductMapping]  WITH CHECK ADD FOREIGN KEY([PartyID])
REFERENCES [dbo].[Party] ([PartyID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PartyProductMapping]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([PartyID])
REFERENCES [dbo].[Party] ([PartyID])
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[add_assign]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_assign](
	@partyID INT,
	@productID INT
)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM PartyProductMapping WHERE PartyID = @partyID and ProductID = @productID)
	BEGIN
		 SELECT 'Error: Duplicate entry found. Record not inserted.';
	END
	ELSE
	BEGIN
		INSERT INTO PartyProductMapping VALUES (@partyID,@productID);
		SELECT 'Record inserted successfully.';
	END
END
GO
/****** Object:  StoredProcedure [dbo].[AddGrantTotal]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddGrantTotal] (
	@invid int
)
as
begin 
	declare @gt int
	select @gt = sum(total) from InvoiceDetails where InvoiceID = @invid;

	update Invoice
	set grandtotal = @gt
	where InvoiceID = @invid
end
GO
/****** Object:  StoredProcedure [dbo].[AddInvoice]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddInvoice](
	@partyID int,
	@date date ,
	@invId int output
)
as 
begin 
	insert into Invoice(PartyID,invoiceDate) values(@partyID,@date);
	select @invId = max(invoiceId) from Invoice
end
GO
/****** Object:  StoredProcedure [dbo].[AddInvoiceDetails]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddInvoiceDetails](
	@invoiceid int,
	@productid int,
	@quantity int,
	@total int
)
as
begin
	insert into invoiceDetails values(@invoiceid,@productid,@quantity,@total)
	Select 'Inserted Successfully';
end
GO
/****** Object:  StoredProcedure [dbo].[AddParty]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddParty]
    @pname VARCHAR(50)
    -- Add other parameters for other columns
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the value already exists in the table
    IF NOT EXISTS (SELECT 1 FROM Party WHERE PartyName = @pname)
    BEGIN
        -- Insert the record if it's not a duplicate
        INSERT INTO Party
        VALUES (@pname); -- Insert other column values

        SELECT 'Record inserted successfully.';
    END
    ELSE
    BEGIN
        -- Handle the duplicate entry
        SELECT 'Error: Duplicate entry found. Record not inserted.';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[AddProduct]
    @pname VARCHAR(50),
	@rate int ,
	@date date
    -- Add other parameters for other columns
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the value already exists in the table
    IF NOT EXISTS (SELECT 1 FROM Product WHERE ProductName = @pname)
    BEGIN
        -- Insert the record if it's not a duplicate
        INSERT INTO Product
        VALUES (@pname,@rate,@date); -- Insert other column values

        SELECT 'Record inserted successfully.';
    END
    ELSE
    BEGIN
        -- Handle the duplicate entry
        SELECT 'Error: Duplicate entry found. Record not inserted.';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[delete_invoiceDetails_by_Id]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[delete_invoiceDetails_by_Id](
	@id int
)
as
begin
	delete InvoiceDetails where DetailsID=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteAssign]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteAssign](
	@partyname varchar(50),
	@productname varchar(50)
)
as
begin 

	declare @partyid int = (select Partyid from Party where PartyName = @partyname)
	declare @productid int = (select productid from product where productName = @productname)
	delete PartyProductMapping where PartyID=@partyid and Productid = @productid;
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteInvoiceDetails]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteInvoiceDetails](
	-- Add the parameters for the stored procedure here
	@invid int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE InvoiceDetails
	WHERE DetailsID=@invid
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteParty]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DeleteParty](
	@partyid int
)
as
begin 
	delete Party where PartyID=@partyid
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteProduct](
	@productid int
)
as
begin 
	delete from Product where ProductID = @productid
end
GO
/****** Object:  StoredProcedure [dbo].[edit_invoice_details_by_Id]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[edit_invoice_details_by_Id](
	@id int,
	@productid int,
	@quantity int,
	@total int
)
as
begin
	update InvoiceDetails
	set ProductID=@productid,Quantity=@quantity,Total=@total
	where DetailsID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[EditParty]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditParty](
	@newname varchar(50),
	@partyid int
)
as
BEGIN
	IF EXISTS (SELECT 1 from Party where PartyName = @newname and PartyID = @partyid)
		BEGIN
			Select 'No change'
		END
	ELSE
		BEGIN
			IF NOT EXISTS (SELECT 1 FROM Party WHERE PartyName = @newname)
				BEGIN
					-- Insert the record if it's not a duplicate
					UPDATE Party
					SET PartyName = @newname WHERE PartyID = @partyid; -- Insert other column values
					SELECT 'Record updated successfully.';

			END
			ELSE
			BEGIN
				-- Handle the duplicate entry
				SELECT 'Error: Duplicate entry found. Record not updated.';
			END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[EditProduct]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[EditProduct](
	@newname varchar(50),
	@productid int,
	@newrate int,
	@newdate date
)
as
BEGIN
	IF EXISTS (SELECT 1 from Product where ProductName = @newname and ProductID = @productid and ProductDate=@newdate and ProductRate=@newrate)
		BEGIN
			Select 'Error: Duplicate entry found. Record not updated'
		END
	ELSE
		BEGIN
			--IF NOT EXISTS (SELECT 1 FROM Product WHERE ProductName = @newname)
			--	BEGIN
					-- Insert the record if it's not a duplicate
					UPDATE Product
					SET ProductName = @newname,ProductDate=@newdate,ProductRate=@newrate WHERE ProductID = @productid; -- Insert other column values
					SELECT 'Record updated successfully.';

			--END
			--ELSE
			--BEGIN
			--	-- Handle the duplicate entry
			--	SELECT 'Error: Duplicate entry found. Record not updated.';
			--END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[get_assignList]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE PROCEDURE [dbo].[get_assignList] as 
 begin
select PartyName,ProductName from partyproductmapping ppm
 inner join Party 
on Party.PartyID = ppm.PartyId
inner join Product
on Product.ProductID = ppm.productID
order by ppm.PartyId
end
GO
/****** Object:  StoredProcedure [dbo].[get_InvoicebyId]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[get_InvoicebyId] (
	@invoiceid int,
	@party varchar(50) output,
	@date date output,
	@gt int output
)
as
begin 
	Select @party=PartyName,@date=invoicedate,@gt=grandtotal from Invoice
	inner join Party
	on invoice.partyid = party.partyid
	where invoiceid = @invoiceid;
end
GO
/****** Object:  StoredProcedure [dbo].[get_invoiceDetailsById]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_invoiceDetailsById](
	@invid int
)
as 
begin
	select DetailsID as id,Product.ProductID,ProductName,ProductRate, Quantity, Total from InvoiceDetails
	inner join Product 
	on Product.ProductId = InvoiceDetails.ProductId
	where invoiceId = @invId
end
GO
/****** Object:  StoredProcedure [dbo].[get_invoiceList]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[get_invoiceList] as
begin
select Invoiceid,PartyName,Invoicedate,GrandTotal from invoice
inner join Party
ON Party.PartyID = Invoice.PARTYid
order by Invoice.invoiceID
end
GO
/****** Object:  StoredProcedure [dbo].[get_party]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[get_party] as
begin
select * from Party
order by PartyID
end
GO
/****** Object:  StoredProcedure [dbo].[get_partyInvoiceList]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[get_partyInvoiceList] as
begin
	select Party.PartyID, PartyName from Party
	inner join partyproductmapping ppm
	on ppm.partyid = party.partyid
	group by Party.PartyID,PartyName
end
GO
/****** Object:  StoredProcedure [dbo].[get_productInvoiceList]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[get_productInvoiceList](
	@partyid int 
)
as
begin
select product.ProductID,ProductName from Product
inner join partyproductmapping ppm
on ppm.productid = product.productid
where partyid = @partyid
end
GO
/****** Object:  StoredProcedure [dbo].[get_productRateList]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[get_productRateList](
	@productId int 
)
as
begin
select productRate from Product
where productid = @productId
end
GO
/****** Object:  StoredProcedure [dbo].[get_products]    Script Date: 25-12-2023 13:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[get_products] as
begin
select * from Product
order by ProductID
end
GO
USE [master]
GO
ALTER DATABASE [Invoice] SET  READ_WRITE 
GO
