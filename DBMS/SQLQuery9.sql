USE [CustomerDb1]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 14-06-2022 12:35:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Supplier](
	[Id] [int]  IDENTITY(1,1) NOT NULL,
	[SupplierCode] [nvarchar](50) NULL,
	[SupplierName] [nvarchar](50) NULL,
	[SupplierAmount] [int] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


