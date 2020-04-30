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
CREATE PROCEDURE getTripCode
	-- Add the parameters for the stored procedure here
	@reg varchar(50),
	@dir char(1),
	@time time
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select Trip_code
	from Trip join Driving on T_code=Trip_code join bus on Driving.Bus_no=Bus.Bus_no 
	where reg=@reg 
		  and direction=@dir
		  and start_time=@time
		  and Riders_no< capacity;
END
GO
