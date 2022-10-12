
CREATE PROCEDURE dbo.spClients_UpdateById
@LastName nvarchar(60),
@FirstName nvarchar(60),
@MiddleName nvarchar(60),
@Phone nvarchar(60),
@id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Update dbo.Clients
	set LastName = @LastName,
	FirstName = @FirstName,
	MiddleName = @MiddleName,
	Phone = @Phone
	where dbo.Clients.id = @id;
END
GO
