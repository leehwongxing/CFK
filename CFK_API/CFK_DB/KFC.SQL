/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     10/26/2018 7:08:16 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Addresses') and o.name = 'FK_Customer_Addresses_Dim_Customers')
alter table Dim_Addresses
   drop constraint FK_Customer_Addresses_Dim_Customers
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Products') and o.name = 'FK_Product_Category_Dim_Categories')
alter table Dim_Products
   drop constraint FK_Product_Category_Dim_Categories
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Tracking') and o.name = 'FK_Customer_Tracking_Dim_Stores')
alter table Dim_Tracking
   drop constraint FK_Customer_Tracking_Dim_Stores
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Tracking') and o.name = 'FK_Zone_Tracking_Dim_Zones')
alter table Dim_Tracking
   drop constraint FK_Zone_Tracking_Dim_Zones
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Order_Product') and o.name = 'FK_Order_Product_Dim_Customers')
alter table Order_Product
   drop constraint FK_Order_Product_Dim_Customers
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Order_Product') and o.name = 'FK_Order_Product2_Dim_Products')
alter table Order_Product
   drop constraint FK_Order_Product2_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Order_Product') and o.name = 'FK_Order_Product3_Dim_Orders')
alter table Order_Product
   drop constraint FK_Order_Product3_Dim_Orders
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Order_Status') and o.name = 'FK_Order_Status_Dim_Orders')
alter table Order_Status
   drop constraint FK_Order_Status_Dim_Orders
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Order_Status') and o.name = 'FK_Order_Status2_Dim_Status')
alter table Order_Status
   drop constraint FK_Order_Status2_Dim_Status
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product_Combo') and o.name = 'FK_Combo_ID_Dim_Products')
alter table Product_Combo
   drop constraint FK_Combo_ID_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product_Combo') and o.name = 'FK_Product_Combo_Dim_Products')
alter table Product_Combo
   drop constraint FK_Product_Combo_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product_Image') and o.name = 'FK_Product_Image_Dim_Products')
alter table Product_Image
   drop constraint FK_Product_Image_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product_Image') and o.name = 'FK_Product_Image2_Dim_Images')
alter table Product_Image
   drop constraint FK_Product_Image2_Dim_Images
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Promoted_Product') and o.name = 'FK_Promoted_Product_Dim_Promotions')
alter table Promoted_Product
   drop constraint FK_Promoted_Product_Dim_Promotions
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Promoted_Product') and o.name = 'FK_Promoted_Product2_Dim_Products')
alter table Promoted_Product
   drop constraint FK_Promoted_Product2_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Store_Zone') and o.name = 'FK_Store_Zone_Dim_Stores')
