--select_cus_inq
CREATE PROCEDURE [dbo].Select_Cus_Inq
as
select c.cus_Nickname, C.cus_ID ,I.* from dbo.Inquire_Admin I, dbo.customers C
where cus_or_sell = 'C' and c.cus_no = i.cus_no
order by I.Inquire_no desc;
go

--Select_sales
CREATE PROCEDURE [dbo].Select_Sales
as
select s.seller_ID, convert(char(10),p.pay_date,23) as pay_date, p.pay_count,p.pay_price from payment_info p, seller S where p.seller_no = s.seller_no
go                                                                                                                                       
--select_sel_inq
CREATE PROCEDURE [dbo].Select_Sel_Inq
as
select s.seller_ID,s.seller_email ,I.* from dbo.Inquire_Admin I, dbo.seller S
where cus_or_sell = 'S' and S.seller_no = I.seller_no
order by I.Inquire_no desc;
go

--select_taxBill
CREATE procedure dbo.Select_TaxBill
as
select p.pay_ID, o.stock_ID , s.seller_ID, s.seller_boss, s.seller_addr, s.corporate_registration_no, p.pay_price, p.pay_count, p.pay_date, p.output_date_tax
from seller s, order_List o, payment_info p 
where s.seller_no = p.seller_no and p.order_ID = o.order_ID
order by p.pay_ID desc
go

--select_cus
create procedure Select_Cus
as
	select * from dbo.customers
go

--select_cus_withdrawal
create procedure Select_Cus_Withdrawal
as
select * from dbo.customers
where cus_state = 0
go

--select_pro
create procedure Select_Pro
as
	select * from dbo.products
go

--select_pro_state_0
create procedure Select_Pro_State_0
as
	select * from dbo.products
	where pro_state = 0
go

--select_seller
create procedure Select_Seller
as
	select * from dbo.seller
go

--select_seller_join_0
create procedure Select_Seller_Join_0
as
	select * from dbo.seller
	where join_state = 0
go

--select_seller_state_0
create procedure Select_Seller_State_0
as
	select * from dbo.seller
	where seller_state = 0
go

--delete_cus
CREATE procedure dbo.Delete_Cus
as
delete from dbo.customers
where cus_state = 0 and withdrawal_date + 30 <= getdate()
go

--update_seller_join_state
create procedure Update_Seller_Join_State
	@seller_no int,
	@join_state bit,
	@seller_state bit
as
	update dbo.seller
	set join_state = @join_state , seller_state = @seller_state
	where seller_no = @seller_no
go

--update_products_state
	create procedure Update_Products_State
		@pro_ID varchar(20),
		@pro_state bit
	as
		update dbo.products
		set pro_state = @pro_state
		where pro_ID = @pro_ID
go

--update_pay_tax_date
CREATE PROCEDURE [dbo].Update_Pay_Tax_Date
	@pay_id int
AS
update dbo.payment_info
set output_date_tax = GETDATE()
where pay_id = @pay_id
go

--update_Inquire_Admin
CREATE PROCEDURE [dbo].Update_Inquire_Admin
	@inquire_no int,
	@re_body nvarchar(max)
AS
	update dbo.Inquire_Admin
	set re_body = @re_body, re_date = CONVERT(date,(dateadd(hour,(9),getdate())),112)
	where Inquire_no = @inquire_no
go

--Selct_T_Inq_count
CREATE PROCEDURE [dbo].Selct_T_Inq_count
AS
select count(1) count from dbo.Inquire_Admin I
where CONVERT(date,I.Inquire_date,112) = convert(date,dateadd(hour,9,getdate()),112)
go
--Selct_T_pay_count
CREATE PROCEDURE [dbo].Selct_T_pay_count
AS
select count(1) count from payment_info p
where convert(date,p.pay_date,112) = convert(date,dateadd(hour,9,getdate()),112)
go
--Selct_Sel_join_count
CREATE PROCEDURE [dbo].Selct_Sel_join_count
AS
select count(1) count from dbo.seller s
where s.join_state = 0
go
--Selct_Pro_state_count
CREATE PROCEDURE [dbo].Selct_Pro_state_count
AS
select count(1) count from dbo.products p
where p.pro_state = 0
go
