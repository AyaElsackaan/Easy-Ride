create database Easy_Ride
go
use Easy_Ride
Create table Manager 
(
M_ID int not null,
primary key (M_ID),
M_name varchar(50) not null,
salary int not null, 
pswrd varchar(50) not null
) 

create table Region
(
Reg_name varchar(50) not null,
primary key(Reg_name),
duration int not null,
--trips_per_day int not null,
Mngr_ID int
foreign key (Mngr_ID) references Manager on update cascade on delete set null 
)

Create table CS_agent
(
CS_ID int not null,
primary key(CS_ID),
CS_name varchar(50) not null,
salary int not null,
region_name varchar(50),
 foreign key(region_name) references Region on update cascade on delete set null,
 pswrd varchar(50) not null

)

create table Trip
(
T_code int not null,
primary key(T_code),
Riders_no int not null default 0,
price int not null,
start_time time not null,
reg varchar(50),
foreign key (reg) references Region on update cascade on delete cascade,
direction char(1) not null, --one letter F:from or T: to
)

create table Bus
(
Bus_no int not null, 
primary key (Bus_no),
color varchar(50) not null,
capacity int not null
)

create table App_User
(
ID int not null,
primary key(ID),
name varchar(50)not null,
phone char(11) not null,
pswrd char(6)not null 
)

create table Driver
(
D_ID int not null,
primary key (D_ID),
foreign key (D_ID) references App_User on update cascade on delete cascade,
salary int not null
)

create table Driving
(
Trip_code int not null,
foreign key(Trip_code) references Trip on update cascade on delete cascade,
Bus_no int not null,
foreign key(Bus_no) references Bus on update cascade on delete cascade,
Driver_ID int not null,  
foreign key(Driver_ID) references Driver on update cascade on delete cascade,
primary key(Trip_code, Bus_no,Driver_ID)
) 

create table Rider
(
R_ID int not null,
primary key (R_ID),
foreign key (R_ID) references App_User on update cascade on delete cascade
)
create table Rating 
(
R_ID int not null,
foreign key(R_ID) references Rider on update cascade on delete cascade,
D_ID int not null,
foreign key(D_ID) references Driver,-------------ERROR CASCADE
T_ID int not null,
foreign key(T_ID) references Trip on update cascade on delete cascade,
primary key (R_ID, D_ID,T_ID),
rating_value int not null
)
create table complaint
(
comp_no int not null,
Sender_ID int not null,
foreign key(Sender_ID) references App_User,----------ERROR CASCADE
Trip_ID int not null,
foreign key (Trip_ID) references Trip on update cascade on delete cascade,
about_ID int not null,
foreign key(about_ID) references App_User,-------------ERROR CASCADE
primary key(comp_no, Sender_ID, Trip_ID, about_ID),
CS_ID int,
foreign key (CS_ID) references CS_agent,--------------------ERROR CASCADE
content varchar(1000) not null,
reply varchar(1000)
)




create table Wallet
(
R_ID int not null,
foreign key (R_ID) references Rider on update cascade on delete cascade,
Wallet_no int not null,
primary key(R_ID,wallet_no),
Credit int default 0,
Promo char(1)  --one letter T:has promo, F:no promo

)

create table Book
(
Trip_code int not null,
foreign key (Trip_code) references Trip on update cascade on delete cascade,
R_ID int not null,
foreign key (R_ID) references Rider on update cascade on delete cascade,
primary key(Trip_code, R_ID), 
trip_date date not null
)

