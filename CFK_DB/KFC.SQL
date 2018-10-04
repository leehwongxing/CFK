/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     10/4/2018 10:56:28 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ComboDetails') and o.name = 'FK_ComboDetails_Dim_Products')
alter table ComboDetails
   drop constraint FK_ComboDetails_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ComboDetails') and o.name = 'FK_Combo_ID_Dim_Products')
alter table ComboDetails
   drop constraint FK_Combo_ID_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Addresses') and o.name = 'FK_CustomerAddresses_Dim_Customers')
alter table Dim_Addresses
   drop constraint FK_CustomerAddresses_Dim_Customers
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_CustomerTracking') and o.name = 'FK_OrderTracking_Dim_Stores')
alter table Dim_CustomerTracking
   drop constraint FK_OrderTracking_Dim_Stores
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_CustomerTracking') and o.name = 'FK_ZoneTracking_Dim_StoreZones')
alter table Dim_CustomerTracking
   drop constraint FK_ZoneTracking_Dim_StoreZones
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Products') and o.name = 'FK_Product_Category_Dim_Categories')
alter table Dim_Products
   drop constraint FK_Product_Category_Dim_Categories
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Sessions') and o.name = 'FK_CustomerSessions_Dim_Customers')
alter table Dim_Sessions
   drop constraint FK_CustomerSessions_Dim_Customers
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dim_Tokens') and o.name = 'FK_UserTokens_Dim_Users')
alter table Dim_Tokens
   drop constraint FK_UserTokens_Dim_Users
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OrderStatus') and o.name = 'FK_OrderStatus_Dim_Orders')
alter table OrderStatus
   drop constraint FK_OrderStatus_Dim_Orders
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OrderStatus') and o.name = 'FK_OrderStatus2_Dim_Status')
alter table OrderStatus
   drop constraint FK_OrderStatus2_Dim_Status
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OrderedProducts') and o.name = 'FK_OrderedProducts_Dim_Customers')
alter table OrderedProducts
   drop constraint FK_OrderedProducts_Dim_Customers
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OrderedProducts') and o.name = 'FK_OrderedProducts2_Dim_Products')
alter table OrderedProducts
   drop constraint FK_OrderedProducts2_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OrderedProducts') and o.name = 'FK_OrderedProducts3_Dim_Orders')
alter table OrderedProducts
   drop constraint FK_OrderedProducts3_Dim_Orders
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product_Images') and o.name = 'FK_Product_Images_Dim_Products')
alter table Product_Images
   drop constraint FK_Product_Images_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product_Images') and o.name = 'FK_Product_Images2_Dim_Images')
