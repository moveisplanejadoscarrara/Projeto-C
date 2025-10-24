create database moveiscarrara
go

use moveiscarrara
go

create table pessoas
(
	codigo			int				not null identity,
	nome			varchar(50)		not null,
	tipo_pessoa		varchar(20)		not null,
	documento		varchar(14)		not null,
	tipo_documento	varchar(20)		not null,
	email			varchar(100)	not null,
	telefone		varchar(20)		not null,
	cep				varchar(10)		not null,
	logradouro		varchar(50)		not null,
	nr				varchar(5)		not null,
	cidade			varchar(100)	not null,
	bairro			varchar(100)	not null


	-- Restrições --
	constraint pk_pessoas					primary key(codigo),
	constraint uq_pessoas_documento			unique(documento),
	constraint ck_pessoas_tipo_pessoa		check (tipo_pessoa in ('cliente', 'usuario', 'fornecedor')),
	constraint ck_pessoas_tipo_documento	check (tipo_documento in ('CPF', 'CNPJ')),

)
go

create table clientes
(
	pessoa_codigo	int not null,

	-- Restrições --
	constraint pk_clientes primary key(pessoa_codigo),
	constraint fk_clientes foreign key(pessoa_codigo) references pessoas,
)
go

create table fornecedores
(
	pessoa_codigo	int not null,

	-- Restrições --
	constraint pk_fornecedores primary key(pessoa_codigo),
	constraint fk_fornecedores foreign key(pessoa_codigo) references pessoas,
)
go

create table usuarios
(
	pessoa_codigo	int not null,
	usuario_nome	varchar(50)		not null,
	usuario_senha	varchar(50)		not null


	-- Restrições --
	constraint pk_usuarios primary key(pessoa_codigo),
	constraint fk_usuarios foreign key(pessoa_codigo) references pessoas,
	constraint uq_usuarios_usuario_nome unique(usuario_nome)
)
go

select * from pessoas
select * from clientes
select * from fornecedores
select * from usuarios

insert into pessoas values ('Débora','cliente', '1010', 'CPF', 'debora@gmail.com', '3232-3232', '15040-120', 'Rua Teste do Banco', '420', 'Rio Preto', 'Centro')
insert into pessoas values ('Laura','fornecedor', '5050', 'CNPJ', 'laura@gmail.com', '4141-4141', '15040-689', 'Rua Comercio do Centro', '8855', 'Rio Preto', 'Centro')
insert into pessoas values ('Caio','usuario', '9898', 'CPF', 'caio@gmail.com', '7878-7878', '15040-540', 'Rua Peppa Pig', '7070', 'Rio Preto', 'Eldorado')

insert into clientes values (1)

insert into fornecedores values (2)

insert into usuarios values (3, 'caiofraporti', 'senha123')

