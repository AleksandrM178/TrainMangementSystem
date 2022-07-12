CREATE TABLE [dbo].[TrainFullScalePage](
	[TrainNumber] [bigint] NOT NULL,
	[TrainIndexCombined] [nchar](50) NULL,
	[FromStationName] [varchar](50) NULL,
	[ToStationName] [varchar](50) NULL,
	[LastStationName] [varchar](50) NULL,
	[WhenLastOperation] [datetime2](7) NOT NULL,
	CONSTRAINT TrainNumber_pk PRIMARY KEY (TrainNumber)
) ON [PRIMARY]