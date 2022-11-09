-- Utilidades:
--select * from sys.databases -- lista base de dados
--select * from sys.sql_logins -- lista usuarios
--select * from sys.sysprocesses where loginame = 'Juca' -- acompanhar o usuario

--grant select on disciplinas to username -- permissão para o usuário consultar disciplinas
--revoke select on disciplinas to username
--deny select on disciplinas to username

-- Criação da base de dados
--create database db_livros;
go

-- Criação das tabela
create table livros
(
	id integer primary key identity,
	nome varchar(100)
);
go

create table editoras
(
	id integer primary key identity,
	nome varchar(100)
);
go