
create database HotelManage
go
use HotelManage
go

-----------------------�˿���Ϣ��---------------------
create table GuestInfo(
Gid int primary key identity(1,1)not null, --�˿�ID
Gname  varchar(10) not null, --�˿�����
GTid  int  not null, --�˿�����
Sex char(5), --�Ա�
Mobile varchar(30), --�绰����
ChargeSum money ,--�����ܽ��
Pid varchar(20) --���֤����
)
--drop table GuestInfo
insert into GuestInfo values('����',1,'��','13657168500',1200,'420984199310134430')
insert into GuestInfo values('����',2,'��','13657168500',800,'420984199310134430')
insert into GuestInfo values('����',3,'Ů','13657168500',760,'420984199310134430')
insert into GuestInfo values('����',4,'Ů','13657168500',2400,'420984199310134430')

select * from GuestInfo --�˿���Ϣ��
--select * from GuestInfo,GuestType where GuestType.GTid=GuestInfo.GTid 


--------------------�˿�����------------------------
create table GuestType(
GTid  int primary key identity(1,1) not null, --���ID
Tname varchar(10) not null, --�������
Trate float not null,--�ۿ�
)
--drop table GuestType
insert into GuestType values('��ͨ��Ա',1)
insert into GuestType values('�߼���Ա',0.95)
insert into GuestType values('�ƽ��Ա',0.90)
insert into GuestType values('��ʯ��Ա',0.85)

select * from GuestType --�˿����ͱ�





-------------------��ס��Ϣ��¼��---------------------
create table Record(
REid int primary key identity(1,1) not null, --��ס���
Gid int not null, --�˿ͱ��
RoomId int not null ,--������
InTime datetime ,--��סʱ��
OutTime datetime,--�뿪ʱ��
FactTime varchar(50) default '��δ�뿪',--ʵ���뿪ʱ��
daynum int,--��ס����
Charge int default 0--����Ѻ��

)
update record set inttime='{0}',outtime='{1}',daynum=daynum+{2},charge={3} where roomid={4} and facttime='��δ�뿪'
--select * from Record,guestinfo where record.gid=guestinfo.gid
--drop table Record
insert into Record values(1,3,'2014-10-13 10:10:32','2015-5-8 10:10:32',default,5,2200)
insert into Record values(2,5,'2015-4-17 10:10:32','2015-5-5 10:10:32',default,5,2200)
insert into Record values(3,13,'2015-4-13 10:10:32','2015-5-1 10:10:32',default,5,5600)
insert into Record values(4,23,'2015-4-8 10:10:32','2015-6-1 10:10:32',default,5,2200)


--update record set facttime='��δ�뿪',daynum=1,charge=100 where reid = 1

--select datediff(day,'2015-4-13 10:10:32',getdate()) 'daynum'

--select * ,(outtime-Intime)'day'from record,roominfo where record.roomid=roominfo.roomid order by day asc


select * from Record --��ס��Ϣ��¼��





------------------------¥����Ϣ��------------------------
create table FloorInfo(
Fid int primary key identity(1,1) not null, --¥��ID
Fname varchar(20) --¥������
)
--drop table FloorInfo
insert into FloorInfo values('A��')
insert into FloorInfo values('B��')
insert into FloorInfo values('C��')



select * from FloorInfo --¥����Ϣ��




------------------------����Ա��-------------------------
create table OPInfo(
OId int primary key identity(1,1) not null,--����ԱID
OName varchar(20) not null,--����Ա����
Pwd varchar(20) not null--����Ա����
)
--drop table OPInfo
insert into OPInfo values('huangkuan','123')
insert into OPInfo values('akuan','123')

select * from OPInfo --����Ա��Ϣ��


----------------------������Ϣ��--------------------------
create table RoomInfo(
RoomId int primary key identity(1,1) not null, --������
Number varchar(20) not null ,--����� 
RTid int ,--��������ID
RSid int ,--����״̬���
Fid int , --¥����
Mark varchar(225),--���䱸ע��Ϣ
)
--drop table RoomInfo
insert into RoomInfo values('A001',1,3,1,'���ޱ�ע')
insert into RoomInfo values('A002',1,3,1,'���ޱ�ע')
insert into RoomInfo values('A003',1,2,1,'���ޱ�ע')
insert into RoomInfo values('A004',1,3,1,'���ޱ�ע')
insert into RoomInfo values('A005',1,2,1,'���ޱ�ע')
insert into RoomInfo values('A006',1,3,1,'���ޱ�ע')
insert into RoomInfo values('A007',2,3,1,'���ޱ�ע')
insert into RoomInfo values('A008',2,3,1,'���ޱ�ע')
insert into RoomInfo values('A009',2,3,1,'���ޱ�ע')
insert into RoomInfo values('A010',2,3,1,'���ޱ�ע')
insert into RoomInfo values('A011',2,3,1,'���ޱ�ע')
insert into RoomInfo values('A012',2,3,1,'���ޱ�ע')
insert into RoomInfo values('B001',3,2,2,'���ޱ�ע')
insert into RoomInfo values('B002',3,3,2,'���ޱ�ע')
insert into RoomInfo values('B003',3,4,2,'���ޱ�ע')
insert into RoomInfo values('B004',3,3,2,'���ޱ�ע')
insert into RoomInfo values('B005',3,3,2,'���ޱ�ע')
insert into RoomInfo values('B006',3,3,2,'���ޱ�ע')
insert into RoomInfo values('B007',4,3,2,'���ޱ�ע')
insert into RoomInfo values('B008',4,3,2,'���ޱ�ע')
insert into RoomInfo values('B009',4,3,2,'���ޱ�ע')
insert into RoomInfo values('B010',4,3,2,'���ޱ�ע')
insert into RoomInfo values('B011',4,2,2,'���ޱ�ע')
insert into RoomInfo values('B012',4,3,2,'���ޱ�ע')
insert into RoomInfo values('C001',5,3,3,'���ޱ�ע')
insert into RoomInfo values('C002',5,3,3,'���ޱ�ע')
insert into RoomInfo values('C003',5,3,3,'���ޱ�ע')
insert into RoomInfo values('C004',5,1,3,'���ޱ�ע')
insert into RoomInfo values('C005',5,3,3,'���ޱ�ע')
insert into RoomInfo values('C006',5,4,3,'���ޱ�ע')
insert into RoomInfo values('C007',6,3,3,'���ޱ�ע')
insert into RoomInfo values('C008',6,3,3,'���ޱ�ע')
insert into RoomInfo values('C009',6,3,3,'���ޱ�ע')
insert into RoomInfo values('C010',6,1,3,'���ޱ�ע')
insert into RoomInfo values('C011',6,3,3,'���ޱ�ע')
insert into RoomInfo values('C012',6,3,3,'���ޱ�ע')