alter table Product_Images
   drop constraint FK_Product_Images2_Dim_Images
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Promoted_Products') and o.name = 'FK_Promoted_Products_Dim_Promotions')
alter table Promoted_Products
   drop constraint FK_Promoted_Products_Dim_Promotions
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Promoted_Products') and o.name = 'FK_Promoted_Products2_Dim_Products')
alter table Promoted_Products
   drop constraint FK_Promoted_Products2_Dim_Products
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StoreZones') and o.name = 'FK_StoreZones_Dim_Stores')
alter table StoreZones
   drop constraint FK_StoreZones_Dim_Stores
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StoreZones') and o.name = 'FK_StoreZones2_Dim_StoreZones')
alter table StoreZones
   drop constraint FK_StoreZones2_Dim_StoreZones
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UserRoles') and o.name = 'FK_UserRoles_Dim_Users')
alter table UserRoles
   drop constraint FK_UserRoles_Dim_Users
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UserRoles') and o.name = 'FK_UserRoles2_Dim_Roles')
alter table UserRoles
   drop constraint FK_UserRoles2_Dim_Roles
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ComboDetails')
            and   name  = 'COMBODETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ComboDetails.COMBODETAILS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ComboDetails')
            and   name  = 'COMBO_ID_FK'
            and   indid > 0
            and   indid < 255)
   drop index ComboDetails.COMBO_ID_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ComboDetails')
            and   type = 'U')
   drop table ComboDetails
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
            from  sysindexes
           where  id    = object_id('Dim_CustomerTracking')
            and   name  = 'ZONETRACKING_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_CustomerTracking.ZONETRACKING_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Dim_CustomerTracking')
            and   name  = 'ORDERTRACKING_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_CustomerTracking.ORDERTRACKING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_CustomerTracking')
            and   type = 'U')
   drop table Dim_CustomerTracking
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
            from  sysindexes
           where  id    = object_id('Dim_Sessions')
            and   name  = 'CUSTOMERSESSIONS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_Sessions.CUSTOMERSESSIONS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Sessions')
            and   type = 'U')
   drop table Dim_Sessions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Status')
            and   type = 'U')
   drop table Dim_Status
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_StoreZones')
            and   type = 'U')
   drop table Dim_StoreZones
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Stores')
            and   type = 'U')
   drop table Dim_Stores
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Dim_Tokens')
            and   name  = 'USERTOKENS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Dim_Tokens.USERTOKENS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Tokens')
            and   type = 'U')
   drop table Dim_Tokens
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dim_Users')
            and   type = 'U')
   drop table Dim_Users
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OrderStatus')
            and   name  = 'ORDERSTATUS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index OrderStatus.ORDERSTATUS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OrderStatus')
            and   name  = 'ORDERSTATUS_FK'
            and   indid > 0
            and   indid < 255)
   drop index OrderStatus.ORDERSTATUS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OrderStatus')
            and   type = 'U')
   drop table OrderStatus
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OrderedProducts')
            and   name  = 'ORDEREDPRODUCTS3_FK'
            and   indid > 0
            and   indid < 255)
   drop index OrderedProducts.ORDEREDPRODUCTS3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OrderedProducts')
            and   name  = 'ORDEREDPRODUCTS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index OrderedProducts.ORDEREDPRODUCTS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OrderedProducts')
            and   name  = 'ORDEREDPRODUCTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index OrderedProducts.ORDEREDPRODUCTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OrderedProducts')
            and   type = 'U')
   drop table OrderedProducts
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product_Images')
            and   name  = 'PRODUCT_IMAGES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product_Images.PRODUCT_IMAGES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product_Images')
            and   name  = 'PRODUCT_IMAGES_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product_Images.PRODUCT_IMAGES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Product_Images')
            and   type = 'U')
   drop table Product_Images
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Promoted_Products')
            and   name  = 'PROMOTED_PRODUCTS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Promoted_Products.PROMOTED_PRODUCTS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Promoted_Products')
            and   name  = 'PROMOTED_PRODUCTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Promoted_Products.PROMOTED_PRODUCTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Promoted_Products')
            and   type = 'U')
   drop table Promoted_Products
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StoreZones')
            and   name  = 'STOREZONES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index StoreZones.STOREZONES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StoreZones')
            and   name  = 'STOREZONES_FK'
            and   indid > 0
            and   indid < 255)
   drop index StoreZones.STOREZONES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StoreZones')
            and   type = 'U')
   drop table StoreZones
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UserRoles')
            and   name  = 'USERROLES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index UserRoles.USERROLES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UserRoles')
            and   name  = 'USERROLES_FK'
            and   indid > 0
            and   indid < 255)
   drop index UserRoles.USERROLES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UserRoles')
            and   type = 'U')
   drop table UserRoles
go

/*==============================================================*/
/* Table: ComboDetails                                          */
/*==============================================================*/
create table ComboDetails (
   Combo_ID             int                  not null,
   Product_ID           int                  not null,
   BasePrice            double precision     not null,
   Quantity             int                  not null,
   CreatedAt            bigint               not null,
   constraint PK_COMBODETAILS primary key (Combo_ID, Product_ID)
)
go

/*==============================================================*/
/* Index: COMBO_ID_FK                                           */
/*==============================================================*/
create index COMBO_ID_FK on ComboDetails (
Combo_ID ASC
)
go

/*==============================================================*/
/* Index: COMBODETAILS_FK                                       */
/*==============================================================*/
create index COMBODETAILS_FK on ComboDetails (
Product_ID ASC
)
go

/*==============================================================*/
/* Table: Dim_Addresses                                         */
/*==============================================================*/
create table Dim_Addresses (
   Addr_ID              bigint               identity,
   Customer_ID          bigint               not null,
   FullName             nvarchar(256)        not null,
   Phone                nvarchar(16)         not null,
   Detail               nvarchar(512)        not null,
   Ward                 nvarchar(64)         not null,
   District             nvarchar(64)         not null,
   Province             nvarchar(64)         not null,
   Priority             int                  not null,
   CreatedAt            bigint               not null,
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
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   constraint PK_DIM_CATEGORIES primary key nonclustered (Cat_ID),
   constraint AK_UCATEGORY_DIM_CATE unique (CatName)
)
go

