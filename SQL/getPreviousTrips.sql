-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE getPreviousTrips 
	-- Add the parameters for the stored procedure here
	@id int,
	@date date,
	@time time
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select trip_code 
	from Book join trip on T_code=trip_code
    where R_ID=@id and trip_date<@date
	union
	select trip_code
	from Book join trip on T_code=trip_code
    where R_ID=@id and trip_date=@date and start_time<@time;
	
END
GO
