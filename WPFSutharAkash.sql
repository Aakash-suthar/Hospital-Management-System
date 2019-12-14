use [20June Dot NetBatch]



create schema [187057_Akash_Akash_Akash]

select * from [187057_Akash_Akash_Akash].patients;

insert into [187057_Akash_Akash].doctors  values(1,'Akash','aids');
insert into [187057_Akash_Akash].doctors values (2,'Saras','obesity');

create table [187057_Akash_Akash].logintable(id int primary key,username varchar(40),pass varchar(40));

drop table [187057_Akash_Akash];

insert into[187057_Akash_Akash].patients values(1,'Akash',21,'male','asdfghjklhgfds','876543210')

select max from [187057_Akash_Akash].patients;
drop table [187057_Akash_Akash].patients;

insert into [187057_Akash_Akash].patients values(1,);

CREATE TABLE [187057_Akash_Akash].patients(
	Patient_Id int  PRIMARY KEY,
	Name varchar(50) ,
	Age int ,
	Weight int,
	Gender varchar(50) ,
	Address varchar(50) ,
	PhoneNo varchar(50) )

drop table [187057_Akash_Akash].patients;

CREATE TABLE [187057_Akash_Akash].doctors(
	doctor_id int  PRIMARY KEY,
	doctor_name varchar(50) ,
	department varchar(50) );

CREATE TABLE [187057_Akash_Akash].inpatients(
	patient_id int  PRIMARY KEY,
	admission_date date ,
	doctor_assigned int ,
	disease varchar(50) ,
	room_assigned int );






CREATE TABLE [187057_Akash_Akash].rooms(
	room_id int  PRIMARY KEY,
	room_name varchar(50) ,
	patient_id int NULL,
	room_charge int );



	insert into [187057_Akash_Akash].rooms(room_id,room_name,room_charge) values(1,'R-01',1500);
	insert into [187057_Akash_Akash].rooms(room_id,room_name,room_charge) values(2,'R-02',1700);
	insert into [187057_Akash_Akash].rooms(room_id,room_name,room_charge) values(3,'R-03',1600);
	insert into [187057_Akash_Akash].rooms(room_id,room_name,room_charge) values(4,'R-04',2000);
	insert into [187057_Akash_Akash].rooms(room_id,room_name,room_charge) values(5,'R-05',3000);
	


CREATE TABLE [187057_Akash_Akash].labs(
	lab_id int IDENTITY(1,1)  PRIMARY KEY,
	patient_id int NULL,
	test_name varchar(50) NULL,
	test_cost int NULL);


