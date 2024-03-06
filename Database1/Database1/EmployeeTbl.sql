CREATE TABLE [dbo].[EmployeeTbl] (
    [EmpId]   INT          IDENTITY (1, 1) NOT NULL,
    [EmpName] VARCHAR (50) NOT NULL,
    [EmpGen]  VARCHAR (50) NOT NULL,
    [EmpAdd]  VARCHAR (50) NOT NULL,
    [EmpPass] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmpId] ASC)
);

