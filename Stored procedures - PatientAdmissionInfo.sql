USE [DB_LRCH]
GO

-- Drop the procedure if it already exists
IF OBJECT_ID('dbo.GetPatientAdmissionById', 'P') IS NOT NULL
    DROP PROCEDURE dbo.GetPatientAdmissionById
GO

-- Create the procedure
CREATE PROCEDURE dbo.GetPatientAdmissionById
    @admission_id INT
AS
BEGIN
    SET NOCOUNT ON; -- To prevent extra result sets from interfering with SELECT statements

    -- Select the record from ADMISSION table where the admission ID matches
    SELECT * 
    FROM ADMISSION 
    WHERE ADMISSION_ID = @admission_id;
END
GO
