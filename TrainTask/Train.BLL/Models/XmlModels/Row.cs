
using System.Xml.Serialization;

namespace Train.BLL.Models.XmlModels
{
	[XmlType("row")]
    public class Row
    {
		[XmlElement(ElementName = "TrainNumber")]
		public int TrainNumber { get; set; }

		[XmlElement(ElementName = "TrainIndexCombined")]
		public string? TrainIndexCombined { get; set; }

		[XmlElement(ElementName = "FromStationName")]
		public string? FromStationName { get; set; }

		[XmlElement(ElementName = "ToStationName")]
		public string? ToStationName { get; set; }

		[XmlElement(ElementName = "LastStationName")]
		public string? LastStationName { get; set; }

		[XmlElement(ElementName = "WhenLastOperation")]
		public string? WhenLastOperation { get; set; }

		[XmlElement(ElementName = "LastOperationName")]
		public string? LastOperationName { get; set; }

		[XmlElement(ElementName = "InvoiceNum")]
		public string? InvoiceNum { get; set; }

		[XmlElement(ElementName = "PositionInTrain")]
		public int PositionInTrain { get; set; }

		[XmlElement(ElementName = "CarNumber")]
		public int CarNumber { get; set; }

		[XmlElement(ElementName = "FreightEtsngName")]
		public string? FreightEtsngName { get; set; }

		[XmlElement(ElementName = "FreightTotalWeightKg")]
		public int FreightTotalWeightKg { get; set; }
	}
}
