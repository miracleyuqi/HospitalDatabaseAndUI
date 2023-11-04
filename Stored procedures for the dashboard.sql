
--PATIENT-PHYSICIAN-ADMISSION PROCEDURE
--PATIENT-PHYSICIAN-ADMISSION PROCEDURE
CREATE PROCEDURE PatientAdmissionInfo
    @admission_id INT
AS
BEGIN
    SELECT 
        CONCAT(p.PATIENT_FIRST_NAME, ' ', p.PATIENT_LAST_NAME) AS 'PATIENT NAME', 
        a.PATIENT_ID, 
        p.SEX, 
        b.ROOM_NUMBER, 
        b.BED_NUMBER, 
        a.ADMISSION_DATE, 
        a.APPOINTMENT, 
        c.DESCRIPTION AS 'TREATMENT', 
        p.LAST_DISCHARGE_DATE AS 'LAST DISCHARGE DATE', 
        a.NOTE, 
        a.ADMISSION_ID
    FROM ADMISSION a
    INNER JOIN PATIENT p ON a.PATIENT_ID = p.PATIENT_NO
    INNER JOIN PRESCRIPTION pr ON p.PATIENT_NO = pr.PATIENT_ID
    INNER JOIN CHARGE_ITEM c ON a.ADMISSION_ID = c.ADMISSION_ID
    INNER JOIN BED b ON b.BED_ID = a.BED_ID
    WHERE a.ADMISSION_ID = @admission_id; -- Assuming the filter should be on the ADMISSION table
END
GO

--EXEC PatientAdmissionInfo 4

CREATE PROCEDURE AddNoteToAdmission
    @AdmissionId INT,
    @NoteString NVARCHAR(200)
AS
BEGIN
    UPDATE Admission
    SET Note = @NoteString
    WHERE Admission_Id = @AdmissionId;
END
GO

CREATE PROCEDURE CountAppointment
@physician_id int,
@AppointmentStatusCount INT OUTPUT

AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT @AppointmentStatusCount=COUNT(*) 
    FROM Admission a
  JOIN PATIENT p ON a.PATIENT_ID = p.PATIENT_NO
  JOIN PRESCRIPTION ON p.PATIENT_NO = PRESCRIPTION.PATIENT_ID
    WHERE  a.APPOINTMENT= 1 and PRESCRIPTION.PHYSICIAN_ID = @physician_id;

END
GO

--store procedure
CREATE PROCEDURE sp_GetBedOccupancy
AS
BEGIN
  SET NOCOUNT ON;

  DECLARE @Total_Beds INT;
  DECLARE @Occupied_Beds INT;
  DECLARE @Overall_Occupancy DECIMAL(5,2);
  
  SELECT
    @Total_Beds = COUNT(*),
    @Occupied_Beds = COUNT(CASE WHEN DISCHARGE_DATE IS NULL THEN 1 ELSE NULL END),
    @Overall_Occupancy = CAST(COUNT(CASE WHEN DISCHARGE_DATE IS NULL THEN 1 ELSE NULL END) AS DECIMAL(5,2)) / @Total_Beds * 100
  FROM
    BED b
    LEFT JOIN ADMISSION a ON b.BED_ID = a.BED_ID;
  
  SET @Overall_Occupancy = ROUND(@Overall_Occupancy, 0);  
  SELECT 
	@Total_Beds AS Total_Beds,
    @Occupied_Beds AS Occupied_Beds,
    CONVERT(VARCHAR(10), @Overall_Occupancy) + '%' AS Overall_Occupancy;

END;
GO

  --Overall Occupancy by Rooms
CREATE PROCEDURE RoomOccupancy
AS
BEGIN
  SET NOCOUNT ON;
   DECLARE @Total_Rooms INT;
  DECLARE @Occupied_Rooms INT;
  DECLARE @Overall_Occupancy DECIMAL(5,2);
  SELECT
    COUNT(*) AS Total_Rooms,
    COUNT(DISTINCT b.ROOM_NUMBER) AS Occupied_Rooms,
    CONCAT(CAST(ROUND(CAST(COUNT(DISTINCT b.ROOM_NUMBER) AS DECIMAL(5,2)) / CAST(COUNT(*) AS DECIMAL(5,2)) * 100, 0) AS INT), '%') AS Overall_Occupancy
 
 FROM
    BED b
    LEFT JOIN ADMISSION a ON b.BED_ID = a.BED_ID
  WHERE
    a.DISCHARGE_DATE IS NULL; -- Only include currently occupied rooms
END;
GO
--exec RoomOccupancy
-- Occupancy by Room Type

CREATE PROCEDURE RoomOccupancyByType
AS
BEGIN
  SET NOCOUNT ON;

  SELECT
    r.ROOM_TYPE,
    COUNT(*) AS Total_Rooms,
    COUNT(CASE WHEN a.DISCHARGE_DATE IS NULL THEN 1 ELSE NULL END) AS Occupied_Rooms,
    CONCAT(CAST(ROUND(CAST(COUNT(CASE WHEN a.DISCHARGE_DATE IS NULL THEN 1 ELSE NULL END) AS DECIMAL(5,2)) / CAST(COUNT(*) AS DECIMAL(5,2)) * 100, 0) AS INT), '%') AS  Occupancy_Rate
  FROM
    ROOM r
    LEFT JOIN BED b ON r.ROOM_NUMBER = b.ROOM_NUMBER
    LEFT JOIN ADMISSION a ON b.BED_ID = a.BED_ID
  GROUP BY
    r.ROOM_TYPE;
END;
GO
--exec RoomOccupancyByType

--# of Beds Discharging Patients Today
CREATE PROCEDURE DischargingPatientsToday
AS
BEGIN
  SET NOCOUNT ON;

  SELECT
    COUNT(*) AS Discharging_Patients_today
  FROM
    ADMISSION
  WHERE
    DISCHARGE_DATE = CONVERT(DATE, GETDATE());
END;
GO

--exec DischargingPatientsToday
-- # of Empty Rooms by Room Type
CREATE PROCEDURE BedOccupancy
AS
BEGIN
  SET NOCOUNT ON;

  SELECT
    r.ROOM_TYPE,
    COUNT(*) AS Total_Beds,
    COUNT(CASE WHEN a.DISCHARGE_DATE IS NULL THEN 1 ELSE NULL END) AS Occupied_Beds,
    COUNT(*) - COUNT(CASE WHEN a.DISCHARGE_DATE IS NULL THEN 1 ELSE NULL END) AS Empty_Beds
  FROM
    ROOM r
    LEFT JOIN BED b ON r.ROOM_NUMBER = b.ROOM_NUMBER
    LEFT JOIN ADMISSION a ON b.BED_ID = a.BED_ID
  GROUP BY
    r.ROOM_TYPE;
END;
GO
--exec BedOccupancy
