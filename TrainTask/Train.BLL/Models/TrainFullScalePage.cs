namespace Train.BLL.Models
{
    public class TrainFullScalePage
	{
		public int TrainNumber { get; set; }

		public string TrainIndexCombined { get; set; }

		public string? FromStationName { get; set; }

		public string? ToStationName { get; set; }

		public string? LastStationName { get; set; }

		public string? WhenLastOperation { get; set; }

		public List<RailCar> Сarriages { get; set; }
	}
}
