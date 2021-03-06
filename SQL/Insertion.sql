
---------------------Table Insertion----------------------

insert into Manager     --Can't have too many managers
values
(1001,'Hana',13000,'aaa'),
(1002,'Mohamed',11000, 'bbb'),
(1003,'Menna',16000,'ccc'),
(1004,'Noha',12000,'ddd'),
(1005,'Ahmed',9000,'eee'),
(1006,'Karim',16000,'fff'),
(1007,'Khaled',11000,'eee')


insert into Region
values
('Mohandessin',15,1001),
('Sheikh Zayed',70,1001),
('6 October City',60,1002),
('Khamayel',60,1002),
('Nasr City',60,1003),
('New cairo',60,1003),
('Haram',45,1004),
('Faissal',40,1004),
('Maadi',40,1005),
('Zahraa Maadi',50,1005),
('Dokki',10,1006),
('Agouza',30,1006),
('Abbaseya',50,1007),
('Ghamra',80,1007),
('Giza',10,1007)


insert into CS_agent
values
(100,'Ahmed',5000,'Mohandessin','111'),
(101,'Mohamed',4000,'Giza','222'),
(102,'Karim',3000,'Haram','333'),
(103,'Khaled',5000,'Faisal','444'),
(104,'Nour',6000,'Giza','555'),
(105,'Amr',2000,'Giza','666'),
(106,'Omar',4000,'Giza','777'),
(107,'Hassan',5000,'Giza','888'),
(108,'Alaa',3000,'Giza','999'),
(109,'Essam',2000,'Giza','1010'),
(110,'Montasser',6000,'Giza','1111'),
(111,'Rabie',5000,'Giza','1212'),
(112,'Rania',4000,'Giza','1313'),
(113,'Reem',5000,'Giza','1414'),
(114,'Mai',2000,'Giza','1515'),
(115,'Mariam',6000,'Giza','1616'),
(116,'Merna',5000,'Giza','1717'),
(117,'Karima',7000,'Giza','1818'),
(118,'Khadija',5000,'Giza','2020'),
(119,'Dina',1000,'Giza','2121'),
(120,'Eman',5000,'Giza','2222')

insert into Trip
values
(201,14,30,'11:30:00','Mohandessin','F'),
(202,11,30,'12:30:00','Mohandessin','T'),
(203,10,20,'11:15:00','Dokki','F'),
(204,14,20,'12:30:00','Dokki','T'),
(205,6,40,'11:30:00','6 October City','F'),
(206,9,40,'13:30:00','6 October City','T'),
(207,12,50,'11:30:00','Khamayel','F'),
(208,13,50,'18:30:00','Khamayel','T'),
(209,5,40,'16:00:00','Maadi','F'),
(210,11,40,'10:00:00','Maadi','T'),
(211,14,30,'11:30:00','Zahraa Maadi','F'),
(212,14,30,'16:30:00','Zahraa Maadi','T'),
(213,4,35,'15:00:00','Abbaseya','F'),
(214,7,35,'16:30:00','Abbaseya','T'),
(215,4,30,'13:30:00','Ghamra','F'),
(216,4,30,'14:30:00','Ghamra','T'),
(217,12,30,'12:30:00','Dokki','F'),
(218,4,30,'12:30:00','Dokki','T'),
(219,14,20,'11:30:00','Agouza','F'),
(220,14,20,'9:00:00','Agouza','T'),
(221,8,20,'11:30:00','Mohandessin','F'),
(222,7,30,'17:00:00','Mohandessin','T'),
(223,6,40,'16:30:00','6 October City','F'),
(224,9,40,'13:30:00','6 October City','T'),
(225,14,30,'14:30:00','Mohandessin','F'),
(226,11,40,'17:30:00','Mohandessin','T'),
(227,14,40,'12:30:00','Mohandessin','F'),
(228,12,30,'11:30:00','Mohandessin','T'),
(229,10,20,'19:15:00','Dokki','F'),
(230,14,20,'12:30:00','Dokki','T')



insert into Bus
values
(301,'Green',14),
(302,'Green',14),
(303,'Green',8),
(304,'Green',14),
(305,'Green',14),
(306,'White',20),
(307,'White',14),
(308,'White',20),
(309,'White',8),
(310,'White',20),
(311,'White',8),
(312,'Red',14),
(313,'Red',20),
(314,'Red',14),
(315,'Red',20),
(316,'Red',14),
(317,'White',20),
(318,'White',14),
(319,'White',20),
(320,'White',14),
(321,'White',8),
(322,'White',20),
(323,'White',8),
(324,'White',14),
(325,'Blue',14),
(326,'Blue',20),
(327,'Blue',8),
(328,'Blue',14),
(329,'Blue',20),
(330,'Blue',14)



