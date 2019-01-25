CREATE TABLE [dbo].[category_List] (
    [cat_ID]   VARCHAR (6)   NOT NULL,	-- 카테고리 번호
    [cat_kind] NVARCHAR (20) NOT NULL,	-- 카테고리 종류
    PRIMARY KEY CLUSTERED ([cat_ID] ASC)
);
go


CREATE TABLE [dbo].[customers] (
    [cus_no]       INT           NOT NULL IDENTITY,	-- 고객 번호
    [cus_ID]       VARCHAR (30)  NOT NULL,	-- 고객 아이디
    [cus_pwd]      VARCHAR (128) NOT NULL,	-- 고객 비밀번호
    [cus_phone]    VARCHAR (15)  NOT NULL,	-- 고객 전화번호
    [cus_addr]     NVARCHAR (max) NOT NULL,	-- 고객 주소
    [cus_name]     NVARCHAR (30) NOT NULL,	-- 고객 이름
    [cus_Nickname] NVARCHAR (40) NULL,	-- 고객 별명
    [cus_gender]   bit   NOT NULL,	-- 고객 성별
    [cus_age]      INT           NOT NULL,	-- 고객 나이
    [cus_state]    BIT           DEFAULT ((1)) NOT NULL,	-- 고객 정보 상태	1 = 가입, 0 = 탈퇴대기
	[cus_count] INT NULL DEFAULT 1,		-- 배송정보 카운트
	[withdrawal_date] DATETIME NULL,  -- 탈퇴 날짜
	[join_date] datetime  default getdate() Not Null -- 가입날짜
    PRIMARY KEY CLUSTERED ([cus_no] ASC),
    UNIQUE NONCLUSTERED ([cus_phone] ASC),
    UNIQUE NONCLUSTERED ([cus_ID] ASC)
);
go

CREATE TABLE [dbo].[image_List] (
    [image_ID]  VARCHAR (30)  NOT NULL,	-- 이미지 번호
    [pro_ID]    VARCHAR (30)  NOT NULL,	-- 상품 번호
    [sub_image] VARCHAR (MAX) NOT NULL,	-- 상품 이미지
    PRIMARY KEY CLUSTERED ([image_ID] ASC)
	-- ,CONSTRAINT [img_pro_FK] FOREIGN KEY ([pro_ID]) REFERENCES [dbo].[products] ([pro_ID]) 
);
go

CREATE TABLE [dbo].[order_List] (
    [order_ID]    VARCHAR (25) NOT NULL,	-- 주문 번호
    [cus_no]      INT          NOT NULL,	-- 고객 번호
    [stock_ID]    VARCHAR (40) NOT NULL,	-- 재고 번호
    [order_count] INT          NOT NULL,	-- 주문 수량
    [order_price] INT          NOT NULL,	-- 주문 가격
	[order_require] NVARCHAR(MAX) NULL,		-- 주문 요구사항 (비고)
    PRIMARY KEY CLUSTERED ([order_ID] ASC)
	-- ,CONSTRAINT [ord_stk_FK] FOREIGN KEY ([stock_ID]) REFERENCES [dbo].[stock_List] ([stock_ID]) 
	-- ,CONSTRAINT [ord_cus_FK] FOREIGN KEY ([cus_no]) REFERENCES [dbo].[customers] ([cus_no]) 
);
go

CREATE TABLE [dbo].[payment_info] (
    [pay_ID]       INT          NOT NULL IDENTITY,	-- 결제 번호
    [order_ID]     VARCHAR (25) NOT NULL,	-- 주문 번호
    [user_ship_ID] VARCHAR (10) NOT NULL,	-- 배송지 번호
    [seller_no]    INT          NOT NULL,	-- 판매자 번호
    [pay_count]    INT          NOT NULL,	-- 결제 수량
    [pay_price]    INT          NOT NULL,	-- 결제 가격
    [waybill_ID]   VARCHAR (13) NULL,	-- 운송장 번호
    PRIMARY KEY CLUSTERED ([pay_ID] ASC)
	-- ,CONSTRAINT [pay_ord_FK] FOREIGN KEY ([order_ID]) REFERENCES [dbo].[order_List] ([order_ID]) 
	-- ,CONSTRAINT [pay_ship_FK] FOREIGN KEY ([user_ship_Id]) REFERENCES [dbo].[user_ship_info] ([user_ship_Id]) 
	-- ,CONSTRAINT [pay_sell_FK] FOREIGN KEY ([seller_no]) REFERENCES [dbo].[seller] ([seller_no]) 
	-- ,CONSTRAINT [pay_tran_FK] FOREIGN KEY ([waybill_ID]) REFERENCES [dbo].[transport_info] ([waybill_ID]) 
);
go

