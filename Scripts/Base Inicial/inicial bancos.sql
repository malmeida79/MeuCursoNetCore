USE [Banco]
GO
ALTER TABLE [dbo].[ContaInvestimento] DROP CONSTRAINT [FK_ContaInvestimento_TipoConta]
GO
ALTER TABLE [dbo].[ContaInvestimento] DROP CONSTRAINT [FK_ContaInvestimento_Clientes]
GO
ALTER TABLE [dbo].[ContaInvestimento] DROP CONSTRAINT [FK_ContaInvestimento_Bancos]
GO
ALTER TABLE [dbo].[ContaCorrente] DROP CONSTRAINT [FK_ContaCorrente_TipoConta]
GO
ALTER TABLE [dbo].[ContaCorrente] DROP CONSTRAINT [FK_ContaCorrente_Clientes]
GO
ALTER TABLE [dbo].[ContaCorrente] DROP CONSTRAINT [FK_ContaCorrente_Bancos]
GO
ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_Clientes_Bancos]
GO
/****** Object:  Table [dbo].[ContaInvestimento]    Script Date: 03/05/2021 17:02:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContaInvestimento]') AND type in (N'U'))
DROP TABLE [dbo].[ContaInvestimento]
GO
/****** Object:  View [dbo].[VW_ListaClienteConta]    Script Date: 03/05/2021 17:02:50 ******/
DROP VIEW [dbo].[VW_ListaClienteConta]
GO
/****** Object:  Table [dbo].[Bancos]    Script Date: 03/05/2021 17:02:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bancos]') AND type in (N'U'))
DROP TABLE [dbo].[Bancos]
GO
/****** Object:  Table [dbo].[TipoConta]    Script Date: 03/05/2021 17:02:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoConta]') AND type in (N'U'))
DROP TABLE [dbo].[TipoConta]
GO
/****** Object:  Table [dbo].[ContaCorrente]    Script Date: 03/05/2021 17:02:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContaCorrente]') AND type in (N'U'))
DROP TABLE [dbo].[ContaCorrente]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 03/05/2021 17:02:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type in (N'U'))
DROP TABLE [dbo].[Clientes]
GO
USE [master]
GO
/****** Object:  Database [Banco]    Script Date: 03/05/2021 17:02:50 ******/
DROP DATABASE [Banco]
GO
/****** Object:  Database [Banco]    Script Date: 03/05/2021 17:02:50 ******/
CREATE DATABASE [Banco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Banco', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Banco.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Banco_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Banco_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Banco] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Banco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Banco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Banco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Banco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Banco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Banco] SET ARITHABORT OFF 
GO
ALTER DATABASE [Banco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Banco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Banco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Banco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Banco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Banco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Banco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Banco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Banco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Banco] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Banco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Banco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Banco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Banco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Banco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Banco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Banco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Banco] SET RECOVERY FULL 
GO
ALTER DATABASE [Banco] SET  MULTI_USER 
GO
ALTER DATABASE [Banco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Banco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Banco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Banco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Banco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Banco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Banco', N'ON'
GO
ALTER DATABASE [Banco] SET QUERY_STORE = OFF
GO
USE [Banco]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 03/05/2021 17:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[CodCliente] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](300) NOT NULL,
	[CodBanco] [int] NULL,
	[DataInclusao] [datetime] NOT NULL,
	[DataAlteracao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContaCorrente]    Script Date: 03/05/2021 17:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContaCorrente](
	[CodContaCorrente] [int] IDENTITY(1,1) NOT NULL,
	[NumeroConta] [varchar](30) NOT NULL,
	[NumeroAgencia] [varchar](10) NOT NULL,
	[Saldo] [decimal](18, 4) NOT NULL,
	[Limite] [decimal](18, 4) NOT NULL,
	[CodTipoConta] [int] NOT NULL,
	[DataAbertura] [datetime] NULL,
	[DataInclusao] [datetime] NULL,
	[DataAlteracao] [datetime] NULL,
	[CodCliente] [int] NOT NULL,
	[CodBanco] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodContaCorrente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoConta]    Script Date: 03/05/2021 17:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoConta](
	[CodTipoConta] [int] IDENTITY(1,1) NOT NULL,
	[NomeTipoConta] [varchar](300) NOT NULL,
	[DataInclusao] [datetime] NOT NULL,
	[DataAlteracao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodTipoConta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bancos]    Script Date: 03/05/2021 17:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bancos](
	[CodBanco] [int] IDENTITY(1,1) NOT NULL,
	[NomeBanco] [varchar](300) NOT NULL,
	[NumeroBanco] [nchar](10) NOT NULL,
	[DataInclusao] [datetime] NOT NULL,
	[DataAlteracao] [datetime] NULL,
 CONSTRAINT [PK__Bancos__57E423B8DFB60D21] PRIMARY KEY CLUSTERED 
(
	[CodBanco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ListaClienteConta]    Script Date: 03/05/2021 17:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VW_ListaClienteConta] AS
 select 
	cc.CodBanco, cc.Saldo,
	cc.Limite, c.NomeCliente,
	cc.DataAbertura, b.NomeBanco, 
	tc.NomeTipoConta
from 
	ContaCorrente cc 
	inner join Clientes c on cc.CodCliente = c.CodCliente
	inner join bancos b on c.CodBanco = b.CodBanco
	inner join TipoConta tc on tc.CodTipoConta = cc.CodTipoConta
GO
/****** Object:  Table [dbo].[ContaInvestimento]    Script Date: 03/05/2021 17:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContaInvestimento](
	[CodContaInvestimento] [int] IDENTITY(1,1) NOT NULL,
	[NumeroConta] [varchar](30) NOT NULL,
	[NumeroAgencia] [varchar](10) NOT NULL,
	[Saldo] [decimal](18, 4) NOT NULL,
	[Limite] [decimal](18, 4) NOT NULL,
	[CodTipoConta] [int] NOT NULL,
	[DataAbertura] [datetime] NULL,
	[Chave] [varchar](30) NOT NULL,
	[Taxa] [varchar](10) NOT NULL,
	[DataInclusao] [datetime] NULL,
	[DataAlteracao] [datetime] NULL,
	[CodCliente] [int] NOT NULL,
	[CodBanco] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodContaInvestimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bancos] ON 

INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (1, N'Acesso Soluções de Pagamento S.A.', N'332       ', CAST(N'2021-04-29T20:20:26.967' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (2, N'ADVANCED CORRETORA DE CÂMBIO LTDA', N'117       ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (3, N'AGK CORRETORA DE CAMBIO S.A.', N'272       ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (4, N'AMAGGI S.A. - CRÉDITO, FINANCIAMENTO E INVESTIMENTO', N'349       ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (5, N'ATIVA INVESTIMENTOS S.A. CORRETORA DE TÍTULOS, CÂMBIO E VALORES', N'188       ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (6, N'Avista S.A. Crédito, Financiamento e Investimento', N'280       ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (7, N'B&T CORRETORA DE CAMBIO LTDA.', N'80        ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (8, N'Banco A.J.Renner S.A.', N'654       ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (9, N'Banco ABC Brasil S.A.', N'246       ', CAST(N'2021-04-29T20:20:26.970' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (10, N'Banco ABN AMRO S.A.', N'75        ', CAST(N'2021-04-29T20:20:26.973' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (11, N'Banco Agibank S.A.', N'121       ', CAST(N'2021-04-29T20:20:26.973' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (12, N'Banco Alfa S.A.', N'25        ', CAST(N'2021-04-29T20:20:26.973' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (13, N'Banco Andbank (Brasil) S.A.', N'65        ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (14, N'Banco Arbi S.A.', N'213       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (15, N'Banco B3 S.A.', N'96        ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (16, N'Banco BANDEPE S.A.', N'24        ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (17, N'Banco Bari de Investimentos e Financiamentos S/A', N'330       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (18, N'Banco BMG S.A.', N'318       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (19, N'Banco BNP Paribas Brasil S.A.', N'752       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (20, N'Banco BOCOM BBM S.A.', N'107       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (21, N'Banco Bradescard S.A.', N'63        ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (22, N'Banco Bradesco BBI S.A.', N'36        ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (23, N'Banco Bradesco BERJ S.A.', N'122       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (24, N'Banco Bradesco Financiamentos S.A.', N'394       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (25, N'Banco Bradesco S.A.', N'237       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (26, N'Banco BS2 S.A.', N'218       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (27, N'Banco BTG Pactual S.A.', N'208       ', CAST(N'2021-04-29T20:20:26.977' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (28, N'Banco C6 S.A.', N'336       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (29, N'Banco Caixa Geral - Brasil S.A.', N'473       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (30, N'Banco Capital S.A.', N'412       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (31, N'Banco Cargill S.A.', N'40        ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (32, N'Banco Cetelem S.A.', N'739       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (33, N'Banco Cifra S.A.', N'233       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (34, N'Banco Citibank S.A.', N'745       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (35, N'Banco Clássico S.A.', N'241       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (36, N'Banco Cooperativo do Brasil S.A. - BANCOOB', N'756       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (37, N'Banco Cooperativo Sicredi S.A.', N'748       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (38, N'Banco Credit Agricole Brasil S.A.', N'222       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (39, N'Banco Credit Suisse (Brasil) S.A.', N'505       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (40, N'Banco Crefisa S.A.', N'69        ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (41, N'Banco Cédula S.A.', N'266       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (42, N'Banco da Amazônia S.A.', N'3         ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (43, N'Banco da China Brasil S.A.', N'83        ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (44, N'Banco Daycoval S.A.', N'707       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (45, N'Banco de La Nacion Argentina', N'300       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (46, N'Banco de La Provincia de Buenos Aires', N'495       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (47, N'Banco Digio S.A.', N'335       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (48, N'Banco do Brasil S.A.', N'1         ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (49, N'Banco do Estado de Sergipe S.A.', N'47        ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (50, N'Banco do Estado do Pará S.A.', N'37        ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (51, N'Banco do Estado do Rio Grande do Sul S.A.', N'41        ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (52, N'Banco do Nordeste do Brasil S.A.', N'4         ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (53, N'Banco Fator S.A.', N'265       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (54, N'Banco Fibra S.A.', N'224       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (55, N'Banco Ficsa S.A.', N'626       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (56, N'Banco Finaxis S.A.', N'94        ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (57, N'Banco Guanabara S.A.', N'612       ', CAST(N'2021-04-29T20:20:26.980' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (58, N'Banco Inbursa S.A.', N'12        ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (59, N'Banco Industrial do Brasil S.A.', N'604       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (60, N'Banco Indusval S.A.', N'653       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (61, N'Banco Inter S.A.', N'77        ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (62, N'Banco Investcred Unibanco S.A.', N'249       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (63, N'Banco ItauBank S.A', N'479       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (64, N'Banco Itaú BBA S.A.', N'184       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (65, N'Banco Itaú Consignado S.A.', N'29        ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (66, N'Banco J. P. Morgan S.A.', N'376       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (67, N'Banco J. Safra S.A.', N'74        ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (68, N'Banco John Deere S.A.', N'217       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (69, N'Banco KDB S.A.', N'76        ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (70, N'Banco KEB HANA do Brasil S.A.', N'757       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (71, N'Banco Luso Brasileiro S.A.', N'600       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (72, N'Banco Mercantil do Brasil S.A.', N'389       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (73, N'Banco Mizuho do Brasil S.A.', N'370       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (74, N'Banco Modal S.A.', N'746       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (75, N'Banco Morgan Stanley S.A.', N'66        ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (76, N'Banco MUFG Brasil S.A.', N'456       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (77, N'Banco Máxima S.A.', N'243       ', CAST(N'2021-04-29T20:20:26.983' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (78, N'Banco Nacional de Desenvolvimento Econômico e Social - BNDES', N'7         ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (79, N'Banco Olé Bonsucesso Consignado S.A.', N'169       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (80, N'Banco Original do Agronegócio S.A.', N'79        ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (81, N'Banco Original S.A.', N'212       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (82, N'Banco Ourinvest S.A.', N'712       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (83, N'Banco PAN S.A.', N'623       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (84, N'Banco Paulista S.A.', N'611       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (85, N'Banco Pine S.A.', N'643       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (86, N'Banco Rabobank International Brasil S.A.', N'747       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (87, N'Banco Rendimento S.A.', N'633       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (88, N'Banco Ribeirão Preto S.A.', N'741       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (89, N'Banco Rodobens S.A.', N'120       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (90, N'Banco Safra S.A.', N'422       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (91, N'Banco Santander (Brasil) S.A.', N'33        ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (92, N'Banco Semear S.A.', N'743       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (93, N'Banco Sistema S.A.', N'754       ', CAST(N'2021-04-29T20:20:26.987' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (94, N'Banco Smartbank S.A.', N'630       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (95, N'Banco Société Générale Brasil S.A.', N'366       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (96, N'Banco Sofisa S.A.', N'637       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (97, N'Banco Sumitomo Mitsui Brasileiro S.A.', N'464       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (98, N'Banco Topázio S.A.', N'82        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (99, N'Banco Tricury S.A.', N'18        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
GO
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (100, N'Banco Triângulo S.A.', N'634       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (101, N'Banco Votorantim S.A.', N'655       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (102, N'Banco VR S.A.', N'610       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (103, N'Banco Western Union do Brasil S.A.', N'119       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (104, N'Banco Woori Bank do Brasil S.A.', N'124       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (105, N'Banco XP S.A.', N'348       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (106, N'BancoSeguro S.A.', N'81        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (107, N'BANESTES S.A. Banco do Estado do Espírito Santo', N'21        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (108, N'Bank of America Merrill Lynch Banco Múltiplo S.A.', N'755       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (109, N'BARI COMPANHIA HIPOTECÁRIA', N'268       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (110, N'BCV - Banco de Crédito e Varejo S.A.', N'250       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (111, N'BEXS Banco de Câmbio S.A.', N'144       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (112, N'Bexs Corretora de Câmbio S/A', N'253       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (113, N'BGC LIQUIDEZ DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA', N'134       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (114, N'BNY Mellon Banco S.A.', N'17        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (115, N'BPP Instituição de Pagamento S.A.', N'301       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (116, N'BR Partners Banco de Investimento S.A.', N'126       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (117, N'BRB - Banco de Brasília S.A.', N'70        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (118, N'Brickell S.A. Crédito', N'92        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (119, N'BRL Trust Distribuidora de Títulos e Valores Mobiliários S.A.', N'173       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (120, N'Broker Brasil Corretora de Câmbio Ltda.', N'142       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (121, N'BS2 Distribuidora de Títulos e Valores Mobiliários S.A.', N'292       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (122, N'Caixa Econômica Federal', N'104       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (123, N'CAMBIONET CORRETORA DE CÂMBIO LTDA.', N'309       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (124, N'CAROL DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA.', N'288       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (125, N'CARUANA S.A. - SOCIEDADE DE CRÉDITO, FINANCIAMENTO E INVESTIMENTO', N'130       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (126, N'Casa do Crédito S.A. Sociedade de Crédito ao Microempreendedor', N'159       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (127, N'Central Cooperativa de Crédito no Estado do Espírito Santo - CECOOP', N'114       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (128, N'CENTRAL DE COOPERATIVAS DE ECONOMIA E CRÉDITO MÚTUO DO ESTADO DO RIO GRANDE DO S', N'91        ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (129, N'China Construction Bank (Brasil) Banco Múltiplo S.A.', N'320       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (130, N'Citibank N.A.', N'477       ', CAST(N'2021-04-29T20:20:26.990' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (131, N'CM CAPITAL MARKETS CORRETORA DE CÂMBIO, TÍTULOS E VALORES MOBILIÁRIOS LTDA', N'180       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (132, N'Codepe Corretora de Valores e Câmbio S.A.', N'127       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (133, N'Commerzbank Brasil S.A. - Banco Múltiplo', N'163       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (134, N'CONFEDERAÇÃO NACIONAL DAS COOPERATIVAS CENTRAIS DE CRÉDITO E ECONOMIA FAMILIAR E', N'133       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (135, N'CONFEDERAÇÃO NACIONAL DAS COOPERATIVAS CENTRAIS UNICRED LTDA. - UNICRED DO BRASI', N'136       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (136, N'Confidence Corretora de Câmbio S.A.', N'60        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (137, N'Cooperativa Central de Crédito - AILOS', N'85        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (138, N'Cooperativa Central de Crédito Noroeste Brasileiro Ltda.', N'97        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (139, N'COOPERATIVA DE CREDITO RURAL DE PRIMAVERA DO LESTE', N'279       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (140, N'COOPERATIVA DE CRÉDITO MÚTUO DOS DESPACHANTES DE TRÂNSITO DE SANTA CATARINA E RI', N'16        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (141, N'Cooperativa de Crédito Rural Coopavel', N'281       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (142, N'Cooperativa de Crédito Rural de Abelardo Luz - Sulcredi/Crediluz', N'322       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (143, N'COOPERATIVA DE CRÉDITO RURAL DE OURO SULCREDI/OURO', N'286       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (144, N'Cooperativa de Crédito Rural de São Miguel do Oeste - Sulcredi/São Miguel', N'273       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (145, N'Credialiança Cooperativa de Crédito Rural', N'98        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (146, N'CREDICOAMO CREDITO RURAL COOPERATIVA', N'10        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (147, N'CREDISAN COOPERATIVA DE CRÉDITO', N'89        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (148, N'CREDIT SUISSE HEDGING-GRIFFO CORRETORA DE VALORES S.A', N'11        ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (149, N'Creditas Sociedade de Crédito Direto S.A.', N'342       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (150, N'CREFAZ SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E A EMPRESA DE PEQUENO PORTE LT', N'321       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (151, N'DECYSEO CORRETORA DE CAMBIO LTDA.', N'289       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (152, N'Deutsche Bank S.A. - Banco Alemão', N'487       ', CAST(N'2021-04-29T20:20:26.993' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (153, N'Easynvest - Título Corretora de Valores SA', N'140       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (154, N'Facta Financeira S.A. - Crédito Financiamento e Investimento', N'149       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (155, N'FAIR CORRETORA DE CAMBIO S.A.', N'196       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (156, N'FFA SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E À EMPRESA DE PEQUENO PORTE LTDA.', N'343       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (157, N'Fram Capital Distribuidora de Títulos e Valores Mobiliários S.A.', N'331       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (158, N'Frente Corretora de Câmbio Ltda.', N'285       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (159, N'Genial Investimentos Corretora de Valores Mobiliários S.A.', N'278       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (160, N'GERENCIANET PAGAMENTOS DO BRASIL LTDA', N'364       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (161, N'Get Money Corretora de Câmbio S.A.', N'138       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (162, N'Goldman Sachs do Brasil Banco Múltiplo S.A.', N'64        ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (163, N'Guide Investimentos S.A. Corretora de Valores', N'177       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (164, N'GUITTA CORRETORA DE CAMBIO LTDA.', N'146       ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (165, N'Haitong Banco de Investimento do Brasil S.A.', N'78        ', CAST(N'2021-04-29T20:20:26.997' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (166, N'Hipercard Banco Múltiplo S.A.', N'62        ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (167, N'HS FINANCEIRA S/A CREDITO, FINANCIAMENTO E INVESTIMENTOS', N'189       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (168, N'HSBC Brasil S.A. - Banco de Investimento', N'269       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (169, N'IB Corretora de Câmbio, Títulos e Valores Mobiliários S.A.', N'271       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (170, N'ICAP do Brasil Corretora de Títulos e Valores Mobiliários Ltda.', N'157       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (171, N'ICBC do Brasil Banco Múltiplo S.A.', N'132       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (172, N'ING Bank N.V.', N'492       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (173, N'Intesa Sanpaolo Brasil S.A. - Banco Múltiplo', N'139       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (174, N'Itaú Unibanco Holding S.A.', N'652       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (175, N'Itaú Unibanco S.A.', N'341       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (176, N'JPMorgan Chase Bank', N'488       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (177, N'Kirton Bank S.A. - Banco Múltiplo', N'399       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (178, N'Lastro RDV Distribuidora de Títulos e Valores Mobiliários Ltda.', N'293       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (179, N'Lecca Crédito, Financiamento e Investimento S/A', N'105       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (180, N'LEVYCAM - CORRETORA DE CAMBIO E VALORES LTDA.', N'145       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (181, N'Magliano S.A. Corretora de Cambio e Valores Mobiliarios', N'113       ', CAST(N'2021-04-29T20:20:27.000' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (182, N'MERCADOPAGO.COM REPRESENTACOES LTDA.', N'323       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (183, N'MONEY PLUS SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E A EMPRESA DE PEQUENO PORT', N'274       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (184, N'MONEYCORP BANCO DE CÂMBIO S.A.', N'259       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (185, N'MS Bank S.A. Banco de Câmbio', N'128       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (186, N'NECTON INVESTIMENTOS S.A. CORRETORA DE VALORES MOBILIÁRIOS E COMMODITIES', N'354       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (187, N'Nova Futura Corretora de Títulos e Valores Mobiliários Ltda.', N'191       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (188, N'Novo Banco Continental S.A. - Banco Múltiplo', N'753       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (189, N'Nu Pagamentos S.A.', N'260       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (190, N'OLIVEIRA TRUST DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIARIOS S.A.', N'111       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (191, N'OM DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA', N'319       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (192, N'Omni Banco S.A.', N'613       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (193, N'Pagseguro Internet S.A.', N'290       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (194, N'Paraná Banco S.A.', N'254       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (195, N'PARATI - CREDITO, FINANCIAMENTO E INVESTIMENTO S.A.', N'326       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (196, N'PARMETAL DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA', N'194       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (197, N'PERNAMBUCANAS FINANCIADORA S.A. - CRÉDITO, FINANCIAMENTO E INVESTIMENTO', N'174       ', CAST(N'2021-04-29T20:20:27.003' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (198, N'PI Distribuidora de Títulos e Valores Mobiliários S.A.', N'315       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (199, N'Planner Corretora de Valores S.A.', N'100       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
GO
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (200, N'Plural S.A. - Banco Múltiplo', N'125       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (201, N'PORTOCRED S.A. - CREDITO, FINANCIAMENTO E INVESTIMENTO', N'108       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (202, N'PORTOPAR DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA.', N'306       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (203, N'PÓLOCRED SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E À EMPRESA DE PEQUENO PORT', N'93        ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (204, N'QI Sociedade de Crédito Direto S.A.', N'329       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (205, N'RB CAPITAL INVESTIMENTOS DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LIMITADA', N'283       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (206, N'RENASCENCA DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA', N'101       ', CAST(N'2021-04-29T20:20:27.007' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (207, N'Sagitur Corretora de Câmbio Ltda.', N'270       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (208, N'Scotiabank Brasil S.A. Banco Múltiplo', N'751       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (209, N'Senff S.A. - Crédito, Financiamento e Investimento', N'276       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (210, N'SENSO CORRETORA DE CAMBIO E VALORES MOBILIARIOS S.A', N'545       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (211, N'SERVICOOP - COOPERATIVA DE CRÉDITO DOS SERVIDORES PÚBLICOS ESTADUAIS DO RIO GRAN', N'190       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (212, N'SOCRED S.A. - SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E À EMPRESA DE PEQUENO P', N'183       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (213, N'SOLIDUS S.A. CORRETORA DE CAMBIO E VALORES MOBILIARIOS', N'365       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (214, N'SOROCRED CRÉDITO, FINANCIAMENTO E INVESTIMENTO S.A.', N'299       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (215, N'State Street Brasil S.A. - Banco Comercial', N'14        ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (216, N'Stone Pagamentos S.A.', N'197       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (217, N'Super Pagamentos e Administração de Meios Eletrônicos S.A.', N'340       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (218, N'Terra Investimentos Distribuidora de Títulos e Valores Mobiliários Ltda.', N'307       ', CAST(N'2021-04-29T20:20:27.010' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (219, N'TORO CORRETORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA', N'352       ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (220, N'Travelex Banco de Câmbio S.A.', N'95        ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (221, N'Treviso Corretora de Câmbio S.A.', N'143       ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (222, N'TULLETT PREBON BRASIL CORRETORA DE VALORES E CÂMBIO LTDA', N'131       ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (223, N'UBS Brasil Banco de Investimento S.A.', N'129       ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (224, N'UBS Brasil Corretora de Câmbio, Títulos e Valores Mobiliários S.A.', N'15        ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (225, N'UNIPRIME CENTRAL - CENTRAL INTERESTADUAL DE COOPERATIVAS DE CREDITO LTDA.', N'99        ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (226, N'Uniprime Norte do Paraná - Coop de Economia e Crédito Mútuo dos Médicos', N'84        ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (227, N'UP.P SOCIEDADE DE EMPRÉSTIMO ENTRE PESSOAS S.A.', N'373       ', CAST(N'2021-04-29T20:20:27.013' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (228, N'Vips Corretora de Câmbio Ltda.', N'298       ', CAST(N'2021-04-29T20:20:27.017' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (229, N'VISION S.A. CORRETORA DE CAMBIO', N'296       ', CAST(N'2021-04-29T20:20:27.017' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (230, N'VITREO DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS S.A.', N'367       ', CAST(N'2021-04-29T20:20:27.017' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (231, N'VORTX DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA.', N'310       ', CAST(N'2021-04-29T20:20:27.017' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (232, N'XP INVESTIMENTOS CORRETORA DE CÂMBIO,TÍTULOS E VALORES MOBILIÁRIOS S/A', N'102       ', CAST(N'2021-04-29T20:20:27.017' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (233, N'Órama Distribuidora de Títulos e Valores Mobiliários S.A.', N'325       ', CAST(N'2021-04-29T20:20:27.017' AS DateTime), NULL)
INSERT [dbo].[Bancos] ([CodBanco], [NomeBanco], [NumeroBanco], [DataInclusao], [DataAlteracao]) VALUES (234, N'ÓTIMO SOCIEDADE DE CRÉDITO DIRETO S.A.', N'355       ', CAST(N'2021-04-29T20:20:27.017' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Bancos] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([CodCliente], [NomeCliente], [CodBanco], [DataInclusao], [DataAlteracao]) VALUES (1, N'Jhonny', 175, CAST(N'2021-04-29T20:26:38.157' AS DateTime), NULL)
INSERT [dbo].[Clientes] ([CodCliente], [NomeCliente], [CodBanco], [DataInclusao], [DataAlteracao]) VALUES (2, N'Marcos', 175, CAST(N'2021-04-29T20:26:50.490' AS DateTime), NULL)
INSERT [dbo].[Clientes] ([CodCliente], [NomeCliente], [CodBanco], [DataInclusao], [DataAlteracao]) VALUES (3, N'Mary', 90, CAST(N'2021-04-29T20:27:40.040' AS DateTime), NULL)
INSERT [dbo].[Clientes] ([CodCliente], [NomeCliente], [CodBanco], [DataInclusao], [DataAlteracao]) VALUES (4, N'Matheus', 25, CAST(N'2021-04-29T20:28:17.427' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[ContaCorrente] ON 

INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (1, N'827123', N'171', CAST(12500.0000 AS Decimal(18, 4)), CAST(1200.0000 AS Decimal(18, 4)), 1, CAST(N'2021-04-29T20:38:39.687' AS DateTime), CAST(N'2021-04-29T20:38:39.687' AS DateTime), NULL, 1, 175)
INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (2, N'827124', N'171', CAST(2500.0000 AS Decimal(18, 4)), CAST(5200.0000 AS Decimal(18, 4)), 1, CAST(N'2021-04-29T20:38:59.333' AS DateTime), CAST(N'2021-04-29T20:38:59.333' AS DateTime), NULL, 2, 175)
INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (3, N'827125', N'277', CAST(34000.0000 AS Decimal(18, 4)), CAST(28000.0000 AS Decimal(18, 4)), 1, CAST(N'2021-04-29T20:39:44.920' AS DateTime), CAST(N'2021-04-29T20:39:44.920' AS DateTime), NULL, 3, 90)
INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (4, N'827126', N'135', CAST(25000.0000 AS Decimal(18, 4)), CAST(15200.0000 AS Decimal(18, 4)), 1, CAST(N'2021-04-29T20:40:40.687' AS DateTime), CAST(N'2021-04-29T20:40:40.687' AS DateTime), NULL, 4, 25)
INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (5, N'827665', N'123', CAST(10000.0000 AS Decimal(18, 4)), CAST(1000.0000 AS Decimal(18, 4)), 2, CAST(N'2021-04-29T00:00:00.000' AS DateTime), NULL, NULL, 1, 25)
INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (6, N'765443', N'122', CAST(3000.0000 AS Decimal(18, 4)), CAST(200.0000 AS Decimal(18, 4)), 2, CAST(N'2021-04-29T00:00:00.000' AS DateTime), NULL, NULL, 2, 90)
INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (7, N'453332', N'100', CAST(2012.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), 2, CAST(N'2021-04-29T00:00:00.000' AS DateTime), NULL, NULL, 3, 175)
INSERT [dbo].[ContaCorrente] ([CodContaCorrente], [NumeroConta], [NumeroAgencia], [Saldo], [Limite], [CodTipoConta], [DataAbertura], [DataInclusao], [DataAlteracao], [CodCliente], [CodBanco]) VALUES (8, N'235667', N'32', CAST(12000.0000 AS Decimal(18, 4)), CAST(240.0000 AS Decimal(18, 4)), 2, CAST(N'2021-04-29T00:00:00.000' AS DateTime), NULL, NULL, 4, 90)
SET IDENTITY_INSERT [dbo].[ContaCorrente] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoConta] ON 

INSERT [dbo].[TipoConta] ([CodTipoConta], [NomeTipoConta], [DataInclusao], [DataAlteracao]) VALUES (1, N'Conta Corrente', CAST(N'2021-04-29T20:01:18.223' AS DateTime), NULL)
INSERT [dbo].[TipoConta] ([CodTipoConta], [NomeTipoConta], [DataInclusao], [DataAlteracao]) VALUES (2, N'Conta Investimento', CAST(N'2021-04-29T20:03:13.757' AS DateTime), NULL)
INSERT [dbo].[TipoConta] ([CodTipoConta], [NomeTipoConta], [DataInclusao], [DataAlteracao]) VALUES (3, N'Poupança', CAST(N'2021-04-29T20:03:32.363' AS DateTime), NULL)
INSERT [dbo].[TipoConta] ([CodTipoConta], [NomeTipoConta], [DataInclusao], [DataAlteracao]) VALUES (4, N'Salário', CAST(N'2021-04-29T20:03:56.380' AS DateTime), NULL)
INSERT [dbo].[TipoConta] ([CodTipoConta], [NomeTipoConta], [DataInclusao], [DataAlteracao]) VALUES (7, N'Conjunta', CAST(N'2021-04-29T21:56:38.480' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[TipoConta] OFF
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Bancos] FOREIGN KEY([CodBanco])
REFERENCES [dbo].[Bancos] ([CodBanco])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Bancos]
GO
ALTER TABLE [dbo].[ContaCorrente]  WITH CHECK ADD  CONSTRAINT [FK_ContaCorrente_Bancos] FOREIGN KEY([CodBanco])
REFERENCES [dbo].[Bancos] ([CodBanco])
GO
ALTER TABLE [dbo].[ContaCorrente] CHECK CONSTRAINT [FK_ContaCorrente_Bancos]
GO
ALTER TABLE [dbo].[ContaCorrente]  WITH CHECK ADD  CONSTRAINT [FK_ContaCorrente_Clientes] FOREIGN KEY([CodCliente])
REFERENCES [dbo].[Clientes] ([CodCliente])
GO
ALTER TABLE [dbo].[ContaCorrente] CHECK CONSTRAINT [FK_ContaCorrente_Clientes]
GO
ALTER TABLE [dbo].[ContaCorrente]  WITH CHECK ADD  CONSTRAINT [FK_ContaCorrente_TipoConta] FOREIGN KEY([CodTipoConta])
REFERENCES [dbo].[TipoConta] ([CodTipoConta])
GO
ALTER TABLE [dbo].[ContaCorrente] CHECK CONSTRAINT [FK_ContaCorrente_TipoConta]
GO
ALTER TABLE [dbo].[ContaInvestimento]  WITH CHECK ADD  CONSTRAINT [FK_ContaInvestimento_Bancos] FOREIGN KEY([CodBanco])
REFERENCES [dbo].[Bancos] ([CodBanco])
GO
ALTER TABLE [dbo].[ContaInvestimento] CHECK CONSTRAINT [FK_ContaInvestimento_Bancos]
GO
ALTER TABLE [dbo].[ContaInvestimento]  WITH CHECK ADD  CONSTRAINT [FK_ContaInvestimento_Clientes] FOREIGN KEY([CodCliente])
REFERENCES [dbo].[Clientes] ([CodCliente])
GO
ALTER TABLE [dbo].[ContaInvestimento] CHECK CONSTRAINT [FK_ContaInvestimento_Clientes]
GO
ALTER TABLE [dbo].[ContaInvestimento]  WITH CHECK ADD  CONSTRAINT [FK_ContaInvestimento_TipoConta] FOREIGN KEY([CodTipoConta])
REFERENCES [dbo].[TipoConta] ([CodTipoConta])
GO
ALTER TABLE [dbo].[ContaInvestimento] CHECK CONSTRAINT [FK_ContaInvestimento_TipoConta]
GO
USE [master]
GO
ALTER DATABASE [Banco] SET  READ_WRITE 
GO
