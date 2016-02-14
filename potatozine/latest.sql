create database Potatozine

create table magazine(
prodID varchar(10),
name varchar(100),
descpt varchar(1000),
price money,
catcd int,
img varchar(500),
pages int
)

insert into magazine
values ('M1','CLEO','CLEO is a magazine for young fun women who are always on the lookout for brand new ideas and are ready to eyyxplore their horizons and learn new things. CLEO also gives women fashion tips and ideas and prepares them to make the most important decisions they will make in their lives.',2.00,1,'Images/cleo.jpg',69),
('M2','Bazaar Art','Bazaar Art focuses on art and fashion giving readers the latest trends and ideas to look out for.',2.50,1,'Images/bazarart.jpg',96),
('M3','Her World','Her World is the magazine most women choose for the latest tips and tricks to stay in top shape and issues that concern the modern woman. This magazine includes interviews and articles which set you thinking about current issues and is recommended for any woman looking for a fashion magazine.',5.40,1,'Images/herworld.jpg',54),
('M4','Simply Her','This magazine provides her with shopping ideas and is a lifestyle guide that is trusted by many in Singapore. This magazine focuses on working women who are often busy and provides them with the best ideas possible to look in trend and be in top fashion.',3.30,1,'Images/simplyher.jpg',31),
('M5','MensHealth','Trusted by many men around the world. Mens health provides tips on health and beauty for the male. The magazine also includes some fashion tips for men who wish to look in tip top condition with the best looking outfits possible at any moment of time.',5.00,1,'Images/MensHealth.jpg',54),
('M6','Allyou','Unisex magazine made for him and her. Focuses all about you and gives you health and fashion tips and tricks to stand out among all.',1.20,1,'Images/allyou.jpg',32),
('M7','How It Works','The magazine that shows you how things around the world work. Touches on some technology issues as well to tell you how it all works in this world.',3.00,2,'Images/howitworks.jpg',142),
('M8','SMART','SMART magazine focuses on the innovations and creativity made by some of the most brilliant innovaters in the world. This magazine keeps you in trend with the latest technological discoveries by people.',3.00,3,'Images/SMART.jpg',94),
('M9','TRAVELE','TRAVELE is a new magazine which aims to give readers an insight into the world and give them ideas for their next vaycay plans.',3.00,3,'Images/TRAVELE.png',98),
('M10','Local Adventures','Local Adventures is a magazine targeted at locals who are on a tight budget and wish to uncover new things locally.',4.20,3,'Images/LocalAdventures.png',65)

create table Book(
prodID varchar(10),
name varchar(100),
descpt varchar(1000),
price money,
catcd int,
img varchar(500),
publisher varchar(100),
author varchar(100),
type varchar(100)
)

create table accountinfo(
Username varchar(50) not null primary key,
Password varchar(50) not null,
MemberType varchar(15) not null
)


create table category(
catcd int PRIMARY KEY,
catname varchar(30)
)

insert into category
values (0, 'All'),
(1, 'Fashion'),
(2, 'Technology'),
(3, 'Travel')

drop table magazine
drop table book
drop table category

select * from magazine