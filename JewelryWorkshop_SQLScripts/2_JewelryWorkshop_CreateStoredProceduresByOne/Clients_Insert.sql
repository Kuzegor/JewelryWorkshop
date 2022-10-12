
CREATE PROCEDURE dbo.spClients_Insert
@LastName nvarchar(60),
@FirstName nvarchar(60),
@MiddleName nvarchar(60),
@Phone nvarchar(60),
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.Clients (LastName, FirstName, MiddleName, Phone)
	values (@LastName, @FirstName, @MiddleName, @Phone);

	select @id = SCOPE_IDENTITY();
END
GO