alter table Store_Zone
   drop constraint FK_Store_Zone_Dim_Stores
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Store_Zone') and o.name = 'FK_Store_Zone2_Dim_Zones')
alter table Store_Zone
   drop constraint FK_Store_Zone2_Dim_Zones
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('User_Role') and o.name = 'FK_User_Role_Dim_Users')
alter table User_Role
   drop constraint FK_User_Role_Dim_Users
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('User_Role') and o.name = 'FK_User_Role2_Dim_Roles')
alter table User_Role
   drop constraint FK_User_Role2_Dim_Roles
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Dim_Addresses')
            and   name  = 'CUSTOMERADDRESSES_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_Addresses.CUSTOMERADDRESSES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Addresses')
            and   type = 'U')
   drop table Dim_Addresses
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Categories')
            and   type = 'U')
   drop table Dim_Categories
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Customers')
            and   type = 'U')
   drop table Dim_Customers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Images')
            and   type = 'U')
   drop table Dim_Images
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Orders')
            and   type = 'U')
   drop table Dim_Orders
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Dim_Products')
            and   name  = 'PRODUCT_CATEGORY_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_Products.PRODUCT_CATEGORY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Products')
            and   type = 'U')
   drop table Dim_Products
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Promotions')
            and   type = 'U')
   drop table Dim_Promotions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Roles')
            and   type = 'U')
   drop table Dim_Roles
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Status')
            and   type = 'U')
   drop table Dim_Status
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Stores')
            and   type = 'U')
   drop table Dim_Stores
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Tokens')
            and   type = 'U')
   drop table Dim_Tokens
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Dim_Tracking')
            and   name  = 'ZONE_TRACKING_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_Tracking.ZONE_TRACKING_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Dim_Tracking')
            and   name  = 'CUSTOMER_TRACKING_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_Tracking.CUSTOMER_TRACKING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Tracking')
            and   type = 'U')
   drop table Dim_Tracking
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Users')
            and   type = 'U')
   drop table Dim_Users
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Zones')
            and   type = 'U')
   drop table Dim_Zones
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Order_Product')
            and   name  = 'ORDER_PRODUCT3_FK'
            and   indid > 0
            and   indid < 255)
   drop index Order_Product.ORDER_PRODUCT3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Order_Product')
            and   name  = 'ORDER_PRODUCT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Order_Product.ORDER_PRODUCT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Order_Product')
            and   name  = 'ORDER_PRODUCT_FK'
            and   indid > 0
            and   indid < 255)
   drop index Order_Product.ORDER_PRODUCT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Order_Product')
            and   type = 'U')
   drop table Order_Product
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Order_Status')
            and   name  = 'ORDER_STATUS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Order_Status.ORDER_STATUS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Order_Status')
            and   name  = 'ORDER_STATUS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Order_Status.ORDER_STATUS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Order_Status')
            and   type = 'U')
   drop table Order_Status
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product_Combo')
            and   name  = 'PRODUCT_COMBO_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product_Combo.PRODUCT_COMBO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product_Combo')
            and   name  = 'COMBO_ID_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product_Combo.COMBO_ID_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Product_Combo')
            and   type = 'U')
   drop table Product_Combo
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product_Image')
            and   name  = 'PRODUCT_IMAGE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product_Image.PRODUCT_IMAGE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product_Image')
            and   name  = 'PRODUCT_IMAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product_Image.PRODUCT_IMAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Product_Image')
            and   type = 'U')
   drop table Product_Image
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Promoted_Product')
            and   name  = 'PROMOTED_PRODUCT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Promoted_Product.PROMOTED_PRODUCT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Promoted_Product')
            and   name  = 'PROMOTED_PRODUCT_FK'
            and   indid > 0
            and   indid < 255)
   drop index Promoted_Product.PROMOTED_PRODUCT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Promoted_Product')
            and   type = 'U')
   drop table Promoted_Product
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Store_Zone')
            and   name  = 'STORE_ZONE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Store_Zone.STORE_ZONE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Store_Zone')
            and   name  = 'STORE_ZONE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Store_Zone.STORE_ZONE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Store_Zone')
            and   type = 'U')
   drop table Store_Zone
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('User_Role')
            and   name  = 'USER_ROLE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index User_Role.USER_ROLE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('User_Role')
            and   name  = 'USER_ROLE_FK'
            and   indid > 0
            and   indid < 255)
   drop index User_Role.USER_ROLE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Role')
            and   type = 'U')
   drop table User_Role
go

/*==============================================================*/
/* Table: Dim_Addresses                                         */
/*==============================================================*/
create table Dim_Addresses (
   Addr_ID              bigint               identity,
   Customer_ID          bigint               not null,
   FullName             nvarchar(256)        not null,
   Phone                nvarchar(16)         not null,
   StreetDetails        nvarchar(512)        not null,
   Ward                 nvarchar(64)         not null,
   District             nvarchar(64)         not null,
   Province             nvarchar(64)         not null,
   Priority             int                  not null default 1,
   CreatedAt            bigint               not null default -1,
   constraint PK_DIM_ADDRESSES primary key nonclustered (Addr_ID)
)
go

/*==============================================================*/
/* Index: CUSTOMERADDRESSES_FK                                  */
/*==============================================================*/
create index CUSTOMERADDRESSES_FK on Dim_Addresses (
Customer_ID ASC
)
go

/*==============================================================*/
/* Table: Dim_Categories                                        */
/*==============================================================*/
create table Dim_Categories (
   Cat_ID               int                  identity,
   CatName              nvarchar(256)        not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   constraint PK_DIM_CATEGORIES primary key nonclustered (Cat_ID),
   constraint AK_CATNAME_DIM_CATE unique (CatName)
)
go

