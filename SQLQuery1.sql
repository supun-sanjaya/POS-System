
create database POS_SYSTEM;
use POS_SYSTEM;

create table products
(Barcode varchar(20) ,Product_Key varchar(20) primary key,Product_Description varchar(80),Category varchar(28),Stock_In_Date date,QTY int,Price decimal(10, 2),Pro_CostAmount decimal(10, 2),Total_CostAmount decimal(10, 2),GRN_NO VARCHAR(18));

ALTER TABLE products
ADD GRN_NO VARCHAR(18);

select*from products;
select*from sales;

create table addusers
(NIC_Number varchar(18) primary key,Name_ varchar(28),Address_ Varchar(28),Contact int,Position varchar(18));

select*from addusers;

ALTER TABLE addusers
ADD Username VARCHAR(18);

ALTER TABLE addusers
ADD Password VARCHAR(28);

CREATE TABLE Category (
    Category varchar(28) 
);
select * from cart;

create table cart
(Bill_NO varchar(28),Barcode varchar(20),Date date,Product_Description varchar(80),Price decimal(10, 2),QTY int,TotalAmount decimal(10, 2));

DROP TABLE cart;
delete from cart;

CREATE TABLE billno (
    exid int,val varchar(12) 
);
insert into billno values(1,'28');

select * from billno;
delete from billno;

create table sales
(Bill_NO varchar(28),Date date, Total_Qty int, Total_Bill decimal(10, 2),Discount decimal(10, 2),Discounted_Bill_Amount decimal(10, 2), Status varchar(28), Balance decimal(10, 2));

select * from sales;

delete from sales;

CREATE TABLE Photos
(
    Id INT PRIMARY KEY IDENTITY,
    PhotoData VARBINARY(MAX)
);
select * from Photos;

select * from SavedText;
delete SavedText;

CREATE TABLE SavedText (
    Id INT PRIMARY KEY ,
    Text NVARCHAR(MAX),addresstext NVARCHAR(MAX)
);
Drop table SavedText;

ALTER TABLE SavedText
ADD addresstext NVARCHAR(MAX);

INSERT INTO SavedText (Id , Text, addresstext)
VALUES ('1', 'Your Business Name', 'Your Address');


CREATE TABLE login_logs (
    id INT PRIMARY KEY IDENTITY,
    username NVARCHAR(255) NOT NULL,
    login_date DATE NOT NULL,
    login_time TIME NOT NULL,
    logout_date DATE,
    logout_time TIME
);
select * from login_logs;
delete from login_logs;


drop table temproducts;

SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'temproducts'

select * from temproducts;

delete from temproducts;

create table temproducts
(Barcodet varchar(20) ,Product_Keyt varchar(20) ,Product_Descriptiont varchar(80),Categoryt varchar(28),Stock_In_Datet date,QTYt int,Pricet decimal(10, 2),Pro_CostAmountt decimal(10, 2),Total_CostAmountt decimal(10, 2),GRN_No VARCHAR(18),Cus_Bill_No VARCHAR(18),Sold_Date date);

ALTER TABLE temproducts
ADD Cus_Bill_No VARCHAR(18);


ALTER TABLE temproducts
ADD GRN_NO_ VARCHAR(18);

ALTER TABLE returnproducts
ADD GRN_No VARCHAR(18);

SELECT * FROM schema_name.temproducts



INSERT INTO login_logs (username, login_date, login_time, logout_date, logout_time)
VALUES
    ('admin', '2024-04-17', '12:00:00', '2024-04-17', '18:00:00'),
    ('wanidu', '2024-05-16', '08:30:00', '2024-05-16', '17:45:00'),
    ('mendis', '2024-05-14', '10:15:00', '2024-05-14', '19:30:00');




	-- Create a SQL Server Agent Job to delete old data
USE msdb ;
GO

EXEC dbo.sp_add_job
    @job_name = N'CleanupJob' ;
GO

EXEC dbo.sp_add_jobstep
    @job_name = N'CleanupJob',
    @step_name = N'DeleteOldRecords',
    @subsystem = N'TSQL',
    @command = N'DELETE FROM login_logs WHERE login_date < DATEADD(MONTH, -12, GETDATE())',
    @on_success_action = 1 ;
GO

EXEC dbo.sp_add_schedule
    @schedule_name = N'CleanupSchedule',
    @freq_type = 4,
    @freq_interval = 1,
    @active_start_time = 000000 ;
GO

EXEC dbo.sp_attach_schedule
    @job_name = N'CleanupJob',
    @schedule_name = N'CleanupSchedule' ;
GO

EXEC dbo.sp_add_jobserver
    @job_name = N'CleanupJob' ;
GO

create table returnproducts
(Barcoder varchar(20) ,Product_Keyr varchar(20),Product_Descriptionr varchar(80),Categoryr varchar(28),Stock_In_Dater date,QTYr int,Pricer decimal(10, 2),Pro_CostAmountr decimal(10, 2),Total_CostAmountr decimal(10, 2));

delete from sales;
select * from temproducts;
select * from returnproducts;
select * from products;
select * from cart;
select * from sales;

drop table temproducts;

ALTER TABLE returnproducts
DROP COLUMN Cus_Bill_No;


ALTER TABLE returnproducts
ADD Cus_Bill_No VARCHAR(18);

ALTER TABLE returnproducts ADD ID INT IDENTITY(1,1) PRIMARY KEY;

ALTER TABLE temproducts
ADD Sold_Date date;

CREATE PROCEDURE DeleteOldSoldTemProducts
AS
BEGIN
    DELETE FROM temproducts WHERE DATEDIFF(day, Sold_Date, GETDATE()) >= 17;
END


