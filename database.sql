use master
go

drop database if exists Test
go

create database Test
go

use Test
go


create table Categories
(
    Id          int identity
        constraint PK_Categories
            primary key,
    Name        nvarchar(50),
    Description nvarchar(100)
)
go

create table Games
(
    Id          int identity
        constraint PK_Games
            primary key,
    CategoryId  int
        constraint FK_Games_Categories
            references Categories,
    Name        nvarchar(100),
    Description nvarchar(max),
    ReleaseDate datetime
)
go

