USE [BinsarDB]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 19/05/2023 17:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[deptid] [int] IDENTITY(1,1) NOT NULL,
	[deptcode] [varchar](50) NULL,
	[deptname] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[deptid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19/05/2023 17:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[empid] [int] IDENTITY(1,1) NOT NULL,
	[empnip] [varchar](50) NULL,
	[empname] [varchar](50) NULL,
	[deptid] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeAddress]    Script Date: 19/05/2023 17:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeAddress](
	[empaddressid] [int] IDENTITY(1,1) NOT NULL,
	[address] [varchar](50) NULL,
	[city] [varchar](50) NULL,
	[empid] [int] NULL,
 CONSTRAINT [PK_EmployeeAddress] PRIMARY KEY CLUSTERED 
(
	[empaddressid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 19/05/2023 17:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[projectid] [int] IDENTITY(1,1) NOT NULL,
	[projectname] [varchar](50) NULL,
	[empid] [int] NULL,
	[deptid] [int] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[projectid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 
GO
INSERT [dbo].[Department] ([deptid], [deptcode], [deptname]) VALUES (1, N'D001', N'IT')
GO
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([deptid])
REFERENCES [dbo].[Department] ([deptid])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[EmployeeAddress]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeAddress_Employee] FOREIGN KEY([empid])
REFERENCES [dbo].[Employee] ([empid])
GO
ALTER TABLE [dbo].[EmployeeAddress] CHECK CONSTRAINT [FK_EmployeeAddress_Employee]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Department] FOREIGN KEY([deptid])
REFERENCES [dbo].[Department] ([deptid])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Department]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Employee] FOREIGN KEY([empid])
REFERENCES [dbo].[Employee] ([empid])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Employee]
GO
