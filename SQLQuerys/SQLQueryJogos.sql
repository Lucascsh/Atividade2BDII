-- Utilidades:
--select * from sys.databases -- lista base de dados
--select * from sys.sql_logins -- lista usuarios
--select * from sys.sysprocesses where loginame = 'Juca' -- acompanhar o usuario

--grant select on disciplinas to username -- permiss�o para o usu�rio consultar disciplinas
--revoke select on disciplinas to username
--deny select on disciplinas to username

-- Cria��o da base de dados
--create database db_jogos;
go

-- Cria��o do login super, ser� usado para criar o usu�rio, poder� ver todos os bancos e suas tabelas
create login super with password = '123456',
	default_database = db_jogos, check_expiration = off,
	check_policy = off
	go

-- Cria��o do usu�rio a partir dos login
create user Dejair for login super;
go

-- Cria��o das tabela
create table jogos
(
	id integer primary key identity,
	nome varchar(100)
);
go

create table desenvolvedoras
(
	id integer primary key identity,
	nome varchar(100)
);
go