/*==============================================================*/
/* Table: Dim_Customers                                         */
/*==============================================================*/
create table Dim_Customers (
   Customer_ID          bigint               identity,
   Username             nvarchar(32)         not null,
   FullName             nvarchar(256)        not null,
   Email                nvarchar(128)        not null,
   Password             nvarchar(128)        not null,
   Gender               smallint             not null,
   Birthday             nvarchar(16)         not null,
   Phone                nvarchar(16)         not null,
   VerifiedAt           bigint               not null default -1,
   IsLocked             bit                  not null,
   CreatedAt            bigint               not null default -1,
   Ref_Avatar           nvarchar(2048)       not null,
   Ref_Profile          nvarchar(2048)       not null,
   constraint PK_DIM_CUSTOMERS primary key nonclustered (Customer_ID),
   constraint AK_EMAIL_DIM_CUST unique (Email),
   constraint AK_USERNAME_DIM_CUST unique (Username)
)
go

/*==============================================================*/
/* Table: Dim_Images                                            */
/*==============================================================*/
create table Dim_Images (
   Image_ID             bigint               identity,
   FileSize             bigint               not null,
   MIME                 nvarchar(32)         not null,
   SavedAt              nvarchar(2048)       not null,
   MirroredAt           nvarchar(2048)       not null,
   Content              nvarchar(Max)        not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   Ref_Customer         bigint               not null default -1,
   constraint PK_DIM_IMAGES primary key nonclustered (Image_ID)
)
go

/*==============================================================*/
/* Table: Dim_Orders                                            */
/*==============================================================*/
create table Dim_Orders (
   Order_ID             bigint               identity,
   OrdererName          nvarchar(256)        not null,
   OrdererAddr          nvarchar(Max)        not null,
   ReceipentName        nvarchar(256)        not null,
   ReceipentAddr        nvarchar(Max)        not null,
   Total                double precision     not null,
   Note                 nvarchar(256)        not null,
   Discount             double precision     not null,
   DiscountNote         nvarchar(256)        not null,
   Ref_Customer         bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   Ref_Store            int                  not null default -1,
   CreatedAt            bigint               not null default -1,
   SentAt               bigint               not null default -1,
   constraint PK_DIM_ORDERS primary key nonclustered (Order_ID)
)
go

/*==============================================================*/
/* Table: Dim_Products                                          */
/*==============================================================*/
create table Dim_Products (
   Product_ID           int                  identity,
   Cat_ID               int                  not null,
   ProductName          nvarchar(256)        not null,
   BarNumber            nvarchar(32)         not null,
   ProductTag           nvarchar(8)          not null,
   BasePrice            double precision     not null,
   SalePrice            double precision     not null,
   VAT                  float                not null,
   Origin               nvarchar(128)        not null,
   Content              nvarchar(Max)        not null,
   Preview              nvarchar(256)        not null,
   Properties           nvarchar(Max)        not null,
   IsCombo              bit                  not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   constraint PK_DIM_PRODUCTS primary key nonclustered (Product_ID),
   constraint AK_PRODUCTNAME_DIM_PROD unique (Cat_ID, ProductName)
)
go

/*==============================================================*/
/* Index: PRODUCT_CATEGORY_FK                                   */
/*==============================================================*/
create index PRODUCT_CATEGORY_FK on Dim_Products (
Cat_ID ASC
)
go

/*==============================================================*/
/* Table: Dim_Promotions                                        */
/*==============================================================*/
create table Dim_Promotions (
   Promotion_ID         int                  identity,
   Title                nvarchar(128)        not null,
   Content              nvarchar(Max)        not null,
   StartTime            bigint               not null,
   EndTime              bigint               not null,
   Priority             int                  not null default 1,
   Enabled              bit                  not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   constraint PK_DIM_PROMOTIONS primary key nonclustered (Promotion_ID),
   constraint AK_PROMOID_DIM_PROM unique (Title, StartTime)
)
go

