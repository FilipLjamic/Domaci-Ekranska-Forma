create database EkranskaFormaDomaci

USE EkranskaFormaDomaci

create table song
(
  id int identity(1, 1) primary key,
  naziv nvarchar(100) not null,
  izvodjac nvarchar(100) not null,
  trajanje nvarchar(100) not null,
  jezik nvarchar(100) not null
)

insert into song(naziv, izvodjac, trajanje, jezik)
VALUES('Off The Grid', 'Kanye West', '5:39', 'Engleski')