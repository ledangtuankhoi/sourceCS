CREATE DATABASE QuanLySinhVien
USE [QuanLySinhVien]
GO
/****** Object:  Table [dbo].[Faculty]    Script Date: 10/07/2019 20:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
 
[FacultyID] [int] NOT NULL, 
 
[FacultyName] [nvarchar](200) NULL, 
 CONSTRAINT [PK_dbo.Falculty] PRIMARY KEY CLUSTERED 
(
 
[FacultyID] ASC 
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 10/07/2019 20:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
 
[StudentID] [nvarchar](20) NOT NULL, 
 
[FullName] [nvarchar](200) NULL, 
 
[AverageScore] [float] NULL, 
 
[FacultyID] [int] NULL, 
 CONSTRAINT [PK_dbo.Student] PRIMARY KEY CLUSTERED 
(
 
[StudentID] ASC 
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Student_Faculty]    Script Date: 10/07/2019
20:59:08 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Faculty]
FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO 
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Faculty]
GO 