/*==============================================================*/
/* Table: Dim_Roles                                             */
/*==============================================================*/
create table Dim_Roles (
   Role_ID              nvarchar(16)         not null,
   RoleName             nvarchar(128)        not null,
   IsGlobal             bit                  not null,
   constraint PK_DIM_ROLES primary key nonclustered (Role_ID),
   constraint AK_ROLENAME_DIM_ROLE unique (RoleName)
)
go

/*==============================================================*/
/* Table: Dim_Status                                            */
/*==============================================================*/
create table Dim_Status (
   Status_ID            nvarchar(64)         not null,
   Prority              int                  not null,
   constraint PK_DIM_STATUS primary key nonclustered (Status_ID)
)
go

/*==============================================================*/
/* Table: Dim_Stores                                            */
/*==============================================================*/
create table Dim_Stores (
   Store_ID             int                  identity,
   StoreName            nvarchar(128)        not null,
   Address              nvarchar(512)        not null,
   Phone                nvarchar(16)         not null,
   Ward                 nvarchar(64)         not null,
   Province             nvarchar(64)         not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   Ref_Zones            nvarchar(Max)        not null,
   constraint PK_DIM_STORES primary key nonclustered (Store_ID),
   constraint AK_STORENAME_DIM_STOR unique (StoreName, Province)
)
go

/*==============================================================*/
/* Table: Dim_Tokens                                            */
/*==============================================================*/
create table Dim_Tokens (
   Token_ID             bigint               identity,
   Revoke_ID            nvarchar(32)         not null,
   Content              nvarchar(Max)        not null,
   Origin               nvarchar(128)        not null,
   CreatedAt            bigint               not null default -1,
   ValidUntil           bigint               not null,
   IsCustomer           bit                  not null,
   Ref_Creator          bigint               not null,
   constraint PK_DIM_TOKENS primary key nonclustered (Token_ID),
   constraint AK_REVOKETOKEN_DIM_TOKE unique (Revoke_ID)
)
go

/*==============================================================*/
/* Table: Dim_Tracking                                          */
/*==============================================================*/
create table Dim_Tracking (
   Tracking_ID          bigint               identity,
   Zone_ID              int                  not null,
   Store_ID             int                  not null,
   Description          nvarchar(256)        not null,
   EnterAt              bigint               not null,
   ServicedAt           bigint               not null,
   LeaveAt              bigint               not null,
   _Men                 int                  not null,
   _Women               int                  not null,
   _Children            int                  not null,
   _Elder               int                  not null,
   _Zone                int                  not null,
   _Day                 smallint             not null,
   _Month               smallint             not null,
   _Year                smallint             not null,
   Ref_Order            bigint               not null,
   Ref_User             bigint               not null default -1,
   Ref_Events           nvarchar(Max)        not null,
   constraint PK_DIM_TRACKING primary key nonclustered (Tracking_ID)
)
go

/*==============================================================*/
/* Index: CUSTOMER_TRACKING_FK                                  */
/*==============================================================*/
create index CUSTOMER_TRACKING_FK on Dim_Tracking (
Store_ID ASC
)
go

/*==============================================================*/
/* Index: ZONE_TRACKING_FK                                      */
/*==============================================================*/
create index ZONE_TRACKING_FK on Dim_Tracking (
Zone_ID ASC
)
go

/*==============================================================*/
/* Table: Dim_Users                                             */
/*==============================================================*/
create table Dim_Users (
   User_ID              bigint               identity,
   Username             nvarchar(32)         not null,
   FullName             nvarchar(256)        not null,
   Email                nvarchar(128)        not null,
   Password             nvarchar(128)        not null,
   VerifiedAt           bigint               not null default -1,
   IsLocked             bit                  not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   constraint PK_DIM_USERS primary key nonclustered (User_ID),
   constraint AK_USERNAME_DIM_USER unique (Username),
   constraint AK_EMAIL_DIM_USER unique (Email)
)
go

/*==============================================================*/
/* Table: Dim_Zones                                             */
/*==============================================================*/
create table Dim_Zones (
   Zone_ID              int                  identity,
   ZoneName             nvarchar(256)        not null,
   constraint PK_DIM_ZONES primary key nonclustered (Zone_ID),
   constraint AK_ZONENAME_DIM_ZONE unique (ZoneName)
)
go