/*==============================================================*/
/* Table: Dim_CustomerTracking                                  */
/*==============================================================*/
create table Dim_CustomerTracking (
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
   Ref_User             bigint               not null,
   constraint PK_DIM_CUSTOMERTRACKING primary key nonclustered (Tracking_ID)
)
go

/*==============================================================*/
/* Index: ORDERTRACKING_FK                                      */
/*==============================================================*/
create index ORDERTRACKING_FK on Dim_CustomerTracking (
Store_ID ASC
)
go

/*==============================================================*/
/* Index: ZONETRACKING_FK                                       */
/*==============================================================*/
create index ZONETRACKING_FK on Dim_CustomerTracking (
Zone_ID ASC
)
go

/*==============================================================*/
/* Table: Dim_Customers                                         */
/*==============================================================*/
create table Dim_Customers (
   Customer_ID          bigint               identity,
   Username             nvarchar(32)         not null,
   Email                nvarchar(128)        not null,
   Password             nvarchar(128)        not null,
   FullName             nvarchar(256)        not null,
   Gender               smallint             not null,
   Birthday             nvarchar(16)         not null,
   Phone                nvarchar(16)         not null,
   VerifiedAt           bigint               not null,
   CreatedAt            bigint               not null,
   Ref_Avatar           bigint               not null,
   Ref_Profile          bigint               not null,
   IsLocked             bit                  not null,
   constraint PK_DIM_CUSTOMERS primary key nonclustered (Customer_ID),
   constraint AK_UUSERNAME_DIM_CUST unique (Username),
   constraint AK_UEMAIL_DIM_CUST unique (Email)
)
go

/*==============================================================*/
/* Table: Dim_Images                                            */
/*==============================================================*/
create table Dim_Images (
   Image_ID             bigint               identity,
   Size                 bigint               not null,
   MIME                 nvarchar(32)         not null,
   SavedAt              nvarchar(2048)       not null,
   MirroredAt           nvarchar(2048)       not null,
   Content              nvarchar(Max)        not null,
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   Ref_Customer         bigint               not null,
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
   Note                 nvarchar(256)        not null,
   Discount             double precision     not null,
   DiscountNote         nvarchar(256)        not null,
   Ref_Customer         bigint               not null,
   Ref_User             bigint               not null,
   CreatedAt            bigint               not null,
   SentAt               bigint               not null,
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
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   constraint PK_DIM_PRODUCTS primary key nonclustered (Product_ID),
   constraint AK_UPRODUCT_DIM_PROD unique (ProductName)
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
   Priority             int                  not null,
   Enabled              bit                  not null,
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   constraint PK_DIM_PROMOTIONS primary key nonclustered (Promotion_ID),
   constraint AK_UPROMOTION_DIM_PROM unique (Title, StartTime)
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
   constraint AK_UROLE_DIM_ROLE unique (RoleName)
)
go

/*==============================================================*/
/* Table: Dim_Sessions                                          */
/*==============================================================*/
create table Dim_Sessions (
   Session_ID           bigint               identity,
   Customer_ID          bigint               not null,
   Content              nvarchar(Max)        not null,
   CreatedAt            bigint               not null,
   ValidUntil           bigint               not null,
   constraint PK_DIM_SESSIONS primary key nonclustered (Session_ID)
)
go

/*==============================================================*/
/* Index: CUSTOMERSESSIONS_FK                                   */
/*==============================================================*/
create index CUSTOMERSESSIONS_FK on Dim_Sessions (
Customer_ID ASC
)
go

/*==============================================================*/
/* Table: Dim_Status                                            */
/*==============================================================*/
create table Dim_Status (
   Status               nvarchar(64)         not null,
   Prority              int                  not null,
   constraint PK_DIM_STATUS primary key nonclustered (Status)
)
go

/*==============================================================*/
/* Table: Dim_StoreZones                                        */
/*==============================================================*/
create table Dim_StoreZones (
   Zone_ID              int                  identity,
   ZoneName             nvarchar(256)        not null,
   constraint PK_DIM_STOREZONES primary key nonclustered (Zone_ID),
   constraint AK_UZONE_DIM_STOR unique (ZoneName)
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
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   constraint PK_DIM_STORES primary key nonclustered (Store_ID),
   constraint AK_USTORE_DIM_STOR unique (StoreName)
)
go

/*==============================================================*/
/* Table: Dim_Tokens                                            */
/*==============================================================*/
create table Dim_Tokens (
   Token_ID             bigint               identity,
   User_ID              int                  not null,
   Content              nvarchar(Max)        not null,
   Origin               nvarchar(128)        not null,
   CreatedAt            bigint               not null,
   constraint PK_DIM_TOKENS primary key nonclustered (Token_ID)
)
go

