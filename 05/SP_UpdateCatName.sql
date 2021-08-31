declare @name varchar;
set @name = "Billy";

alter PROC UpdateCatName  @Id int,  @name varchar(max)
as
update Cats set Name = @name
where Id = @Id

EXEC UpdateCatName @Id=1, @name="Dextor"
select * from cats