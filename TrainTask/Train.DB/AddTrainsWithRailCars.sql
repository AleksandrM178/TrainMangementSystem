CREATE PROCEDURE [dbo].[AddTrainsWithRailCars]
	@trains [dbo].[TrainFullScalePage] READONLY,
	@railCars [dbo].[RailCar] READONLY
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO [dbo].[TrainFullScalePage](TrainNumber, 
	TrainIndexCombined, 
	FromStationName, 
	ToStationName, 
	LastStationName, 
	WhenLastOperation)
	SELECT TrainNumber, 
	TrainIndexCombined, 
	FromStationName, 
	ToStationName, 
	LastStationName, 
	WhenLastOperation
	FROM @trains

	INSERT INTO [dbo].RailCar(
	LastOperationName,
	InvoiceNum,
	PositionInTrain,
	CarNumber,
	FreightEtsngName,
	FreightTotalWeightKg,
	TrainNum)
	SELECT
	LastOperationName,
	InvoiceNum,
	PositionInTrain,
	CarNumber,
	FreightEtsngName,
	FreightTotalWeightKg,
	TrainNum
	FROM @railCars
END