/*==============================================================*/
/* Index: USERTOKENS_FK                                         */
/*==============================================================*/
create index USERTOKENS_FK on Dim_Tokens (
User_ID ASC
)
go

/*==============================================================*/
/* Table: Dim_Users                                             */
/*==============================================================*/
create table Dim_Users (
   User_ID              int                  identity,
   Username             nvarchar(32)         not null,
   FullName             nvarchar(256)        not null,
   Email                nvarchar(128)        not null,
   Password             nvarchar(128)        not null,
   VerifiedAt           bigint               not null,
   IsLocked             bit                  not null,
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   constraint PK_DIM_USERS primary key nonclustered (User_ID),
   constraint AK_UUSERNAME_DIM_USER unique (Username),
   constraint AK_UEMAIL_DIM_USER unique (Email)
)
go

/*==============================================================*/
/* Table: OrderStatus                                           */
/*==============================================================*/
create table OrderStatus (
   Order_ID             bigint               not null,
   Status               nvarchar(64)         not null,
   Note                 nvarchar(256)        not null,
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   constraint PK_ORDERSTATUS primary key (Order_ID, Status)
)
go

/*==============================================================*/
/* Index: ORDERSTATUS_FK                                        */
/*==============================================================*/
create index ORDERSTATUS_FK on OrderStatus (
Order_ID ASC
)
go

/*==============================================================*/
/* Index: ORDERSTATUS2_FK                                       */
/*==============================================================*/
create index ORDERSTATUS2_FK on OrderStatus (
Status ASC
)
go

/*==============================================================*/
/* Table: OrderedProducts                                       */
/*==============================================================*/
create table OrderedProducts (
   Customer_ID          bigint               not null,
   Product_ID           int                  not null,
   Order_ID             bigint               not null,
   SalePrice            double precision     not null,
   Quantity             int                  not null,
   constraint PK_ORDEREDPRODUCTS primary key (Customer_ID, Product_ID, Order_ID)
)
go

/*==============================================================*/
/* Index: ORDEREDPRODUCTS_FK                                    */
/*==============================================================*/
create index ORDEREDPRODUCTS_FK on OrderedProducts (
Customer_ID ASC
)
go

/*==============================================================*/
/* Index: ORDEREDPRODUCTS2_FK                                   */
/*==============================================================*/
create index ORDEREDPRODUCTS2_FK on OrderedProducts (
Product_ID ASC
)
go

/*==============================================================*/
/* Index: ORDEREDPRODUCTS3_FK                                   */
/*==============================================================*/
create index ORDEREDPRODUCTS3_FK on OrderedProducts (
Order_ID ASC
)
go

/*==============================================================*/
/* Table: Product_Images                                        */
/*==============================================================*/
create table Product_Images (
   Product_ID           int                  not null,
   Image_ID             bigint               not null,
   CreatedAt            bigint               not null,
   constraint PK_PRODUCT_IMAGES primary key (Product_ID, Image_ID)
)
go

/*==============================================================*/
/* Index: PRODUCT_IMAGES_FK                                     */
/*==============================================================*/
create index PRODUCT_IMAGES_FK on Product_Images (
Product_ID ASC
)
go

/*==============================================================*/
/* Index: PRODUCT_IMAGES2_FK                                    */
/*==============================================================*/
create index PRODUCT_IMAGES2_FK on Product_Images (
Image_ID ASC
)
go

/*==============================================================*/
/* Table: Promoted_Products                                     */
/*==============================================================*/
create table Promoted_Products (
   Promotion_ID         int                  not null,
   Product_ID           int                  not null,
   SalePrice            double precision     not null,
   LimitPerCustomer     int                  not null,
   LimitPerDay          int                  not null,
   Quantity             int                  not null,
   constraint PK_PROMOTED_PRODUCTS primary key (Promotion_ID, Product_ID)
)
go

/*==============================================================*/
/* Index: PROMOTED_PRODUCTS_FK                                  */
/*==============================================================*/
create index PROMOTED_PRODUCTS_FK on Promoted_Products (
Promotion_ID ASC
)
go

/*==============================================================*/
/* Index: PROMOTED_PRODUCTS2_FK                                 */
/*==============================================================*/
create index PROMOTED_PRODUCTS2_FK on Promoted_Products (
Product_ID ASC
)
go

