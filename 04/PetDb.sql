--this is a comment
/*
this
is multiline comment
*/
--use PetDb;--does not work with Azure sql Db
--drop table CatType;
create table catType(
	Id int identity(1,1) primary key,
	Name varchar(100) not null
)

--drop table FurType;
create table FurType(
	Id int identity(1,1) primary key,
	Name varchar(100) not null
);

--drop table Gender
create table Gender(
	Id int primary key default 1,
	Name varchar(10) not null
);

--drop table Cats
create table Cats(
	Id int identity(1,1) primary key,
	Name varchar(100) not null,
	Dob datetime,
	legLength decimal,
	ribcage decimal,
	GenderId int foreign key references Gender(Id) not null,
	CatType int Foreign Key references CatType(Id),
	FurType int Foreign key references FurType(Id) 
);

alter table cats
alter column Dob Date

insert into Furtype(Name) Values('Short')
insert into Furtype(Name) Values('Long')
insert into Furtype(Name) Values('Medium')
insert into Furtype(Name) Values('No Fur')

insert into Cattype(Name) Values('Bengal')
insert into Cattype(Name) Values('American Bobtail')
insert into Cattype(Name) Values('British Shorthair')
insert into Cattype(Name) Values('Tabby')
insert into Cattype(Name) Values('Abssysian')

insert into Gender(Name) values('Male') -- Id 1 will be added as default
insert into Gender(Id,Name) values(2,'Female')

insert into cats(name, dob, genderid, furtype, cattype) values('Kitty', '2016-11-5', 1,1,1)
insert into cats values('Kitty', '2015-1-5',2.0, 14.5, 2,2,2)
select * from cats
select * from Gender
select * from Cattype

--drop table FoodType;
create table FoodType(
	Id int primary key identity,
	Type varchar(100)
);

--drop table meals
create table Meals(
	Id int Primary key identity(1,1),
	FoodType int Foreign key references FoodType(Id) not null,
	Time DateTime not null default sysdatetime(),
	catid int foreign key references cats(id) not null
);

insert into foodtype values ('Dry');
insert into foodtype values ('Wet');

insert into meals(foodtype,time, catid) values(1, sysdatetime(), 1)
select * from foodtype
select * from meals
select * from cats















