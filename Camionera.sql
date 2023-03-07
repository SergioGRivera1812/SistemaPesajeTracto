create database Camionera 
use Camionera 

create table RegistroC(
ID varchar(4) primary key not null,
PlacasC varchar(max) not null,
PTara int not null,
Fecha varchar(15),
HoraE varchar(20),
HoraS varchar(20),
PBruto int,
PNeto int, 
)

Drop table  RegistroC
select * from RegistroC



