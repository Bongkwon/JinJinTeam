-- 전체 회원 목록( 탈퇴대기자 포함)
create procedure select_cus
as
	select * from dbo.customers
go

-- 탈퇴 대기중인 회원 목록
create procedure select_cus_withdrawal
as
select * from dbo.customers
where cus_state = 0
go

-- 회원 추가
CREATE PROCEDURE [dbo].insert_cus
	@cus_ID varchar(30),
	@cus_pwd varchar(128),
	@cus_phone varchar(15),
	@cus_addr nvarchar(max),
	@cus_name nvarchar(30),
	@cus_Nickname nvarchar(40),
	@cus_gender bit,
	@cus_age int
AS
insert into dbo.customers(cus_ID,cus_pwd,cus_phone,cus_addr,cus_name,cus_Nickname,cus_gender,cus_age)
values(@cus_ID,@cus_pwd,@cus_phone,@cus_addr,@cus_name,@cus_Nickname,@cus_gender,@cus_age)
go


-- 회원삭제	( 자동으로 스레드 )
create procedure dbo.delete_cus
as
delete from dbo.customers
where cus_state = 0 and withdrawal_date + 30 <= getdate()
go

-- 회원삭제 ( 포커스 )
create  procedure dbo.delete_cus_force
	@cus_no int
as
	delete from dbo.customers
	where cus_no = @cus_no
go


-- 회원 업데이트 ( 회원이 정보수정할때)
create procedure dbo.update_cus
@cus_no				 INT,
@cus_ID				 VARCHAR,
@cus_pwd			 VARCHAR,
@cus_phone			 VARCHAR,
@cus_addr			 NVARCHAR,
@cus_name			 NVARCHAR,
@cus_Nickname		 NVARCHAR,
@cus_gender			 bit,
@cus_age			 INT,    
@cus_state			 BIT,   
@cus_count			 int,
@withdrawal_date	 DATETIME,
@join_date			 datetime
as
update dbo.customers
set 		
	 cus_ID			 = @cus_ID,			
	 cus_pwd		 = @cus_pwd	,	
	 cus_phone		 = @cus_phone,		
	 cus_addr		 = @cus_addr,	
	 cus_name		 = @cus_name,	
	 cus_Nickname	 = @cus_Nickname,	
	 cus_gender		 = @cus_gender,	
	 cus_age		 = @cus_age,
	 cus_state		 = @cus_state,	
	 cus_count		 = @cus_count,	
	 withdrawal_date = @withdrawal_date,
	 join_date		 = @join_date		
where cus_no = @cus_no
go

-- 회원 탈퇴 버튼시
create procedure dbo.update_cus_withdrawal
@cus_no				 INT,  
@cus_state			 BIT,   
@withdrawal_date	 DATETIME
as
update dbo.customers
set 			 
	 cus_state		 = @cus_state,	
	 withdrawal_date = @withdrawal_date	
where cus_no = @cus_no
go

-- 회원 배송정보 카운트업
create procedure dbo.update_cus_count
@cus_no				 INT
as
update dbo.customers
set 				
	 cus_count +=1	
where cus_no = @cus_no
go


-- 회원
------------------------------------------------------------------------------------------------------------------------
-- 판매자


-- 판매자 추가
CREATE PROCEDURE [dbo].insert_seller
	@seller_ID varchar(30),
	@seller_pwd varchar(128),
	@seller_name nvarchar(30),
	@seller_addr varchar(max),
	@seller_boss varchar(30),
	@seller_phone varchar(15),
	@seller_postal varchar(10),
	@seller_email varchar(50),
	@seller_fax varchar(20),
	@return_addr nvarchar(max),
	@corporate_registration_no varchar(15)
AS
insert into dbo.seller(seller_ID,seller_pwd,seller_name,seller_addr,seller_boss,seller_phone,seller_postal,seller_email,seller_fax,return_addr,corporate_registration_no)
values(@seller_ID,@seller_pwd,@seller_name,@seller_addr,@seller_boss,@seller_phone,@seller_postal,@seller_email,@seller_fax,@return_addr,@corporate_registration_no)
go

-- 판매자 삭제
create procedure dbo.delete_selllers
@seller_no int
as
delete from dbo.sellers
where seller_no = @seller_no
go

-- 상품 추가	//???
CREATE PROCEDURE [dbo].insert_product
	@pro_ID       VARCHAR (20),
	@cat_ID       VARCHAR (4),
	@seller_no    INT,
	@pro_name     NVARCHAR (50),
	@pro_price    INT,
	@main_comment VARCHAR (MAX),
	@sub_comment  VARCHAR (MAX),
	@main_image   VARCHAR (MAX),
	@pro_gender   VARCHAR (2)      
AS
insert into dbo.products(pro_id,cat_id,seller_no,pro_name,pro_price,main_comment,sub_comment,main_image,pro_gender)
values(@pro_id,@cat_id,@seller_no,@pro_name,@pro_price,@main_comment,@sub_comment,@main_image,@pro_gender)
go


-- 재고 추가
create procedure dbo.insert_stock
	@stock_ID    VARCHAR (40), 
	@pro_ID    VARCHAR (30), 
	@seller_no   INT      ,    
	@stock_size  NVARCHAR (40),
	@stock_count INT          
as
insert into dbo.stock_List(stock_id,pro_id,seller_no,stock_size,stock_count)
values(@stock_id,@pro_id,@seller_no,@stock_size,@stock_count)
go


-- 이미지 목록 추가
create procedure dbo.insert_iamge
 @image_ID  VARCHAR (30), 
 @pro_ID   VARCHAR (30) ,
 @sub_image VARCHAR (MAX)
as
insert into dbo.image_List(image_ID,pro_ID,sub_image)
values(@image_ID,@pro_ID,@sub_image)
go


-- 카테고리 추가
create procedure dbo.insert_cat
 @cat_ID   VARCHAR (6),  
 @cat_kind NVARCHAR (20)
 as
insert into dbo.category_List(cat_ID,cat_kind)
values(@cat_ID,@cat_kind)
go