insert into App_User
values
(401,'Ahmed Khaled','01027695000','389028'),  --Riders
(402,'Mohamed Ahmed','01027697001','378927'),
(403,'Menna Alaa','01027695002','938976'),
(404,'Reem Ahmed','01027695003','897896'),
(405,'Radwa Mohamed','01017695004','125673'),
(406,'Noha Ahmed','01037697000','120937'),
(407,'Sara Mohamed','01027695070','120934'),
(408,'Hassan Mohamed','01067695080','129835'),
(409,'Mariam Hassan','01027699000','983567'),
(410,'Alaa Mahmoud','01027695090','239086'),
(411,'Shorouk Hassan','01027698000','349826'),
(412,'Shaimaa Ahmed','01027795000','325876'),
(413,'Maria Maged','01037655000','239087'),
(414,'Aya Mohamed','01025695000','346782'),
(415,'Salma Rabie','01087695000','280976'),
(416,'Rawda Mohamed','01057675000','190876'),
(417,'Mai Hassan','01127695000','287965'),
(418,'Marina Amgad','01127625000','985267'),
(419,'Mayada Medhat','01127695400','328967'),
(420,'Amira Salah','01127695050','231455'),
(421,'Dina Mohamed','01127695060','389076'),
(422,'Marwa Talaat','01227695400','457835'),
(423,'Ismail Ehab','01227695070','345678'),
(424,'Eman Abdelrahman','01227695008','230987'),
(425,'Abdelrahman Ahmed','01227695200','389076'),
(426,'Sandra William','01227695060','389076'),
(427,'Nivin Nasser','01227696700','298076'),
(428,'Nirvana Lotfy','01227698600','289076'),
(429,'Shahd Abdelrahman','01227695650','257864'),
(430,'Asmaa Magdy','01227695430','198675'), 
(501,'Ahmed Khaled','01027695000','389028'),  --Drivers 
(502,'Mohamed Ahmed','01137697001','378927'),
(503,'Omar Khaled','01137695002','938976'),
(504,'Ragab Ahmed','01137695003','897896'),
(505,'Sherif Zoheir','01237695004','125673'),
(506,'Mohamed Amr','01137697000','120937'),
(507,'Alaa Mohamed','01027689070','120934'),
(508,'Hassan Alnaggar','01067667080','129835'),
(509,'Ahmed Gomaa','01027698700','983567'),
(510,'Mohamed Mahmoud','01027695090','239086'),
(511,'Shawky Hassan','01027698000','349826'),
(512,'Sherif Ahmed','01027795000','325876'),
(513,'Morkos Maged','01037655000','239087'),
(514,'Ahmed Mohamed','01025695000','346782'),
(515,'Salem Rabie','01087695000','280976'),
(516,'Ragy Mohamed','01057675000','190876'),
(517,'Moaz Hassan','01127695000','287965'),
(518,'Amgad Sharaf','01127625000','985267'),
(519,'Medhat Omar','01127695400','328967'),
(520,'Salah Sakr','01127695050','231455'),
(521,'Mohamed Khalifa','01127695060','389076'),
(522,'Ihab Shafik','01227695400','457835'),
(523,'Ismail Hosny','01227695070','345678'),
(524,'Islam Elkomy','01227695008','230987'),
(525,'Abdelrahman Assad','01227695200','389076'),
(526,'William Hanna','01227695060','389076'),
(527,'Nasser Seif','01227696700','298076'),
(528,'Ahmed Lotfy','01227698600','289076'),
(529,'Abdelrahman Salah','01227695650','257864'),
(530,'Magdy Salem','01227695430','198675')


insert into Driver
values
(501,3000),   
(502,4000),
(503,3000),
(504,4000),
(505,4000),
(506,4000),
(507,4000),
(508,3000),
(509,3000),
(510,2000),
(511,3000),
(512,2000),
(513,2000),
(514,2000),
(515,5000),
(516,3000),
(517,4000),
(518,3000),
(519,4000),
(520,2000),
(521,2000),
(522,3000),
(523,2000),
(524,4000),
(525,3000),
(526,3000),
(527,4000),
(528,3000),
(529,2000),
(530,5000)

