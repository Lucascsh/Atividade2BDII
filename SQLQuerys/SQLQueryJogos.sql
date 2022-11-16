-- Utilidades:
--select * from sys.databases -- lista base de dados
--select * from sys.sql_logins -- lista usuarios
--select * from sys.sysprocesses where loginame = 'Juca' -- acompanhar o usuario

--grant select on disciplinas to username -- permissão para o usuário consultar disciplinas
--revoke select on disciplinas to username
--deny select on disciplinas to username

-- Criação da base de dados
--create database db_jogos;
go

-- Criação do login super, será usado para criar o usuário, poderá ver todos os bancos e suas tabelas
create login super with password = '123456',
	default_database = master, check_expiration = off,
	check_policy = off
	go

-- Criação do usuário a partir dos login
create user Dejair for login super;
go

-- Criação das tabela
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
