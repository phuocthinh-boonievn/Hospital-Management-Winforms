USE [master]
GO
/****** Object:  Database [HospitalManagement]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE DATABASE [HospitalManagement]
GO

USE [HospitalManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 23/04/2023 12:13:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[accountID] [smallint] IDENTITY(1,1) NOT NULL,
	[role] [smallint] NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
 CONSTRAINT [account_accountid_primary] PRIMARY KEY CLUSTERED 
(
	[accountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 23/04/2023 12:13:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[appointmentID] [smallint] IDENTITY(1,1) NOT NULL,
	[status] [nvarchar](255) NOT NULL,
	[appointedDate] [datetime] NOT NULL,
	[doctorID] [smallint] NOT NULL,
	[patientID] [smallint] NOT NULL,
 CONSTRAINT [appointment_appointmentid_primary] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 23/04/2023 12:13:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctorID] [smallint] IDENTITY(1,1)  NOT NULL,
	[doctorName] [nvarchar](255) NOT NULL,
	[doctorSpecialization] [nvarchar](255) NULL,
	[accountID] [smallint] NOT NULL,
 CONSTRAINT [doctor_doctorid_primary] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospital Bill]    Script Date: 23/04/2023 12:13:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital Bill](
	[billID] [smallint] IDENTITY(1,1) NOT NULL,
	[billDate] [date] NOT NULL,
	[totalPrice] [float] NOT NULL,
	[appointmentID] [smallint] NOT NULL,
 CONSTRAINT [hospital bill_billid_primary] PRIMARY KEY CLUSTERED 
(
	[billID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine Storage]    Script Date: 23/04/2023 12:13:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine Storage](
	[medicineID] [smallint] IDENTITY(1,1) NOT NULL,
	[medicineName] [nvarchar](255) NOT NULL,
	[medicinePrice] [bigint] NOT NULL,
	[medicineAmount] [bigint] NOT NULL,
 CONSTRAINT [medicine storage_medicineid_primary] PRIMARY KEY CLUSTERED 
(
	[medicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 23/04/2023 12:13:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[patientID] [smallint] IDENTITY(1,1) NOT NULL,
	[patientName] [nvarchar](255) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[gender] [varchar](1) NOT NULL,
	[accountID] [smallint] NOT NULL,
 CONSTRAINT [patient_patientid_primary] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescription Detail]    Script Date: 23/04/2023 12:13:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription Detail](
	[prescriptedDose] [nvarchar](255) NOT NULL,
	[prescriptedAmount] [tinyint] NOT NULL,
	[prescriptionDescription] [nvarchar](255) NULL,
	[billID] [smallint] NOT NULL,
	[medicineID] [smallint] NOT NULL,
	 PRIMARY KEY (billID, medicineID));
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([role], [username], [password]) VALUES (0, N'admin', N'123')
INSERT [dbo].[Account] ([role], [username], [password]) VALUES (1, N'doctor1', N'1')
INSERT [dbo].[Account] ([role], [username], [password]) VALUES (1, N'doctor2', N'2')
INSERT [dbo].[Account] ([role], [username], [password]) VALUES (2, N'patient1', N'1')
INSERT [dbo].[Account] ([role], [username], [password]) VALUES (2, N'patient2', N'2')
GO
INSERT [dbo].[Appointment] ([status], [appointedDate], [doctorID], [patientID]) VALUES (N'Not Yet', CAST(N'2023-04-25T08:30:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Appointment] ([status], [appointedDate], [doctorID], [patientID]) VALUES (N'Finished', CAST(N'2023-04-22T07:00:00.000' AS DateTime), 2, 2)
INSERT [dbo].[Appointment] ([status], [appointedDate], [doctorID], [patientID]) VALUES (N'Finished', CAST(N'2023-04-20T09:00:00.000' AS DateTime), 1, 2)
GO
INSERT [dbo].[Doctor] ([doctorName], [doctorSpecialization], [accountID]) VALUES (N'Doctor Stone', N'Cardiologist', 2)
INSERT [dbo].[Doctor] ([doctorName], [doctorSpecialization], [accountID]) VALUES (N'Doctor Strange', N'Family Medicine', 3)
GO
INSERT [dbo].[Medicine Storage] ([medicineName], [medicinePrice], [medicineAmount]) VALUES (N'Morphine', 100, 1000)
INSERT [dbo].[Medicine Storage] ([medicineName], [medicinePrice], [medicineAmount]) VALUES (N'Aspirin', 50, 244)
INSERT [dbo].[Medicine Storage] ([medicineName], [medicinePrice], [medicineAmount]) VALUES (N'Cold Medicine', 25, 98)
GO
INSERT [dbo].[Patient] ([patientName], [dateOfBirth], [gender], [accountID]) VALUES (N'John', CAST(N'2000-02-02' AS Date), N'M', 4)
INSERT [dbo].[Patient] ([patientName], [dateOfBirth], [gender], [accountID]) VALUES (N'Mary ', CAST(N'1999-01-01' AS Date), N'F', 5)
GO
/****** Object:  Index [appointment_doctorid_index]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE NONCLUSTERED INDEX [appointment_doctorid_index] ON [dbo].[Appointment]
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [appointment_patientid_index]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE NONCLUSTERED INDEX [appointment_patientid_index] ON [dbo].[Appointment]
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [doctor_accountid_index]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE NONCLUSTERED INDEX [doctor_accountid_index] ON [dbo].[Doctor]
(
	[accountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [hospital bill_appointmentid_index]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE NONCLUSTERED INDEX [hospital bill_appointmentid_index] ON [dbo].[Hospital Bill]
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [patient_accountid_index]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE NONCLUSTERED INDEX [patient_accountid_index] ON [dbo].[Patient]
(
	[accountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [prescription detail_billid_index]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE NONCLUSTERED INDEX [prescription detail_billid_index] ON [dbo].[Prescription Detail]
(
	[billID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [prescription detail_medicineid_index]    Script Date: 23/04/2023 12:13:32 CH ******/