/*==============================================================*/
/* Table: Order_Product                                         */
/*==============================================================*/
create table Order_Product (
   Customer_ID          bigint               not null,
   Product_ID           int                  not null,
   Order_ID             bigint               not null,
   SalePrice            double precision     not null,
   Quantity             int                  not null,
   constraint PK_ORDER_PRODUCT primary key (Customer_ID, Product_ID, Order_ID)
)
go

/*==============================================================*/
/* Index: ORDER_PRODUCT_FK                                      */
/*==============================================================*/
create index ORDER_PRODUCT_FK on Order_Product (
Customer_ID ASC
)
go

/*==============================================================*/
/* Index: ORDER_PRODUCT2_FK                                     */
/*==============================================================*/
create index ORDER_PRODUCT2_FK on Order_Product (
Product_ID ASC
)
go

/*==============================================================*/
/* Index: ORDER_PRODUCT3_FK                                     */
/*==============================================================*/
create index ORDER_PRODUCT3_FK on Order_Product (
Order_ID ASC
)
go

/*==============================================================*/
/* Table: Order_Status                                          */
/*==============================================================*/
create table Order_Status (
   Order_ID             bigint               not null,
   Status_ID            nvarchar(64)         not null,
   Note                 nvarchar(256)        not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   constraint PK_ORDER_STATUS primary key (Order_ID, Status_ID)
)
go

/*==============================================================*/
/* Index: ORDER_STATUS_FK                                       */
/*==============================================================*/
create index ORDER_STATUS_FK on Order_Status (
Order_ID ASC
)
go

/*==============================================================*/
/* Index: ORDER_STATUS2_FK                                      */
/*==============================================================*/
create index ORDER_STATUS2_FK on Order_Status (
Status_ID ASC
)
go

/*==============================================================*/
/* Table: Product_Combo                                         */
/*==============================================================*/
create table Product_Combo (
   Combo_ID             int                  not null,
   Product_ID           int                  not null,
   BasePrice            double precision     not null,
   SalePrice            double precision     not null,
   Quantity             int                  not null,
   CreatedAt            bigint               not null default -1,
   constraint PK_PRODUCT_COMBO primary key (Combo_ID, Product_ID)
)
go

/*==============================================================*/
/* Index: COMBO_ID_FK                                           */
/*==============================================================*/
create index COMBO_ID_FK on Product_Combo (
Combo_ID ASC
)
go

/*==============================================================*/
/* Index: PRODUCT_COMBO_FK                                      */
/*==============================================================*/
create index PRODUCT_COMBO_FK on Product_Combo (
Product_ID ASC
)
go

/*==============================================================*/
/* Table: Product_Image                                         */
/*==============================================================*/
create table Product_Image (
   Product_ID           int                  not null,
   Image_ID             bigint               not null,
   CreatedAt            bigint               not null default -1,
   constraint PK_PRODUCT_IMAGE primary key (Product_ID, Image_ID)
)
go

/*==============================================================*/
/* Index: PRODUCT_IMAGE_FK                                      */
/*==============================================================*/
create index PRODUCT_IMAGE_FK on Product_Image (
Product_ID ASC
)
go

/*==============================================================*/
/* Index: PRODUCT_IMAGE2_FK                                     */
/*==============================================================*/
create index PRODUCT_IMAGE2_FK on Product_Image (
Image_ID ASC
)
go

/*==============================================================*/
/* Table: Promoted_Product                                      */
/*==============================================================*/
create table Promoted_Product (
   Promotion_ID         int                  not null,
   Product_ID           int                  not null,
   SalePrice            double precision     not null,
   LimitPerCustomer     int                  not null,
   LimitPerDay          int                  not null,
   Quantity             int                  not null,
   constraint PK_PROMOTED_PRODUCT primary key (Promotion_ID, Product_ID)
)
go

/*==============================================================*/
/* Index: PROMOTED_PRODUCT_FK                                   */
/*==============================================================*/
create index PROMOTED_PRODUCT_FK on Promoted_Product (
Promotion_ID ASC
)
go

/*==============================================================*/
/* Index: PROMOTED_PRODUCT2_FK                                  */
/*==============================================================*/
create index PROMOTED_PRODUCT2_FK on Promoted_Product (
Product_ID ASC
)
go

