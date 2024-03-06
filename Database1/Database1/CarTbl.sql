CREATE TABLE [dbo].[CarTbl] (
    [CNum]      VARCHAR (50) NOT NULL,
    [CBrand]    VARCHAR (50) NOT NULL,
    [CModel]    VARCHAR (50) NOT NULL,
    [CDate]     DATE         NOT NULL,
    [CColor]    VARCHAR (50) NOT NULL,
    [OwnerName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CNum] ASC)
);