/*==============================================================*/
/* Table: StoreZones                                            */
/*==============================================================*/
create table StoreZones (
   Store_ID             int                  not null,
   Zone_ID              int                  not null,
   CreatedAt            bigint               not null,
   Ref_User             bigint               not null,
   constraint PK_STOREZONES primary key (Store_ID, Zone_ID)
)
go

/*==============================================================*/
/* Index: STOREZONES_FK                                         */
/*==============================================================*/
create index STOREZONES_FK on StoreZones (
Store_ID ASC
)
go

/*==============================================================*/
/* Index: STOREZONES2_FK                                        */
/*==============================================================*/
create index STOREZONES2_FK on StoreZones (
Zone_ID ASC
)
go

/*==============================================================*/
/* Table: UserRoles                                             */
/*==============================================================*/
create table UserRoles (
   User_ID              int                  not null,
   Role_ID              nvarchar(16)         not null,
   CreatedAt            bigint               not null,
   Ref_Store            int                  not null,
   constraint PK_USERROLES primary key (User_ID, Role_ID)
)
go

/*==============================================================*/
/* Index: USERROLES_FK                                          */
/*==============================================================*/
create index USERROLES_FK on UserRoles (
User_ID ASC
)
go

/*==============================================================*/
/* Index: USERROLES2_FK                                         */
/*==============================================================*/
create index USERROLES2_FK on UserRoles (
Role_ID ASC
)
go

alter table ComboDetails
   add constraint FK_ComboDetails_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table ComboDetails
   add constraint FK_Combo_ID_Dim_Products foreign key (Combo_ID)
      references Dim_Products (Product_ID)
go

alter table Dim_Addresses
   add constraint FK_CustomerAddresses_Dim_Customers foreign key (Customer_ID)
      references Dim_Customers (Customer_ID)
go

alter table Dim_CustomerTracking
   add constraint FK_OrderTracking_Dim_Stores foreign key (Store_ID)
      references Dim_Stores (Store_ID)
go

alter table Dim_CustomerTracking
   add constraint FK_ZoneTracking_Dim_StoreZones foreign key (Zone_ID)
      references Dim_StoreZones (Zone_ID)
go

alter table Dim_Products
   add constraint FK_Product_Category_Dim_Categories foreign key (Cat_ID)
      references Dim_Categories (Cat_ID)
go

alter table Dim_Sessions
   add constraint FK_CustomerSessions_Dim_Customers foreign key (Customer_ID)
      references Dim_Customers (Customer_ID)
go

alter table Dim_Tokens
   add constraint FK_UserTokens_Dim_Users foreign key (User_ID)
      references Dim_Users (User_ID)
go

alter table OrderStatus
   add constraint FK_OrderStatus_Dim_Orders foreign key (Order_ID)
      references Dim_Orders (Order_ID)
go

alter table OrderStatus
   add constraint FK_OrderStatus2_Dim_Status foreign key (Status)
      references Dim_Status (Status)
go

alter table OrderedProducts
   add constraint FK_OrderedProducts_Dim_Customers foreign key (Customer_ID)
      references Dim_Customers (Customer_ID)
go

alter table OrderedProducts
   add constraint FK_OrderedProducts2_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table OrderedProducts
   add constraint FK_OrderedProducts3_Dim_Orders foreign key (Order_ID)
      references Dim_Orders (Order_ID)
go

alter table Product_Images
   add constraint FK_Product_Images_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table Product_Images
   add constraint FK_Product_Images2_Dim_Images foreign key (Image_ID)
      references Dim_Images (Image_ID)
go

alter table Promoted_Products
   add constraint FK_Promoted_Products_Dim_Promotions foreign key (Promotion_ID)
      references Dim_Promotions (Promotion_ID)
go

alter table Promoted_Products
   add constraint FK_Promoted_Products2_Dim_Products foreign key (Product_ID)
      references Dim_Products (Product_ID)
go

alter table StoreZones
   add constraint FK_StoreZones_Dim_Stores foreign key (Store_ID)
      references Dim_Stores (Store_ID)
go

alter table StoreZones
   add constraint FK_StoreZones2_Dim_StoreZones foreign key (Zone_ID)
      references Dim_StoreZones (Zone_ID)
go

alter table UserRoles
   add constraint FK_UserRoles_Dim_Users foreign key (User_ID)
      references Dim_Users (User_ID)
go

alter table UserRoles
   add constraint FK_UserRoles2_Dim_Roles foreign key (Role_ID)
      references Dim_Roles (Role_ID)
go

