USE [master]
GO
/****** Object:  Table [187057_Akash].[doctors]    Script Date: 04-Sep-19 1:03:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [187057_Akash].[doctors](
	[doctor_id] [int] IDENTITY(1,1) NOT NULL,
	[doctor_name] [varchar](50) NULL,
	[department] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [187057_Akash].[inpatients]    Script Date: 04-Sep-19 1:03:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [187057_Akash].[inpatients](
	[patient_id] [int] NOT NULL,
	[admission_date] [date] NULL,
	[doctor_assigned] [int] NULL,
	[disease] [varchar](50) NULL,
	[room_assigned] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [187057_Akash].[labs]    Script Date: 04-Sep-19 1:03:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [187057_Akash].[labs](
	[lab_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [int] NULL,
	[test_name] [varchar](50) NULL,
	[test_cost] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[lab_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [187057_Akash].[logintable]    Script Date: 04-Sep-19 1:03:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [187057_Akash].[logintable](
	[id] [int] NOT NULL,
	[username] [varchar](40) NULL,
	[pass] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [187057_Akash].[patients]    Script Date: 04-Sep-19 1:03:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [187057_Akash].[patients](
	[patient_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL,
	[Weight] [int] NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[PhoneNo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[patient_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [187057_Akash].[rooms]    Script Date: 04-Sep-19 1:03:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [187057_Akash].[rooms](
	[room_id] [int] IDENTITY(1,1) NOT NULL,
	[room_name] [varchar](50) NULL,
	[patient_id] [int] NULL,
	[room_charge] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [187057_Akash].[doctors] ON 

INSERT [187057_Akash].[doctors] ([doctor_id], [doctor_name], [department]) VALUES (1, N'Akash', N'dfgh')
SET IDENTITY_INSERT [187057_Akash].[doctors] OFF
INSERT [187057_Akash].[inpatients] ([patient_id], [admission_date], [doctor_assigned], [disease], [room_assigned]) VALUES (1, CAST(N'2019-09-01' AS Date), 1, N'hgc', 1)
SET IDENTITY_INSERT [187057_Akash].[labs] ON 

INSERT [187057_Akash].[labs] ([lab_id], [patient_id], [test_name], [test_cost]) VALUES (1, 1, N'dgnvb', 234)
SET IDENTITY_INSERT [187057_Akash].[labs] OFF
INSERT [187057_Akash].[logintable] ([id], [username], [pass]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [187057_Akash].[patients] ON 

INSERT [187057_Akash].[patients] ([patient_Id], [Name], [Age], [Weight], [Gender], [Address], [PhoneNo]) VALUES (1, N'akash', 12, 12, N'male', N'dwdw', N'987654321')
SET IDENTITY_INSERT [187057_Akash].[patients] OFF
SET IDENTITY_INSERT [187057_Akash].[rooms] ON 

INSERT [187057_Akash].[rooms] ([room_id], [room_name], [patient_id], [room_charge]) VALUES (1, N'R-01', 1, 1500)
INSERT [187057_Akash].[rooms] ([room_id], [room_name], [patient_id], [room_charge]) VALUES (2, N'R-02', NULL, 1700)
INSERT [187057_Akash].[rooms] ([room_id], [room_name], [patient_id], [room_charge]) VALUES (3, N'R-03', NULL, 1600)
INSERT [187057_Akash].[rooms] ([room_id], [room_name], [patient_id], [room_charge]) VALUES (4, N'R-04', NULL, 2000)
INSERT [187057_Akash].[rooms] ([room_id], [room_name], [patient_id], [room_charge]) VALUES (5, N'R-05', NULL, 3000)
SET IDENTITY_INSERT [187057_Akash].[rooms] OFF