insert into Driving
values
(201,330,530),
(202,329,503),
(203,328,504),
(204,327,509),
(205,326,510),
(206,325,511),
(207,324,513),
(208,323,516),
(209,322,512),
(210,321,517),
(211,320,519),
(212,319,520),
(213,318,518),
(214,317,521),
(215,316,524),
(216,315,523),
(217,314,522),
(218,313,529),
(219,312,525),
(220,311,527),
(221,310,526),
(222,309,528),
(223,308,515),
(224,307,514),
(225,306,508),
(226,305,506),
(227,304,507),
(228,303,505),
(229,302,502),
(230,301,501)


insert into Rider
values
(401),
(402),
(403),
(404),
(405),
(406),
(407),
(408),
(409),
(410),
(411),
(412),
(413),
(414),
(415),
(416),
(417),
(418),
(419),
(420),
(421),
(422),
(423),
(424),
(425),
(426),
(427),
(428),
(429),
(430)




insert into Rating
values
(401,530,201,5),
(404,503,202,3),
(405,504,203,5),
(408,509,204,4),
(409,510,205,4),
(410,511,206,5),
(415,513,207,1),
(416,516,208,5),
(417,512,209,2),
(418,517,210,3),
(419,519,211,4),
(420,520,212,5),
(414,518,213,5),
(413,521,214,4),
(412,524,215,5),
(411,523,216,3),
(407,522,217,5),
(406,529,218,5),
(403,525,219,2),
(402,527,220,5)






insert into complaint (comp_no,Sender_ID,Trip_ID,about_ID,CS_ID,content)
values
(10,401,201,530,120,'MSG1'),
(11,404,202,503,119,'MSG2'),
(12,405,203,504,118,'MSG3'),
(13,408,204,509,117,'MSG4'),
(14,409,205,510,116,'MSG5'),
(15,410,206,511,115,'MSG26'),
(16,415,207,513,114,'MSG7'),
(17,416,208,516,113,'MSG8'),
(18,512,209,417,112,'MSG9'),
(19,418,210,517,111,'MSG10'),
(20,519,211,419,110,'MSG11'),
(21,420,212,520,109,'MSG12'),
(22,518,213,414,108,'MSG13'),
(23,413,214,521,107,'MSG14'),
(24,524,215,412,106,'MSG15'),
(25,411,216,523,105,'MSG16'),
(26,407,217,522,104,'MSG17'),
(27,529,218,406,103,'MSG18'),
(28,403,219,525,102,'MSG18'),
(29,527,220,402,101,'MSG19')






insert into Wallet
values
(401,604,40,'F'),
(402,604,40,'F'),
(403,606,0,'T'),
(404,607,10,'F'),
(405,610,100,'T'),
(406,611,0,'T'),
(407,614,20,'F'),
(408,615,15,'T'),
(409,618,30,'T'),
(410,617,26,'F'),
(411,616,30,'T'),
(412,613,45,'T'),
(413,612,50,'F'),
(414,609,10,'T'),
(415,608,40,'T'),
(416,602,22,'F'),
(417,605,25,'T'),
(418,601,12,'F'),
(419,609,10,'T'),
(420,605,25,'T'),
(421,613,45,'T'),
(422,612,50,'F'),
(423,616,30,'T'),
(424,608,40,'T'),
(425,612,50,'F'),
(426,605,25,'T'),
(427,610,100,'T'),
(428,602,22,'F'),
(429,609,10,'T'),
(430,605,25,'T')


insert into Book
values

(201,401,'2019-11-1'),
(202,402,'2019-11-2'),
(203,403,'2019-11-3'),
(204,404,'2019-11-4'),
(205,405,'2019-11-5'),
(206,406,'2019-11-6'),
(207,407,'2019-11-7'),
(208,408,'2019-11-8'),
(209,409,'2019-11-9'),
(210,410,'2019-11-10'),
(211,411,'2019-11-11'),
(212,412,'2019-11-12'),
(213,413,'2019-11-13'),
(214,414,'2019-11-14'),
(215,415,'2019-11-15'),
(216,416,'2019-11-16'),
(217,417,'2019-11-17'),
(218,418,'2019-11-18'),
(219,419,'2019-11-19'),
(220,420,'2019-11-20')

