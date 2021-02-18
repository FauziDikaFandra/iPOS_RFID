USE [POS_LOCAL]
GO

/****** Object:  Table [dbo].[Sales_Transaction_Details]    Script Date: 04/24/2018 09:11:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sales_Transaction_Details](
	[Transaction_Number] [char](21) NOT NULL,
	[Seq] [int] NOT NULL,
	[PLU] [char](18) NULL,
	[Item_Description] [varchar](50) NULL,
	[Price] [money] NULL,
	[Qty] [decimal](6, 2) NULL,
	[Amount] [money] NULL,
	[Discount_Percentage] [decimal](5, 2) NULL,
	[Discount_Amount] [money] NULL,
	[ExtraDisc_Pct] [decimal](5, 2) NULL,
	[ExtraDisc_Amt] [money] NULL,
	[Net_Price] [money] NULL,
	[Points_Received] [int] NULL,
	[Flag_Void] [int] NULL,
	[Flag_Status] [int] NULL,
	[Flag_Paket_Discount] [int] NULL,
	[Epc_Code] [varchar](50) NULL,
 CONSTRAINT [PK_SALES TRANSACTION DETAILS] PRIMARY KEY CLUSTERED 
(
	[Transaction_Number] ASC,
	[Seq] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Sales_Transaction_Details]  WITH NOCHECK ADD  CONSTRAINT [FK_SALES TR_REF_1899_SALES T] FOREIGN KEY([Transaction_Number])
REFERENCES [dbo].[Sales_Transactions] ([Transaction_Number])
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] CHECK CONSTRAINT [FK_SALES TR_REF_1899_SALES T]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Trans__PLU__573DED66]  DEFAULT ('') FOR [PLU]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Item___5832119F]  DEFAULT ('') FOR [Item_Description]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Price__592635D8]  DEFAULT ((0)) FOR [Price]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Trans__Qty__5A1A5A11]  DEFAULT ((0)) FOR [Qty]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Amoun__5B0E7E4A]  DEFAULT ((0)) FOR [Amount]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Disco__5C02A283]  DEFAULT ((0)) FOR [Discount_Percentage]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Disco__5CF6C6BC]  DEFAULT ((0)) FOR [Discount_Amount]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF_Sales_Transaction_Details_ExtraDisc_Pct]  DEFAULT ((0)) FOR [ExtraDisc_Pct]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF_Sales_Transaction_Details_ExtraDisc_Amt]  DEFAULT ((0)) FOR [ExtraDisc_Amt]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Net_P__5DEAEAF5]  DEFAULT ((0)) FOR [Net_Price]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Point__5EDF0F2E]  DEFAULT ((0)) FOR [Points_Received]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Flag___5FD33367]  DEFAULT ((0)) FOR [Flag_Void]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Flag___60C757A0]  DEFAULT ((0)) FOR [Flag_Status]
GO

ALTER TABLE [dbo].[Sales_Transaction_Details] ADD  CONSTRAINT [DF__Sales_Tra__Flag___61BB7BD9]  DEFAULT ((0)) FOR [Flag_Paket_Discount]
GO