CREATE TABLE [dbo].[products] (
    [pro_ID]       VARCHAR (20)    NOT NULL,	-- 상품번호
    [cat_ID]       VARCHAR (4)     NOT NULL,	-- 카테고리 번호
    [seller_no]    INT             NOT NULL,	-- 판매자 번호
    [pro_name]     NVARCHAR (50)   NOT NULL,	-- 상품 이름
    [pro_price]    INT             NOT NULL,	-- 상품 가격
    [main_comment] VARCHAR (MAX) NULL,	-- 상품 설명
    [sub_comment]  VARCHAR (MAX)   NULL,	-- 상품 보조설명
    [main_image]   VARCHAR (MAX)   NULL,	-- 상품 대표이미지
    [pro_hits]     INT             NULL,	-- 상품 조회수
    [pro_like]     INT             NULL,	-- 상품 좋아요
    [pro_discount] INT             NULL,	-- 상품 할인율
    [pro_gender]   VARCHAR (2)   NOT NULL,	-- 추천 성별
    [pro_state]    BIT             DEFAULT ((1)) NULL,	-- 상품 정보 상태
    PRIMARY KEY CLUSTERED ([pro_ID] ASC)
	-- ,CONSTRAINT [pro_cat_FK] FOREIGN KEY ([cat_ID]) REFERENCES [dbo].[category_List] ([cat_ID])
	-- ,CONSTRAINT [pro_sell_FK] FOREIGN KEY ([seller_no]) REFERENCES [dbo].[seller] ([seller_no])
);
go

CREATE TABLE [dbo].[review] (
    [re_ID]           INT            NOT NULL,	-- 리뷰 번호
    [cus_no]          INT            NOT NULL,	-- 고객 번호
    [pro_ID]          VARCHAR (30)   NOT NULL,	-- 상품 번호
    [re_like]         BIT            DEFAULT ((1)) NOT NULL,	-- 상품 좋아요
    [re_image]        VARCHAR (MAX)  NOT NULL,	-- 리뷰 이미지
    [re_txt]          NVARCHAR (MAX) NOT NULL,	-- 리뷰 내용
    [re_date]         DATETIME       NOT NULL,	-- 리뷰 날짜
    [re_comment]      NVARCHAR (MAX) NULL,	-- 답글 
    [re_comment_date] DATETIME       NULL,	-- 답글 날짜
    PRIMARY KEY CLUSTERED ([re_ID] ASC)
	-- ,CONSTRAINT [re_pro_FK] FOREIGN KEY ([pro_ID]) REFERENCES [dbo].[products] ([pro_ID])
	-- ,CONSTRAINT [re_cus_FK] FOREIGN KEY ([cus_no]) REFERENCES [dbo].[customers] ([cus_no])
);
go

CREATE TABLE [dbo].[seller] (
    [seller_no]     INT            NOT NULL IDENTITY,	-- 판매자 번호
    [seller_ID]     VARCHAR (30)   NOT NULL,	-- 판매자 아이디
    [seller_pwd]    VARCHAR (128)  NOT NULL,	-- 판매자 비밀번호
    [seller_name]   NVARCHAR (30)  NOT NULL,	-- 판매자 이름
    [seller_addr]   NVARCHAR (MAX) NOT NULL,	-- 회사 주소
    [seller_boss]   NVARCHAR (30)  NOT NULL,	-- 회사 대표
    [seller_phone]  VARCHAR (15)   NOT NULL,	-- 판매자 전화번호
    [seller_postal] varchar(10)       NOT NULL,	-- 회사 우편번호
    [seller_email]  VARCHAR (50)   NOT NULL,	-- 회사 이메일
    [seller_fax]    varchar(20)           NOT NULL,	-- 회사 팩스
    [return_addr]   NVARCHAR (MAX) NOT NULL,	-- 반품지 주소
    [seller_state]  BIT            DEFAULT ((1)) NOT NULL,	-- 판매자 상태 ( 활성화, 비활성화 )
	[corporate_registration_no] varchar(15) NOT NULL, -- 사업자 등록번호
	[join_state] BIT NOT NULL DEFAULT 0,	-- 가입 승인 상태
    PRIMARY KEY CLUSTERED ([seller_no] ASC)
);
go

CREATE TABLE [dbo].[stock_List] (
    [stock_ID]    VARCHAR (40) NOT NULL,  -- 재고 번호
    [pro_ID]      VARCHAR (30) NOT NULL,  -- 상품 번호
    [seller_no]   INT          NOT NULL,  -- 판매자 번호
    [stock_size]  NVARCHAR (40) NOT NULL,  -- 재고 사이즈 종류
    [stock_count] INT          NOT NULL,	-- 재고 개수
    PRIMARY KEY CLUSTERED ([stock_ID] ASC)
	-- ,CONSTRAINT [stk_pro_FK] FOREIGN KEY ([pro_ID]) REFERENCES [dbo].[products] ([pro_ID]) 
	-- ,CONSTRAINT [stk_sell_FK] FOREIGN KEY ([seller_no]) REFERENCES [dbo].[seller] ([seller_no]) 
);
go