--select * from RoomInfo,RoomState,FloorInfo,RoomType where RoomState.Stateid=Roominfo.Rsid and RoomInfo.FId=FloorInfo.fid and RoomInfo.RTid=RoomType.Rtid and roomid=1
       
--select * from RoomInfo,RoomState,FloorInfo,RoomType where RoomState.Stateid=Roominfo.Rsid and RoomInfo.FId=FloorInfo.fid and RoomInfo.RTid=RoomType.Rtid--������Ϣ��

--select * from record,guestinfo,roominfo,guesttype,FloorInfo,roomtype where guestinfo.gid=record.gid and roominfo. roomid=record.roomid and record.roomid=1 and  guestinfo.gtid=guesttype.gtid and FloorInfo.fid=RoomInfo.fid and roomtype.rtid=roominfo.rtid and(rsid=2 or rsid = 1)

--------------------����״̬��Ϣ��-----------------------------
create table RoomState(
StateId int primary key identity(1,1) not null,--����״̬���
StateName  varchar(20) not null
)
--drop table RoomState
insert into RoomState values('��Ԥ��')
insert into RoomState values('����ס')
insert into RoomState values('δ��ס')
insert into RoomState values('ά����')
insert into RoomState values('��ɨ��')

select * from RoomState --����״̬��

-----------------------�������ͱ�----------------------------
create table RoomType(
RTid int primary key identity(1,1),--�������ͱ��
RTname varchar(50)  not null,--��������
RTprice money not null, --���ͼ۸�
AddBedPrice money not null,--�Ӵ��۸�
IsAddBed bit ,--�Ƿ�����Ӵ�
Remark varchar(255), --��ע��Ϣ
)
--drop table RoomType
insert into RoomType values('��ͨ���˼�(220/��)',220,0,0,'���ޱ�ע')
insert into RoomType values('�������˼�(280/��)',280,0,0,'���ޱ�ע')
insert into RoomType values('��ͨ˫�˼�(380/��)',380,0,0,'���ޱ�ע')
insert into RoomType values('����˫�˼�(480/��)',480,0,0,'���ޱ�ע')
insert into RoomType values('����׷�(580/��)',580,120,1,'���ޱ�ע')
insert into RoomType values('��ͳ�׷�(1280/��)',1280,600,1,'���ޱ�ע')

select * from RoomType  --������Ϣ��

select * from roomtype where rtid=1 

-----------------�û�����ԤԼ��Ϣ��-----------------------
create table UserInfo(
UId int primary key identity(1,1)not null, --�˿�ID
Uname  varchar(10) not null, --�û�����
Upwd varchar(30) not null, --�û�����
Tid  int  default 1, --�û�����
Sex char(5), --�Ա�
Mobile varchar(30), --�绰����
Pid varchar(20) --���֤����
)
--drop table UserInfo
insert into UserInfo values('birui','123',default,'��','13657168500','420984199310134430')
insert into UserInfo values('biqiang','123',default,'��','13657168500','420984199310134430')
insert into UserInfo values('biming','123',default,'��','13657168500','420984199310134430')

select * from UserInfo --�û�����ԤԼ��Ϣ��

create table ChargeCount(

date datetime,
Charge float
)
--select * from record,guestinfo,roominfo,guesttype,FloorInfo,roomtype where guestinfo.gid=record.gid and roominfo. roomid=record.roomid and record.roomid=1and  guestinfo.gtid=guesttype.gtid and FloorInfo.fid=RoomInfo.fid and roomtype.rtid=roominfo.rtid and(rsid=2 or rsid = 1) and facttime='��δ�뿪'
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
insert into trans values('������ά��',0)
insert into trans values('�ͷ�����',20)
insert into trans values('�ͷ�����',20)
insert into trans values('��������',20)
insert into trans values('��������������',0)

select * from trans



-----------------------------------------------------------
select * from GuestInfo --�˿���Ϣ��
select * from GuestType --�˿����ͱ�
select * from Record --��ס��Ϣ��¼��
select * from FloorInfo --¥����Ϣ��
select * from OPInfo --����Ա��Ϣ��
select * from RoomInfo --������Ϣ��
select * from RoomState --����״̬��
select * from RoomType  --������Ϣ��
select * from UserInfo --�û�����ԤԼ��Ϣ��