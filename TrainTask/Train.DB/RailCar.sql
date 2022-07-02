CREATE TABLE [dbo].[RailCar](
	[Id] [bigint] NOT NULL,
	[LastOperationName] [nvarchar](50) NULL,
	[InvoiceNum] [nvarchar](50) NULL,
	[PositionInTrain] [int] NULL,
	[CarNumber] [int] NULL,
	[FreightEtsngName] [nvarchar](50) NULL,
	[FreightTotalWeightKg] [int] NULL,
	[TrainNum] [bigint] NULL,
	CONSTRAINT id_pk PRIMARY KEY (Id)
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RailCar]  WITH CHECK ADD  CONSTRAINT [FK_RailCar_TrainFullScalePage] FOREIGN KEY([TrainNum])
REFERENCES [dbo].[TrainFullScalePage] ([TrainNumber])
GO

ALTER TABLE [dbo].[RailCar] CHECK CONSTRAINT [FK_RailCar_TrainFullScalePage]
GO
