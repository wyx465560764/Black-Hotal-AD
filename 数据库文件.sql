
create database HotelManage
go
use HotelManage
go

-----------------------顾客信息表---------------------
create table GuestInfo(
Gid int primary key identity(1,1)not null, --顾客ID
Gname  varchar(10) not null, --顾客姓名
GTid  int  not null, --顾客类型
Sex char(5), --性别
Mobile varchar(30), --电话号码
ChargeSum money ,--消费总金额
Pid varchar(20) --身份证号码
)
--drop table GuestInfo
insert into GuestInfo values('张三',1,'男','13657168500',1200,'420984199310134430')
insert into GuestInfo values('李四',2,'男','13657168500',800,'420984199310134430')
insert into GuestInfo values('王五',3,'女','13657168500',760,'420984199310134430')
insert into GuestInfo values('赵六',4,'女','13657168500',2400,'420984199310134430')

select * from GuestInfo --顾客信息表
--select * from GuestInfo,GuestType where GuestType.GTid=GuestInfo.GTid 


--------------------顾客类别表------------------------
create table GuestType(
GTid  int primary key identity(1,1) not null, --类别ID
Tname varchar(10) not null, --类别名称
Trate float not null,--折扣
)
--drop table GuestType
insert into GuestType values('普通会员',1)
insert into GuestType values('高级会员',0.95)
insert into GuestType values('黄金会员',0.90)
insert into GuestType values('钻石会员',0.85)

select * from GuestType --顾客类型表





-------------------入住信息记录表---------------------
create table Record(
REid int primary key identity(1,1) not null, --入住编号
Gid int not null, --顾客编号
RoomId int not null ,--房间编号
InTime datetime ,--入住时间
OutTime datetime,--离开时间
FactTime varchar(50) default '暂未离开',--实际离开时间
daynum int,--入住天数
Charge int default 0--交付押金

)
update record set inttime='{0}',outtime='{1}',daynum=daynum+{2},charge={3} where roomid={4} and facttime='暂未离开'
--select * from Record,guestinfo where record.gid=guestinfo.gid
--drop table Record
insert into Record values(1,3,'2014-10-13 10:10:32','2015-5-8 10:10:32',default,5,2200)
insert into Record values(2,5,'2015-4-17 10:10:32','2015-5-5 10:10:32',default,5,2200)
insert into Record values(3,13,'2015-4-13 10:10:32','2015-5-1 10:10:32',default,5,5600)
insert into Record values(4,23,'2015-4-8 10:10:32','2015-6-1 10:10:32',default,5,2200)


--update record set facttime='暂未离开',daynum=1,charge=100 where reid = 1

--select datediff(day,'2015-4-13 10:10:32',getdate()) 'daynum'

--select * ,(outtime-Intime)'day'from record,roominfo where record.roomid=roominfo.roomid order by day asc


select * from Record --入住信息记录表





------------------------楼层信息表------------------------
create table FloorInfo(
Fid int primary key identity(1,1) not null, --楼层ID
Fname varchar(20) --楼层名称
)
--drop table FloorInfo
insert into FloorInfo values('A栋')
insert into FloorInfo values('B栋')
insert into FloorInfo values('C栋')



select * from FloorInfo --楼层信息表




------------------------操作员表-------------------------
create table OPInfo(
OId int primary key identity(1,1) not null,--操作员ID
OName varchar(20) not null,--操作员姓名
Pwd varchar(20) not null--操作员密码
)
--drop table OPInfo
insert into OPInfo values('huangkuan','123')
insert into OPInfo values('akuan','123')

select * from OPInfo --操作员信息表


----------------------房间信息表--------------------------
create table RoomInfo(
RoomId int primary key identity(1,1) not null, --房间编号
Number varchar(20) not null ,--房间号 
RTid int ,--房间类型ID
RSid int ,--房间状态编号
Fid int , --楼层编号
Mark varchar(225),--房间备注信息
)
--drop table RoomInfo
insert into RoomInfo values('A001',1,3,1,'暂无备注')
insert into RoomInfo values('A002',1,3,1,'暂无备注')
insert into RoomInfo values('A003',1,2,1,'暂无备注')
insert into RoomInfo values('A004',1,3,1,'暂无备注')
insert into RoomInfo values('A005',1,2,1,'暂无备注')
insert into RoomInfo values('A006',1,3,1,'暂无备注')
insert into RoomInfo values('A007',2,3,1,'暂无备注')
insert into RoomInfo values('A008',2,3,1,'暂无备注')
insert into RoomInfo values('A009',2,3,1,'暂无备注')
insert into RoomInfo values('A010',2,3,1,'暂无备注')
insert into RoomInfo values('A011',2,3,1,'暂无备注')
insert into RoomInfo values('A012',2,3,1,'暂无备注')
insert into RoomInfo values('B001',3,2,2,'暂无备注')
insert into RoomInfo values('B002',3,3,2,'暂无备注')
insert into RoomInfo values('B003',3,4,2,'暂无备注')
insert into RoomInfo values('B004',3,3,2,'暂无备注')
insert into RoomInfo values('B005',3,3,2,'暂无备注')
insert into RoomInfo values('B006',3,3,2,'暂无备注')
insert into RoomInfo values('B007',4,3,2,'暂无备注')
insert into RoomInfo values('B008',4,3,2,'暂无备注')
insert into RoomInfo values('B009',4,3,2,'暂无备注')
insert into RoomInfo values('B010',4,3,2,'暂无备注')
insert into RoomInfo values('B011',4,2,2,'暂无备注')
insert into RoomInfo values('B012',4,3,2,'暂无备注')
insert into RoomInfo values('C001',5,3,3,'暂无备注')
insert into RoomInfo values('C002',5,3,3,'暂无备注')
insert into RoomInfo values('C003',5,3,3,'暂无备注')
insert into RoomInfo values('C004',5,1,3,'暂无备注')
insert into RoomInfo values('C005',5,3,3,'暂无备注')
insert into RoomInfo values('C006',5,4,3,'暂无备注')
insert into RoomInfo values('C007',6,3,3,'暂无备注')
insert into RoomInfo values('C008',6,3,3,'暂无备注')
insert into RoomInfo values('C009',6,3,3,'暂无备注')
insert into RoomInfo values('C010',6,1,3,'暂无备注')
insert into RoomInfo values('C011',6,3,3,'暂无备注')
insert into RoomInfo values('C012',6,3,3,'暂无备注')

