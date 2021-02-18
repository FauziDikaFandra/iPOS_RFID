USE [POS_LOCAL]
GO

/****** Object:  Table [dbo].[Item_Master_RFID]    Script Date: 04/24/2018 09:11:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Item_Master_RFID](
	[Article_Code] [char](11) NOT NULL,
	[PLU] [char](18) NULL,
	[EPC] [char](50) NOT NULL,
	[TID] [char](50) NULL,
	[USERDATA] [char](50) NULL,
	[EPC4] [char](50) NULL,
	[EPC5] [char](50) NULL,
	[Flag] [char](1) NULL,
	[Status] [char](1) NULL,
 CONSTRAINT [PK_Item_Master_RFID] PRIMARY KEY CLUSTERED 
(
	[Article_Code] ASC,
	[EPC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