/*==============================================================*/
/* Table: Store_Zone                                            */
/*==============================================================*/
create table Store_Zone (
   Store_ID             int                  not null,
   Zone_ID              int                  not null,
   CreatedAt            bigint               not null default -1,
   Ref_User             bigint               not null default -1,
   constraint PK_STORE_ZONE primary key (Store_ID, Zone_ID)
)
go

/*==============================================================*/
/* Index: STORE_ZONE_FK                                         */
/*==============================================================*/
create index STORE_ZONE_FK on Store_Zone (
Store_ID ASC
)
go

/*==============================================================*/
/* Index: STORE_ZONE2_FK                                        */
/*==============================================================*/
create index STORE_ZONE2_FK on Store_Zone (
Zone_ID ASC
)
go

/*==============================================================*/
/* Table: User_Role                                             */
/*==============================================================*/
create table User_Role (
   User_ID              bigint               not null,
   Role_ID              nvarchar(16)         not null,
   CreatedAt            bigint               not null default -1,
   Ref_Store            int                  not null default -1,
   constraint PK_USER_ROLE primary key (User_ID, Role_ID)
)
go

/*==============================================================*/
/* Index: USER_ROLE_FK                                          */
/*==============================================================*/
create index USER_ROLE_FK on User_Role (
User_ID ASC
)
go

/*==============================================================*/
/* Index: USER_ROLE2_FK                                         */
/*==============================================================*/
create index USER_ROLE2_FK on User_Role (
Role_ID ASC
)
go

alter table Dim_Addresses
   add constraint FK_Customer_Addresses_Dim_Customers foreign key (Customer_ID)
      references Dim_Customers (Customer_ID)
go

alter table Dim_Products
   add constraint FK_Product_Category_Dim_Categories foreign key (Cat_ID)
      references Dim_Categories (Cat_ID)
go

alter table Dim_Tracking
   add constraint FK_Customer_Tracking_Dim_Stores foreign key (Store_ID)
      references Dim_Stores (Store_ID)
go

alter table Dim_Tracking
   add constraint FK_Zone_Tracking_Dim_Zones foreign key (Zone_ID)
      references Dim_Zones (Zone_ID)
go

alter table Order_Product
   add constraint FK_Order_Product_Dim_Customers foreign key (Customer_ID)
      references Dim_Customers (Customer_ID)
go

alter table Order_Product
   add constraint FK_Order_Product2_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table Order_Product
   add constraint FK_Order_Product3_Dim_Orders foreign key (Order_ID)
      references Dim_Orders (Order_ID)
go

alter table Order_Status
   add constraint FK_Order_Status_Dim_Orders foreign key (Order_ID)
      references Dim_Orders (Order_ID)
go

alter table Order_Status
   add constraint FK_Order_Status2_Dim_Status foreign key (Status_ID)
      references Dim_Status (Status_ID)
go

alter table Product_Combo
   add constraint FK_Combo_ID_Dim_Products foreign key (Combo_ID)
      references Dim_Products (Product_ID)
go

alter table Product_Combo
   add constraint FK_Product_Combo_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table Product_Image
   add constraint FK_Product_Image_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table Product_Image
   add constraint FK_Product_Image2_Dim_Images foreign key (Image_ID)
      references Dim_Images (Image_ID)
go

alter table Promoted_Product
   add constraint FK_Promoted_Product_Dim_Promotions foreign key (Promotion_ID)
      references Dim_Promotions (Promotion_ID)
go

alter table Promoted_Product
   add constraint FK_Promoted_Product2_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table Store_Zone
   add constraint FK_Store_Zone_Dim_Stores foreign key (Store_ID)
      references Dim_Stores (Store_ID)
go

alter table Store_Zone
   add constraint FK_Store_Zone2_Dim_Zones foreign key (Zone_ID)
      references Dim_Zones (Zone_ID)
go

alter table User_Role
   add constraint FK_User_Role_Dim_Users foreign key (User_ID)
      references Dim_Users (User_ID)
go

alter table User_Role
   add constraint FK_User_Role2_Dim_Roles foreign key (Role_ID)
      references Dim_Roles (Role_ID)
go

