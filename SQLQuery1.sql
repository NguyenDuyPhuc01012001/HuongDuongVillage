SET DATEFORMAT DMY;
CREATE TABLE Staff
  (
     id			 INT IDENTITY PRIMARY KEY,
     staffName	 NVARCHAR(50) NOT NULL,
     staffMail	 VARCHAR(40) UNIQUE NOT NULL,
     staffDOB	 SMALLDATETIME DEFAULT('21/05/2001'),
     staffGender BIT DEFAULT('1'), --1 is Male, 0 is Female
     staffRole	 VARCHAR(30) DEFAULT('CEO'),
	 isDelete	 BIT DEFAULT('0'),
  )
GO
CREATE TABLE Account
  (
     id		  INT IDENTITY PRIMARY KEY,
     staffID  INT FOREIGN KEY (staffID) REFERENCES dbo.Staff (id),
     userName VARCHAR(100) UNIQUE,
     userPass VARCHAR(100) NOT NULL,	 
  )
GO
CREATE TABLE Report
  (
     id		  INT IDENTITY PRIMARY KEY,
     message  NVARCHAR(100),
	 staffID  INT FOREIGN KEY (staffID) REFERENCES dbo.Staff (id),
     document TEXT,	 
  )
GO
CREATE TABLE Customer
  (
     id		   INT IDENTITY PRIMARY KEY,
     cusName   NVARCHAR(30) NOT NULL,
     cusIDcard VARCHAR(12) NOT NULL UNIQUE,
     cusPhone  VARCHAR(10),
     cusEmail  VARCHAR(100),
	 dateCheckIn smalldatetime,
	 isDelete	 BIT DEFAULT('0'),
  )
GO
CREATE TABLE RoomType
  (
     id			 INT IDENTITY PRIMARY KEY,
     roomType    VARCHAR(30),
     roomPrice   FLOAT,
	 isDelete	 BIT DEFAULT('0'),
  )
GO
CREATE TABLE Room
  (
     id			 INT IDENTITY PRIMARY KEY,
	 cusID		 INT foreign key(cusID) references dbo.Customer(id),
     roomName    VARCHAR(20),
     roomAddress NVARCHAR(50),
     roomTypeID  INT foreign key(roomTypeID) references dbo.RoomType(id),
     roomStatus  VARCHAR(20),
	 isDelete	 BIT DEFAULT('0'),
  )
GO
CREATE TABLE Booking
  (
     id			  INT IDENTITY PRIMARY KEY,
	 roomID       INT FOREIGN KEY(roomID) REFERENCES dbo.Room(id),
     cusID        INT FOREIGN KEY(cusID) REFERENCES dbo.Customer(id),
     dateCheckIn  SMALLDATETIME,
     dateCheckOut SMALLDATETIME,
  )
GO
CREATE TABLE Payment
  (
     id			  INT IDENTITY PRIMARY KEY,
     cusID		  INT FOREIGN KEY(cusID) REFERENCES dbo.Customer(id),
     amount       FLOAT,
     paymentDate  SMALLDATETIME,
     method       VARCHAR(10),	 
  )
GO
CREATE TABLE ServiceType
  (
     id		  INT IDENTITY PRIMARY KEY,
	 serName  NVARCHAR(100),
     serType  VARCHAR(10),
     serPrice FLOAT,
	 isDelete	 BIT DEFAULT('0'),
  )
GO
CREATE TABLE Service
  (
     id			INT IDENTITY PRIMARY KEY,
     serTypeID	INT foreign key(serTypeID) references dbo.ServiceType(id),
	 roomID		INT foreign key(roomID) references dbo.Room(id),
	 quantity	INT DEFAULT('1'),
	 status   BIT DEFAULT('0'),	-- 0 is not done; 1 is done
	 isDelete	BIT DEFAULT('0'),
  )
GO
CREATE TABLE Chef
  (
     id		  INT IDENTITY PRIMARY KEY,
     serID    INT FOREIGN KEY(serID) REFERENCES dbo.Service(id),
	 roomID   INT FOREIGN KEY(roomID) REFERENCES dbo.Room(id),
     foodName NVARCHAR(100),
     status   BIT DEFAULT('0'),	-- 0 is not done; 1 is done
  )
  --ALTER TABLE Chef Add CONSTRAINT PK_Cher PRIMARY KEY(SerID,RoomID)
