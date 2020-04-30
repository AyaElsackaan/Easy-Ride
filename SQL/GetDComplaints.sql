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
CREATE PROCEDURE GetDComplaints
	-- Add the parameters for the stored procedure here
	@reg varchar(50)
AS
BEGIN
select comp_no from complaint join Trip on T_code=Trip_ID
 where reg=@reg and Sender_ID in (select D_ID from Driver);
 END
GO

 