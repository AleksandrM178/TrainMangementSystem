using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.DAL.Models
{
    public class TrainFullScalePageDto
    {
		public int TrainNumber { get; set; }

		public string TrainIndexCombined { get; set; }

		public string? FromStationName { get; set; }

		public string? ToStationName { get; set; }

		public string? LastStationName { get; set; }

		public string? WhenLastOperation { get; set; }

		public List<RailCarDto> Сarriages { get; set; }
	}
}
