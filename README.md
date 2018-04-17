# DotNetDAL
dotnet core 分库dal  转自携程dal https://github.com/ctripcorp/dal/tree/master/Arch.Data

配置文件在 https://github.com/wangchengqun/DotNetDAL/blob/master/Demo/bin/Debug/netcoreapp2.0/conf.json 

创建测试数据库
CREATE DATABASE Test1
go
use Test1
CREATE TABLE test0(
	Id int NOT NULL,
	Name nvarchar(50) NULL,
	Address nvarchar(50) NULL
) 

CREATE DATABASE Test2
go
use Test2
CREATE TABLE test0(
	Id int NOT NULL,
	Name nvarchar(50) NULL,
	Address nvarchar(50) NULL
) 