--select * from RoomInfo,RoomState,FloorInfo,RoomType where RoomState.Stateid=Roominfo.Rsid and RoomInfo.FId=FloorInfo.fid and RoomInfo.RTid=RoomType.Rtid and roomid=1
       
--select * from RoomInfo,RoomState,FloorInfo,RoomType where RoomState.Stateid=Roominfo.Rsid and RoomInfo.FId=FloorInfo.fid and RoomInfo.RTid=RoomType.Rtid--房间信息表

--select * from record,guestinfo,roominfo,guesttype,FloorInfo,roomtype where guestinfo.gid=record.gid and roominfo. roomid=record.roomid and record.roomid=1 and  guestinfo.gtid=guesttype.gtid and FloorInfo.fid=RoomInfo.fid and roomtype.rtid=roominfo.rtid and(rsid=2 or rsid = 1)

--------------------房间状态信息表-----------------------------
create table RoomState(
StateId int primary key identity(1,1) not null,--房间状态编号
StateName  varchar(20) not null
)
--drop table RoomState
insert into RoomState values('已预定')
insert into RoomState values('已入住')
insert into RoomState values('未入住')
insert into RoomState values('维修中')
insert into RoomState values('清扫中')

select * from RoomState --房间状态表

-----------------------房间类型表----------------------------
create table RoomType(
RTid int primary key identity(1,1),--房间类型编号
RTname varchar(50)  not null,--类型名称
RTprice money not null, --类型价格
AddBedPrice money not null,--加床价格
IsAddBed bit ,--是否允许加床
Remark varchar(255), --备注信息
)
--drop table RoomType
insert into RoomType values('普通单人间(220/天)',220,0,0,'暂无备注')
insert into RoomType values('豪华单人间(280/天)',280,0,0,'暂无备注')
insert into RoomType values('普通双人间(380/天)',380,0,0,'暂无备注')
insert into RoomType values('豪华双人间(480/天)',480,0,0,'暂无备注')
insert into RoomType values('贵宾套房(580/天)',580,120,1,'暂无备注')
insert into RoomType values('总统套房(1280/天)',1280,600,1,'暂无备注')

select * from RoomType  --房间信息表

select * from roomtype where rtid=1 

-----------------用户在线预约信息表-----------------------
create table UserInfo(
UId int primary key identity(1,1)not null, --顾客ID
Uname  varchar(10) not null, --用户姓名
Upwd varchar(30) not null, --用户密码
Tid  int  default 1, --用户类型
Sex char(5), --性别
Mobile varchar(30), --电话号码
Pid varchar(20) --身份证号码
)
--drop table UserInfo
insert into UserInfo values('birui','123',default,'男','13657168500','420984199310134430')
insert into UserInfo values('biqiang','123',default,'男','13657168500','420984199310134430')
insert into UserInfo values('biming','123',default,'男','13657168500','420984199310134430')

select * from UserInfo --用户在线预约信息表

create table ChargeCount(

date datetime,
Charge float
)
--select * from record,guestinfo,roominfo,guesttype,FloorInfo,roomtype where guestinfo.gid=record.gid and roominfo. roomid=record.roomid and record.roomid=1and  guestinfo.gtid=guesttype.gtid and FloorInfo.fid=RoomInfo.fid and roomtype.rtid=roominfo.rtid and(rsid=2 or rsid = 1) and facttime='暂未离开'
insert into chargecount values('2015-4-2 10:11:12',200)
insert into chargecount values('2015-3-2 10:11:12',200)
insert into chargecount values('2015-4-27 10:11:12',700)
insert into chargecount values('2015-4-28 10:11:12',380)

--select * from chargecount
--drop table chargecount
--insert into chargecount values('2015-4-2 10:11:12',200)
--select datediff(day,'2015-4-13 10:10:32',getdate()) 'daynum'
--select sum(charge) from chargecount where (select datediff(day,date,getdate()))=0


create table Trans(
transid int identity(1,1) primary key,
reason varchar(50),
addmoney int
)
--drop table trans
insert into trans values('房间损坏维修',0)
insert into trans values('客房升级',20)
insert into trans values('客房降级',20)
insert into trans values('其他因素',20)
insert into trans values('噪音及其他干扰',0)

select * from trans



-----------------------------------------------------------
select * from GuestInfo --顾客信息表
select * from GuestType --顾客类型表
select * from Record --入住信息记录表
select * from FloorInfo --楼层信息表
select * from OPInfo --操作员信息表
select * from RoomInfo --房间信息表
select * from RoomState --房间状态表
select * from RoomType  --房间信息表
select * from UserInfo --用户在线预约信息表