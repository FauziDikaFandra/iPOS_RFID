USE [POS_LOCAL]
GO

/****** Object:  Table [dbo].[Item_Master_Listing]    Script Date: 04/24/2018 09:10:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Item_Master_Listing](
	[Branch_ID] [char](4) NULL,
	[List_ID] [varchar](3) NULL,
	[PLU] [char](18) NULL,
	[Qty] [int] NULL,
	[Price] [money] NULL,
	[Active] [char](1) NULL,
	[Start_Date] [datetime] NULL,
	[End_Date] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

