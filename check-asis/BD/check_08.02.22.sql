USE [master]
GO
/****** Object:  Database [check]    Script Date: 8/2/2022 11:50:59 ******/
CREATE DATABASE [check]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'check', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\check.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'check_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\check_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [check] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [check].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [check] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [check] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [check] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [check] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [check] SET ARITHABORT OFF 
GO
ALTER DATABASE [check] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [check] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [check] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [check] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [check] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [check] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [check] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [check] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [check] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [check] SET  DISABLE_BROKER 
GO
ALTER DATABASE [check] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [check] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [check] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [check] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [check] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [check] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [check] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [check] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [check] SET  MULTI_USER 
GO
ALTER DATABASE [check] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [check] SET DB_CHAINING OFF 
GO
ALTER DATABASE [check] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [check] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [check] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [check] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [check] SET QUERY_STORE = OFF
GO
USE [check]
GO
/****** Object:  Table [dbo].[Asistencias]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencias](
	[Id_asistencia] [int] IDENTITY(1,1) NOT NULL,
	[Id_personal] [int] NULL,
	[Fecha_entrada] [datetime] NULL,
	[Fecha_salida] [datetime] NULL,
	[Estado] [varchar](50) NULL,
	[Horas] [numeric](18, 2) NULL,
	[Observacion] [varchar](max) NULL,
 CONSTRAINT [PK_ASISTENCIAS] PRIMARY KEY CLUSTERED 
(
	[Id_asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](max) NULL,
	[SueldoPorHora] [varchar](max) NULL,
 CONSTRAINT [PK_Cargos] PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulos](
	[IdModulo] [int] IDENTITY(1,1) NOT NULL,
	[Modulo] [varchar](max) NULL,
 CONSTRAINT [PK_Modulos] PRIMARY KEY CLUSTERED 
(
	[IdModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[idPermiso] [int] IDENTITY(1,1) NOT NULL,
	[idModulo] [int] NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[idPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[id_personal] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](max) NULL,
	[Identificacion] [varchar](max) NULL,
	[Pais] [varchar](max) NULL,
	[id_cargo] [int] NULL,
	[SueldoPorHora] [varchar](max) NULL,
	[Estado] [varchar](max) NULL,
	[codigo] [varchar](max) NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[id_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreApellidos] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Icono] [image] NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asistencias]  WITH CHECK ADD  CONSTRAINT [FK_Asistencias_Personal] FOREIGN KEY([Id_personal])
REFERENCES [dbo].[Personal] ([id_personal])
GO
ALTER TABLE [dbo].[Asistencias] CHECK CONSTRAINT [FK_Asistencias_Personal]
GO
ALTER TABLE [dbo].[Modulos]  WITH CHECK ADD  CONSTRAINT [FK_Modulos_Permisos] FOREIGN KEY([IdModulo])
REFERENCES [dbo].[Permisos] ([idPermiso])
GO
ALTER TABLE [dbo].[Modulos] CHECK CONSTRAINT [FK_Modulos_Permisos]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Usuarios]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Cargos] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[Cargos] ([id_cargo])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_Cargos]
GO
/****** Object:  StoredProcedure [dbo].[buscarAsistenciasId]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscarAsistenciasId]
@Idpersonal int
as
select * from Asistencias
where Id_personal=@Idpersonal and ASISTENCIAS.Estado='ENTRADA'
GO
/****** Object:  StoredProcedure [dbo].[buscarCargos]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarCargos]
@buscador varchar(50)
as
select Id_cargo,Cargo,SueldoPorHora as Sueldo  from Cargos
where Cargo lIKE '%' + @buscador +'%'
GO
/****** Object:  StoredProcedure [dbo].[BuscarPersonal]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscarPersonal]
@Desde int,
@Hasta int,
@Buscador varchar(50)
as
Set Nocount On;
Select 
id_personal,Nombres,Identificacion,SueldoPorHora,Cargo,id_cargo,Estado,codigo,Pais
from
(Select id_personal ,Nombres,Identificacion,Personal.SueldoPorHora,Cargos.Cargo,Personal.id_cargo,Estado,codigo,Pais,
Row_Number() Over(Order by id_personal) 'Numero_de_fila'
from Personal
inner join Cargos on Cargos.id_cargo=Personal.id_cargo ) as Paginado
Where (Paginado.Numero_de_fila >=@Desde) and (Paginado.Numero_de_fila<=@Hasta)
and (Nombres + Identificacion Like '%' + @Buscador + '%')
GO
/****** Object:  StoredProcedure [dbo].[BuscarPersonalIdentidad]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarPersonalIdentidad]
@Buscador varchar(50)
as
select * from Personal 
where Identificacion=@Buscador

GO
/****** Object:  StoredProcedure [dbo].[ConfirmarSalida]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ConfirmarSalida]
@Id_personal as int,
@Fecha_salida DATETIME,
@Horas NUMERIC(18,2)
as
Update ASISTENCIAS set
Fecha_salida =@Fecha_salida ,
Horas =@Horas ,
Estado='SALIDA'
where Id_personal   =@Id_personal and Estado='ENTRADA'
GO
/****** Object:  StoredProcedure [dbo].[editar_Cargo]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[editar_Cargo]
@id int,
@Cargo varchar(max)
,@Sueldo as numeric(18,2)
as
if EXISTS (SELECT Cargo FROM Cargos  where Cargo = @Cargo and Id_cargo<>@id  )
RAISERROR ('YA EXISTE UN CARGO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
update  Cargos set Cargo=@Cargo, SueldoPorHora=@Sueldo
where Id_cargo=@id
GO
/****** Object:  StoredProcedure [dbo].[editarPersonal]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarPersonal]
@Id_personal int,
@Nombres as varchar(max),
@Identificacion varchar(max),
@Pais varchar(max),
@Id_cargo int,
@Sueldo_por_hora numeric(18,2)
as
if Exists(Select Identificacion from Personal where Identificacion=@Identificacion and Id_personal <>@Id_personal)
Raiserror('Ya existe un registro con esta Identificacion',16,1)
else
Update Personal set
Nombres=@Nombres ,Identificacion=@Identificacion,Pais=@Pais,Id_cargo =@Id_cargo ,SueldoPorHora =@Sueldo_por_hora 
where Id_personal=@Id_personal
GO
/****** Object:  StoredProcedure [dbo].[eliminarPersonal]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarPersonal]
@Idpersonal int
as
Update Personal set Estado ='ELIMINADO'
where Id_personal = @Idpersonal 
GO
/****** Object:  StoredProcedure [dbo].[Insertar_ASISTENCIAS]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_ASISTENCIAS]
   @Id_personal INT,
   @Fecha_entrada DATETIME,
   @Fecha_salida DATETIME,
   @Estado VARCHAR(50),
    @Horas numeric(18,2),
	@Observacion varchar(max)
	as
	insert into Asistencias
	Values(@Id_personal,
	@Fecha_entrada,
	@Fecha_salida,
	@Estado,
	@Horas,
	@Observacion)

GO
/****** Object:  StoredProcedure [dbo].[insertar_Cargo]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Cargo]
@Cargo varchar(max),
@SueldoPorHora numeric(18,2)
as
if EXISTS (SELECT Cargo FROM Cargos  where Cargo = @Cargo  )
RAISERROR ('YA EXISTE UN CARGO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
insert into Cargos  values (@Cargo, @SueldoPorHora)
GO
/****** Object:  StoredProcedure [dbo].[insertar_Modulos]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[insertar_Modulos]
@Modulo As varchar(MAX)
As
INSERT INTO Modulos
Values (
@Modulo)
GO
/****** Object:  StoredProcedure [dbo].[insertar_Permisos]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[insertar_Permisos]
@IdModulo As int,
@IdUsuario As int
As
INSERT INTO Permisos
Values (
@IdModulo,
@IdUsuario)
GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_usuario]
@nombres varchar(50),
@Login varchar(50),
@Password varchar(50)
,@Icono image,
@Estado varchar(50)
as 
if EXISTS(SELECT Login FROM Usuarios where Login  = @login  )
RAISERROR ('YA EXISTE UN REGISTRO CON ESE USUARIO, POR FAVOR INGRESE DE NUEVO', 16,1)
else
insert into Usuarios 
values (@nombres, @Login, @Password ,@Icono ,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[InsertarPersonal]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarPersonal]
@Nombres varchar(max),
@Identificacion varchar(max),
@Pais varchar(max),
@Id_cargo int,
@SueldoPorHora numeric(18,2)
as
declare @Estado varchar(max)
declare @codigo varchar(max)
declare @Id_personal int
set @Estado='ACTIVO'
set @codigo='-'
if Exists(select Identificacion from Personal where Identificacion=@Identificacion)
Raiserror('Ya existe un registro con esta Identificacion',16,1)
else
Insert into Personal 
values(@Nombres ,
@Identificacion,
@Pais ,
@Id_cargo ,
@SueldoPorHora ,
@Estado ,
@codigo )
Select @Id_personal=scope_identity()
Update Personal set codigo = @Id_personal where Id_personal=@Id_personal
GO
/****** Object:  StoredProcedure [dbo].[mostrar_Permisos]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Permisos]
@idusuario int
as
select Permisos.IdModulo , Modulos.Modulo  from Permisos inner join Modulos on Modulos.IdModulo=Permisos.IdModulo 
where IdUsuario=@idusuario
GO
/****** Object:  StoredProcedure [dbo].[mostrarPersonal]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarPersonal]
@Desde int,
@Hasta int
as
Set Nocount On;
Select 
Id_personal,Nombres,Identificacion,SueldoPorHora,Cargo,Id_cargo,Estado,codigo,Pais
from
(Select Id_personal ,Nombres,Identificacion,Personal.SueldoPorHora,Cargos.Cargo,Personal.Id_cargo,Estado,codigo,Pais,
Row_Number() Over(Order by Id_personal) 'Numero_de_fila'
from Personal
inner join Cargos on Cargos.Id_cargo=Personal.Id_cargo ) as Paginado
Where (Paginado.Numero_de_fila >=@Desde) and (Paginado.Numero_de_fila<=@Hasta)
GO
/****** Object:  StoredProcedure [dbo].[ObtenerIdUsuario]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ObtenerIdUsuario]
@Login varchar(50)
as
select idUsuario from Usuarios 
where Login=@Login 
GO
/****** Object:  StoredProcedure [dbo].[restaurar_personal]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[restaurar_personal]
@Idpersonal int
as
update Personal set Estado = 'ACTIVO'
where Id_personal=@Idpersonal
GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 8/2/2022 11:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[validar_usuario]
@password varchar(50),
@login varchar(50)
as
select * from Usuarios 
where Password = @password and Login =@login and Estado ='ACTIVO'
GO
USE [master]
GO
ALTER DATABASE [check] SET  READ_WRITE 
GO