GO
CREATE TABLE Clean
  (
     id		INT IDENTITY PRIMARY KEY,
     serID    INT FOREIGN KEY(serID) REFERENCES dbo.Service(id),
	 roomID   INT FOREIGN KEY(roomID) REFERENCES dbo.Room(id),
     status BIT DEFAULT('0'),	-- 0 is not done; 1 is done
  )
  --ALTER TABLE Clean Add CONSTRAINT PK_Clear PRIMARY KEY(SerID,RoomID)
  GO
  Create table Bar
  (
	id		 int identity primary key,
	serID    INT FOREIGN KEY(serID) REFERENCES dbo.Service(id),
	roomID   INT FOREIGN KEY(roomID) REFERENCES dbo.Room(id),
	Entertain nvarchar(100),
  )
  GO
  ---------------------------------------------------------------------------------------------------------------------------------------------------
  Insert INTO Staff (staffName, staffMail, staffDOB, staffGender, staffRole)
  VALUES ('Phuc', 'duyphuc@gmail.com', '23/09/2001', '1', 'CEO')
  , ('Phuong', 'hoangphuong@gmail.com', '21/05/2001', '1', 'HR')
  , ('Thinh', 'danchoixuhue@gmail.com', '15/08/2001', '1', 'Receptionist')
  , ('Ngan', 'kimngan@gmail.com', '24/01/1999', '0', 'Accountant')
  , ('Quynh', 'nhuquynh@gmail.com', '30/09/2000', '0', 'Sale')
  , ('Duyen', 'thuyduyen@gmail.com', '27/03/1991', '0', 'Chef')
  , ('Thai', 'thaichingchong@gmail.com', '01/02/1997','1', 'Cleaner')
  , ('Nam', 'namduong@gmail.com', '01/02/1997','1', 'Bar')
  GO
  ---------------------------------------------------------------------------------------------------------------------------------------------------
  Insert INTO Account (staffID,userName,userPass)	-- Password is A1234
  VALUES ('1','CEO', '4917347161351118122819723531232492499488')
  ,('2','HR', '4917347161351118122819723531232492499488')
  ,('3','Receptionist', '4917347161351118122819723531232492499488')
  ,('4','Accountant', '4917347161351118122819723531232492499488')
  ,('5','Sale', '4917347161351118122819723531232492499488')
  ,('6','Chef', '4917347161351118122819723531232492499488')
  ,('7','Clean', '4917347161351118122819723531232492499488')
  ,('8','Bar', '4917347161351118122819723531232492499488')
  GO
  ---------------------------------------------------------------------------------------------------------------------------------------------------
  INSERT INTO Report(message,staffID,document)
  VALUES('Khieu nai mon an','3', 'Mon an qua nguoi')
  ,('Khieu nai van de chuyen tien','3', 'Internet banking dang bi loi, khach khong the chuyen tien qua ngan hang')
  ,('Khieu nai dich vu ve sinh','3', 'Phong co mui am moc, ga giuong chua thom lam')
  ,('Bao cao nghien cuu thi truong','5', 'Qua nghien cuu thi truong, bo phan kinh doanh de xuat tang gia phong cung nhu gia tien cac dich vu giai tri')
  ,('Khieu nai mon an','3', 'Mon an duoc phuc vu khong dung gio')
  ,('Bao cao thu chi hang thang','4', 'Tong chi thang nay la 20000$, thu duoc 40000$, thang nay doanh thu tang 50%')
  ,('Bao cao ve viec khach lam hu hong vat tu cua Lang','3', 'Khach o phong ..... lam hong TV')
  GO
  ---------------------------------------------------------------------------------------------------------------------------------------------------
  INSERT INTO Customer(cusName,cusIDcard,cusPhone,cusEmail,dateCheckIn)
  VALUES ('Lam','1L','0983357767',' ','12/11/2021')
  ,('Tam','2T','0476534512','lamiq200@gmail.com','21/01/2021')
  ,('Nhu','3N','0913534515','nhucute2004@gmail.com','01/01/2021')
  ,('Phuong','4P','0931047974','19522059@gm.uit.edu.vn','25/05/2021')
  ,('Dep','5D','0943586779','deptrailamotcaitoi@gmail.com','31/12/2021')
  ,('Trai','6TR','0945781209',' ','05/03/2021')
  ,('Qua','7Q','0987654321','cocoduongqua01vjp@gmail.com','28/02/2021')
  GO
  ---------------------------------------------------------------------------------------------------------------------------------------------------
  INSERT INTO RoomType(roomType,roomPrice)
   VALUES ('3B','90')
 ,('2A','70')
 ,('3A','110')
  GO
  ---------------------------------------------------------------------------------------------------------------------------------------------------
 INSERT INTO Room(cusID,roomName,roomAddress,roomTypeID,roomStatus)
   VALUES ('1','Phong 301','Sanh B', '1','unavailable')
 ,('2','Phong 202','Sanh A', '2','available')
 ,('3','Phong 332','Sanh B', '1','unavailable')
 ,('4','Phong 340','Sanh C', '3','unavailable')
 ,('5','Phong 348','Sanh C', '3','booked')
 ,('6','Phong 220','Sanh A', '2','unavailable')
 ,('7','Phong 347','Sanh C', '3','available')
  GO
  ---------------------------------------------------------------------------------------------------------------------------------------------------
  INSERT INTO Booking(roomID,cusID,dateCheckIn,dateCheckOut)
  VALUES ('1','1','12/11/2021', '12/12/2021')