CREATE TABLE [dbo].[transport_info] (
    [transport_ID]    INT           NOT NULL IDENTITY,	-- 운송 번호
    [seller_no]       INT           NOT NULL,	-- 판매자 번호
    [waybill_ID]      VARCHAR (13)  NOT NULL,	-- 운송장 번호
    [transport_state] NVARCHAR (20) NOT NULL,	-- 배송 상태
    PRIMARY KEY CLUSTERED ([transport_ID] ASC)
	-- ,CONSTRAINT [tran_sell_FK] FOREIGN KEY ([seller_no]) REFERENCES [dbo].[seller] ([seller_no]) 
	-- ,CONSTRAINT [tran_pay_FK] FOREIGN KEY ([pay_ID]) REFERENCES [dbo].[payment_info] ([pay_ID]) 
);
go

CREATE TABLE [dbo].[user_ship_info] (
    [user_ship_Id] VARCHAR (10)   NOT NULL,	-- 배송지 번호
    [cus_no]       INT            NOT NULL,	-- 고객 번호
    [user_name]    NVARCHAR (30)  NOT NULL,	-- 받는이
    [user_addr]    NVARCHAR (MAX) NOT NULL,	-- 배송지
    [postal_code]  varchar(10)            NOT NULL,	-- 우편 번호
    [ship_require]      NVARCHAR (MAX) NULL,	-- 요구사항
    PRIMARY KEY CLUSTERED ([user_ship_Id] ASC)
	-- ,CONSTRAINT [ship_cus_FK] FOREIGN KEY ([cus_no]) REFERENCES [dbo].[customers] ([cus_no]) 
);
go

CREATE TABLE [dbo].[wish_List] (
    [wish_ID]    VARCHAR (25) NOT NULL,	-- 장바구니 번호
    [cus_ID]     INT          NOT NULL,	-- 고객 번호
    [stock_ID]   VARCHAR (40) NOT NULL,	-- 재고 번호
    [wish_count] INT          NOT NULL,	-- 장바구니 수량
    [wish_price] INT          NOT NULL,	-- 장바구니 가격
    PRIMARY KEY CLUSTERED ([wish_ID] ASC)
	-- ,CONSTRAINT [wish_stk_FK] FOREIGN KEY ([stock_ID]) REFERENCES [dbo].[stock_List] ([stock_ID]) 
	-- ,CONSTRAINT [wish_cus_FK] FOREIGN KEY ([cus_no]) REFERENCES [dbo].[customers] ([cus_no]) 
);
go

--Login Check
CREATE PROCEDURE [dbo].chkLogin
	@cus_ID varchar(30),
	@cus_pwd varchar(MAX)
AS
	SELECT 1 from dbo.customers where cus_ID=@cus_ID and PWDCOMPARE(@cus_pwd,cus_pwd) = 1;
go

--중복되는 ID 검사
CREATE PROCEDURE [dbo].ChkOverLap
	@sellerId varchar(30)	
AS
	SELECT 1 from dbo.seller where seller_ID = @sellerId;
go

-- 회원가입(customer)
CREATE PROCEDURE [dbo].insert_cus
	@cus_ID varchar(30),
	@cus_pwd varchar(MAX),
	@cus_phone varchar(15),
	@cus_addr nvarchar(max),
	@cus_name nvarchar(30),
	@cus_Nickname nvarchar(40),
	@cus_gender bit,
	@cus_age int
AS
insert into dbo.customers(cus_ID,cus_pwd,cus_phone,cus_addr,cus_name,cus_Nickname,cus_gender,cus_age)
values(@cus_ID,pwdencrypt(@cus_pwd),@cus_phone,@cus_addr,@cus_name,@cus_Nickname,@cus_gender,@cus_age)
go;

-- 회원가입(판매자)
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
go;

-- 상품등록
CREATE PROCEDURE [dbo].insertProductsForTest
	@pro_Id varchar(20),
	@pro_Name nvarchar(50),
	@pro_Price int,
	@main_Image varchar(MAX),
	@cat_ID varchar(4),
	@seller_no int
AS
	insert into dbo.products(pro_ID, pro_name, pro_price, main_image, seller_no, cat_ID)
	values (@pro_Id, @pro_Name, @pro_Price, @main_Image, @seller_no, @cat_ID);
go

-- 상품 보기
CREATE PROCEDURE [dbo].ViewProducts
AS
	SELECT * from dbo.products where pro_state = 1;
go;

