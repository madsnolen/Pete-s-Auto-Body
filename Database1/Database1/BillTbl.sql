CREATE TABLE [dbo].[BillTbl] (
    [BillNum]  INT          IDENTITY (1, 1) NOT NULL,
    [CarNum]   VARCHAR (50) NOT NULL,
    [BDate]    DATE         NOT NULL,
    [MechFees] INT          NOT NULL,
    [PartFees] INT          NULL,
    [TotFees]  INT          NOT NULL,
    [EmpName]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([BillNum] ASC)
);

