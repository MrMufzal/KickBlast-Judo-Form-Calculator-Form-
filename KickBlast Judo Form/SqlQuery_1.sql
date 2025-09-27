-- Create the database
CREATE DATABASE KickBlastJudo;
GO

-- Use the database
USE KickBlastJudo;
GO

-- Create the Athletes table
CREATE TABLE Athletes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    [Plan] NVARCHAR(50) NOT NULL,
    Weight FLOAT NOT NULL,
    WeightCategory NVARCHAR(50) NOT NULL,
    PrivateCoachingHours INT NOT NULL,
    Competitions INT NOT NULL,
    MonthlyFee FLOAT NOT NULL,
    CoachingCost FLOAT NOT NULL,
    CompetitionCost FLOAT NOT NULL,
    TotalCost FLOAT NOT NULL,
    Eligibility NVARCHAR(200) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

SELECT * FROM Athletes;
