create proc spAddCustomer
@name varchar(20),
@zipcode varchar(6),
@email varchar(50),
@username varchar(20),
@password varchar(50)
as
Begin
	Insert into customer values (@name, @zipcode, @email) 
	declare @id int = @@identity
	Insert into login Values(@username,@password)
	 declare @cust_id int= @@identity
End
go