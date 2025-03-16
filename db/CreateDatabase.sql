-- CREATE DATABASE
CREATE DATABASE PostalManagementDB;
GO

-- USE THE DATABASE
USE PostalManagementDB;
GO

-- CREATE CLIENTS TABLE
CREATE TABLE ClientsTbl (
    ClientID      INT           IDENTITY (1, 1) NOT NULL,
    ClientName    VARCHAR (50)  NOT NULL,
    ClientNID     VARCHAR (50)  NOT NULL,
    ClientContact INT           NOT NULL,
    Email         VARCHAR (50)  NOT NULL,
    ClientAddress VARCHAR (100) NOT NULL,
    NIDpic        IMAGE         NOT NULL,
    PRIMARY KEY (ClientID)
);
GO

-- CREATE POSTMAN TABLE
CREATE TABLE PostmanTbl (
    OfficerID      INT           IDENTITY (1, 1) NOT NULL,
    OfficerName    VARCHAR (50)  NOT NULL,
    OfficerAddress VARCHAR (100) NOT NULL,
    HireDate       DATE          NOT NULL,
    Employment     VARCHAR (50)  NOT NULL,
    OfficerContact VARCHAR (20)  NULL,
    PRIMARY KEY (OfficerID)
);
GO

-- CREATE PACKAGE TABLE
CREATE TABLE PackageTbl (
    PackageID       INT           IDENTITY (1, 1) NOT NULL,
    Dimension       VARCHAR (50)  NOT NULL,
    Weight          INT           NOT NULL,
    Priority        VARCHAR (50)  NOT NULL,
    Content         VARCHAR (100) NOT NULL,
    SenderID        INT           NULL,
    DropDate        DATE          NOT NULL,
    ReceiverName    VARCHAR (50)  NOT NULL,
    ReceiverContact VARCHAR (50)  NOT NULL,
    ReceiverAddress VARCHAR (100) NOT NULL,
    OfficerID       INT           NULL,
    PRIMARY KEY (PackageID),
    CONSTRAINT FK_PackageTbl_Officer FOREIGN KEY (OfficerID) REFERENCES PostmanTbl (OfficerID) ON DELETE SET NULL,
    CONSTRAINT FK_PackageTbl_SenderID FOREIGN KEY (SenderID) REFERENCES ClientsTbl (ClientID) ON DELETE CASCADE
);
GO

-- CREATE CASH TRANSFER TABLE
CREATE TABLE CashTransferTbl (
    TransferID      INT           IDENTITY (1, 1) NOT NULL,
    TransferDate    DATE          NOT NULL,
    Amount          INT           NOT NULL,
    TransferType    VARCHAR (50)  NOT NULL,
    TransferPurpose VARCHAR (100) NOT NULL,
    SenderID        INT           NULL,
    ReceiverName    VARCHAR (50)  NOT NULL,
    ReceiverAddress VARCHAR (50)  NOT NULL,
    ReceiverContact VARCHAR (50)  NOT NULL,
    Status          VARCHAR (50)  NOT NULL,
    PRIMARY KEY (TransferID),
    CONSTRAINT FK_CashTransfer_Sender FOREIGN KEY (SenderID) REFERENCES ClientsTbl (ClientID) ON DELETE CASCADE
);
GO


