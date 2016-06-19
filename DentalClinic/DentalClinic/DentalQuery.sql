create database DentalClinic
--drop database DentalClinic

use DentalClinic

drop table Patient
create table Patient(
	PatientID int not null,
	P_LName varchar(60),
	P_FName varchar(60),
	P_MName varchar(60),
	P_Age int,
	P_Sex varchar(10),
	P_Add varchar(300),
	P_Contact int,
	primary key(PatientID),
	constraint pk_PatientID unique(PatientID,P_LName)
)
select * from Patient

drop table Schedule
create table Schedule(
	ScheduleNo int not null,
	Sched_Date date,
	Sched_Time time,
	Sched_Descrip varchar(300),
	primary key(ScheduleNo)
)
select * from Schedule

drop table Dentist
create table Dentist(
	DentistID int not null,
	D_LName varchar(60),
	D_FName varchar(60),
	D_MName varchar(60),
	D_Add varchar(300),
	D_Contact int,
	D_Username varchar(30),
	D_Password varchar(30),
	primary key(DentistID),
	constraint pk_DentistID unique(DentistID,D_LName)
)
select * from Dentist

drop table Staff
create table Staff(
	StaffID int not null,
	S_LName varchar(60),
	S_Fname varchar(60),
	S_Age int,
	S_Contact int,
	S_Username varchar(30),
	S_Password varchar(30),
	S_Restriction varchar(40),
	primary key(StaffID),
	constraint pk_StaffID unique(StaffID,S_LName)
)
select * from Staff

drop table Inventory
create table Inventory(
	InventoryID int not null,
	Inv_Name varchar(60),
	Inv_Quantity int,
	primary key(InventoryID),
	constraint pk_InventoryID unique(InventoryID,Inv_Name)
)
select * from Inventory