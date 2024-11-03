CREATE TABLE [dbo].[User](
	[UserID] [varchar](256) NOT NULL,
	[Account] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Salt] [varchar](50) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[UserEmail] [varchar](256) NULL,
	[UserPhone] [char](10) NULL,
	[RoleID] [int] NULL,
	[CreateDatetime] [datetime] NOT NULL,
	[CreateBy] int NOT NULL,
	[UpdateBy] int NULL,
	[UpdateDatetime] [datetime] NULL,
	[IsEnabled] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO