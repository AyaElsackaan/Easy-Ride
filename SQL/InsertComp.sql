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
CREATE PROCEDURE InsertComp
	-- Add the parameters for the stored procedure here
	@sender int,
	@trip int,
	@about int,
	@content varchar(1000)
AS
BEGIN
	insert into complaint(comp_no,Sender_ID,Trip_ID,about_ID,content)
	values(1+(select count(*) from complaint),@sender,@trip,@about,@content);
END
GO
