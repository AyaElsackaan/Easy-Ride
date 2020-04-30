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
CREATE PROCEDURE CancelTrip
	-- Add the parameters for the stored procedure here
	@code int, 
	@id int,
	@date date
AS
BEGIN
	
	delete from Book
	where Trip_code=@code and R_ID=@id and trip_date=@date;

	update Trip
	set Riders_no=Riders_no-1
	where T_code=@code;
END
GO
