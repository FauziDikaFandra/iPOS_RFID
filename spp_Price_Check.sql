USE [POS_LOCAL]
GO

/****** Object:  StoredProcedure [dbo].[spp_Price_Check]    Script Date: 04/24/2018 09:13:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[spp_Price_Check]
@Trans varchar(25)
,@ListID varchar(3)
,@Tipe varchar(1)
AS
declare @CountTrs Integer
declare @PLU varchar(18)
declare @Max Integer

If @Tipe =  1 
Set @CountTrs = (select ISNULL(SUM(Qty),0) As Total from Sales_Transaction_Details where PLU in (select plu from Item_Master_Listing where List_ID = @ListID And Active = 1) and Transaction_Number = @Trans)
else
Set @CountTrs = (select ISNULL(SUM(Qty),0) *-1 As Total from Sales_Transaction_Details where PLU in (select plu from Item_Master_Listing where List_ID = @ListID And Active = 1) and Transaction_Number = @Trans)

if @CountTrs > 0
BEGIN
DECLARE hitungMaxQty CURSOR FOR
SELECT  plu, Max(Qty) AS Qty FROM Item_Master_Listing where plu in (Select PLU from Sales_Transaction_Details where Transaction_Number = @Trans) and Active = 1
group by plu

OPEN hitungMaxQty;
FETCH NEXT FROM hitungMaxQty INTO @PLU, @Max;
WHILE @@FETCH_STATUS = 0
BEGIN
if @CountTrs >= @Max 
update a set a.price = b.price from Sales_Transaction_Details a inner join Item_Master_Listing b on a.PLU = b.PLU where b.Qty = @Max and List_ID = @ListID and Transaction_Number = @Trans and a.PLU = @PLU and Active = 1
else
update a set a.price = b.price from Sales_Transaction_Details a inner join Item_Master_Listing b on a.PLU = b.PLU where b.Qty = @CountTrs and List_ID = @ListID and Transaction_Number = @Trans and a.PLU = @PLU and Active = 1

FETCH NEXT FROM hitungMaxQty INTO @PLU, @Max;
END
CLOSE hitungMaxQty;

DEALLOCATE hitungMaxQty;
END
--else 
--BEGIN
--update a set a.price = b.Current_Price from Sales_Transaction_Details a inner join Item_Master b on a.PLU = b.PLU where Transaction_Number = @Trans and Current_Price <> 0
--END

update Sales_Transaction_Details set Amount = qty*Price,Discount_Amount = (Discount_Percentage/100) * (qty*Price) where Transaction_Number = @Trans
update Sales_Transaction_Details set ExtraDisc_Amt = (ExtraDisc_Pct / 100) * (Amount - Discount_Amount),Net_Price = Amount - Discount_Amount - (ExtraDisc_Pct / 100) * (Amount - Discount_Amount) where Transaction_Number = @Trans





GO

