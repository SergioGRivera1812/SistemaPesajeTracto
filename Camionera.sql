create database Camionera 
use Camionera 

create table RegistroC(
ID varchar(4) primary key not null,
PlacasC varchar(max) not null,
PTara int not null,
PNeto int,
PBruto int, 
)

Drop table  RegistroC
select * from RegistroC