,('2','2','21/01/2021', '12/11/2021')
,('3','3','01/01/2021', '01/02/2022')
,('4','4','25/05/2021', '27/12/2021')
,('5','5','31/12/2021', '01/01/2022')
,('6','6','05/03/2021', '15/12/2021')
,('7','7','28/02/2021', '29/03/2021')
GO
---------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO ServiceType(serName,serType,serPrice)
VALUES ('Gan ngong vo beo', 'food','30')
, ('My hoanh thanh', 'food','25')
,('The hinh va tham my', 'bar','30')
,('Tour giai tri', 'bar','35')
,('Boi loi', 'bar','40')
,('San golf', 'bar','25')
,('Dich vu ve sinh phong', 'clean','10')
GO
---------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO Service(serTypeID,roomID)
VALUES ('1','1')
, ('2','2')
,('3','3')
,('4','4')
,('5','5')
,('6','6')
,('7','7')
GO
---------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO Payment(cusID,amount,paymentDate,method)
VALUES('2','20675','12/11/2021','banking')
, ('7','120','29/03/2021','cash')
GO
---------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO Chef(serID,roomID,foodName,status)
VALUES('1','1','Gan ngong vo beo','1')
,('2','2','My hoanh thanh','0')
GO
---------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO Clean(serID,roomID,status)
VALUES('7','7','1')
GO
---------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO Bar(serID,roomID,Entertain)
VALUES('3','3','The hinh va tham my')
,('4','4','Tour giai tri')
,('5','5','Boi loi')
,('6','6','San golf')
GO
--Procedure
CREATE PROC USP_Login
    @userName VARCHAR(100),
    @passWord VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM dbo.Account
    WHERE userName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS
          AND userPass = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS;
END;
GO

CREATE PROC USP_GetPositionByUserName @userName VARCHAR(100)
AS
BEGIN
    SELECT staffRole
    FROM dbo.Account
        INNER JOIN dbo.Staff
            ON Staff.id = Account.staffID
    WHERE userName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS;
END;
GO

CREATE PROC USP_GetIdByUserName @userName VARCHAR(100)
AS
BEGIN
    SELECT Staff.id
    FROM dbo.Account
        INNER JOIN dbo.Staff
            ON Staff.id = Account.staffID
    WHERE userName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS;
END;
GO

CREATE PROC USP_InsertBooking 
	@roomID INT,
	@cusID INT,
	@dateCheckIn SMALLDATETIME,
	@dateCheckOut SMALLDATETIME
AS
BEGIN
	INSERT INTO Booking(roomID,cusID,dateCheckIn,dateCheckOut)
	VALUES (@roomID,@cusID,@dateCheckIn, @dateCheckOut)

	UPDATE Room SET roomStatus = 'Booked', cusID=@cusID WHERE id=@roomID 
	UPDATE Customer SET dateCheckIn=@dateCheckIn WHERE id=@cusID
END;
GO

CREATE PROC USP_InsertCustomer 
	@cusName NVARCHAR(30),
	@cusIDcard VARCHAR(12),
	@cusPhone VARCHAR(10),
	@cusEmail VARCHAR(100) = NULL
AS
BEGIN
	SET DATEFORMAT DMY;
	INSERT INTO Customer(cusName,cusIDcard,cusPhone,cusEmail,dateCheckIn)
	VALUES (@cusName,@cusIDcard,@cusPhone,@cusEmail,'01/01/1900')
END;
GO

CREATE PROC USP_UpdateCustomer 
	@cusName NVARCHAR(30),
	@cusIDcard VARCHAR(12),
	@cusPhone VARCHAR(10),
	@cusEmail VARCHAR(100) = NULL
AS
BEGIN
	UPDATE Customer SET cusName=@cusName, cusPhone=@cusPhone WHERE cusIDcard=@cusIDcard
END;
GO

/*Drop table account
GO
drop table report
GO
drop table payment
GO
drop table booking
GO
drop table bar
drop table chef
drop table clean
GO
drop table service
GO
drop table serviceType
GO
DROP TABLE room
GO
drop table roomType
GO
DROP TABLE customer
GO
drop table staff*/