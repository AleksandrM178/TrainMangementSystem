namespace Train.BLL.Models
{
    public class RailCar
    {
		public int Id { get; set; }

		public string? LastOperationName { get; set; }

		public string? InvoiceNum { get; set; }

		public int PositionInTrain { get; set; }

		public int CarNumber { get; set; }

		public string? FreightEtsngName { get; set; }

		public int FreightTotalWeightKg { get; set; }

		public int TrainNum { get; set; }

		public TrainFullScalePage Train {get; set;}	
	}
}