CREATE NONCLUSTERED INDEX [prescription detail_medicineid_index] ON [dbo].[Prescription Detail]
(
	[medicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [appointment_doctorid_foreign] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [appointment_doctorid_foreign]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [appointment_patientid_foreign] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [appointment_patientid_foreign]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [doctor_accountid_foreign] FOREIGN KEY([accountID])
REFERENCES [dbo].[Account] ([accountID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [doctor_accountid_foreign]
GO
ALTER TABLE [dbo].[Hospital Bill]  WITH CHECK ADD  CONSTRAINT [hospital bill_billid_foreign] FOREIGN KEY([billID])
REFERENCES [dbo].[Appointment] ([appointmentID])
GO
ALTER TABLE [dbo].[Hospital Bill] CHECK CONSTRAINT [hospital bill_billid_foreign]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [patient_accountid_foreign] FOREIGN KEY([accountID])
REFERENCES [dbo].[Account] ([accountID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [patient_accountid_foreign]
GO
ALTER TABLE [dbo].[Prescription Detail]  WITH CHECK ADD  CONSTRAINT [prescription detail_billid_foreign] FOREIGN KEY([billID])
REFERENCES [dbo].[Hospital Bill] ([billID])
GO
ALTER TABLE [dbo].[Prescription Detail] CHECK CONSTRAINT [prescription detail_billid_foreign]
GO
ALTER TABLE [dbo].[Prescription Detail]  WITH CHECK ADD  CONSTRAINT [prescription detail_medicineid_foreign] FOREIGN KEY([medicineID])
REFERENCES [dbo].[Medicine Storage] ([medicineID])
GO
ALTER TABLE [dbo].[Prescription Detail] CHECK CONSTRAINT [prescription detail_medicineid_foreign]
GO
USE [master]
GO
ALTER DATABASE [HospitalManagement] SET  READ_WRITE 
GO
