CREATE TYPE [dbo].[TrainFullScalePage] AS TABLE(
	[TrainNumber] [bigint] NULL,
	[TrainIndexCombined] [nchar](50) NULL,
	[FromStationName] [varchar](50) NULL,
	[ToStationName] [varchar](50) NULL,
	[LastStationName] [varchar](50) NULL,
	[WhenLastOperation] [datetime2](7) NULL
)
GO

CREATE TYPE [dbo].[RailCar] AS TABLE(
	[LastOperationName] [nvarchar](50) NULL,
	[InvoiceNum] [nvarchar](50) NULL,
	[PositionInTrain] [int] NULL,
	[CarNumber] [int] NULL,
	[FreightEtsngName] [nvarchar](50) NULL,
	[FreightTotalWeightKg] [int] NULL,
	[TrainNum] [bigint] NULL
)