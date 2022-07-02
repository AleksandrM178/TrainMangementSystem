using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.DAL.Models
{
    public class RailCarDto
    {
		public int Id { get; set; }

		public string? LastOperationName { get; set; }

		public string? InvoiceNum { get; set; }

		public int PositionInTrain { get; set; }

		public int CarNumber { get; set; }

		public string? FreightEtsngName { get; set; }

		public int FreightTotalWeightKg { get; set; }

		public TrainFullScalePageDto Train { get; set; }
	}
}
