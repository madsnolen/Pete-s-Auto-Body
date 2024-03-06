CREATE TABLE [dbo].[StockTbl] (
    [ParId]     INT          IDENTITY (100, 1) NOT NULL,
    [PartName]  VARCHAR (50) NOT NULL,
    [PartQty]   INT          NOT NULL,
    [PartPrice] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ParId] ASC)
);

