using Microsoft.AspNetCore.Http;
using System.Data;
using System.Reflection;
using System.Xml.Serialization;
using Train.BLL.Models;
using Train.BLL.Models.XmlModels;

namespace Train.BLL
{
    public class UploadXmlFileService
    {      
        public async Task<List<TrainFullScalePage>> UploadData(IFormFile file)
        {
            var trains = new List<TrainFullScalePage>();
            var parsedData = DeserializeTrainDataFromXml(file);

            if(parsedData != null)
            {
                trains = ConvertTrainFullScalePages(parsedData);
                var railCarsTable = GetDataTableForRailCars(trains);
                var trainsTable = GetDataTableForTrains(trains);
            }
            return trains;
        }

        private DataTable GetDataTableForRailCars(List<TrainFullScalePage> trains)
        {
            var table = GenerateTableForRailCar();
            foreach(var train in trains)
            {
                foreach (var carriage in train.Сarriages) 
                {
                    table.Rows.Add(new object[] 
                    {
                        carriage.LastOperationName, 
                        carriage.InvoiceNum,
                        carriage.PositionInTrain,
                        carriage.CarNumber,
                        carriage.FreightEtsngName,
                        carriage.FreightTotalWeightKg
                    });
                }
            }
            return table;
        }

        private DataTable GetDataTableForTrains(List<TrainFullScalePage> trains)
        {
            var table = GenerateTableForTrainScaleFullPage();
            foreach (var train in trains)
            {
                table.Rows.Add(new object[]
                {
                    train.TrainNumber,
                    train.TrainIndexCombined,
                    train.FromStationName,
                    train.ToStationName,
                    train.LastStationName,
                    train.WhenLastOperation
                });
            }
            return table;
        }

        private DataTable GenerateTableForTrainScaleFullPage()
        {
            DataTable trainTable = new DataTable();
            trainTable.Clear();
            trainTable.Columns.Add("TrainNumber", typeof(System.Int32));
            trainTable.Columns.Add("TrainIndexCombined", typeof(System.String));
            trainTable.Columns.Add("FromStationName", typeof(System.String));
            trainTable.Columns.Add("ToStationName", typeof(System.String));
            trainTable.Columns.Add("LastStationName", typeof(System.String));
            trainTable.Columns.Add("WhenLastOperation", typeof(System.String));
            return trainTable;
        }
       private DataTable GenerateTableForRailCar()

       {

            DataTable railCarTable = new DataTable();
            railCarTable.Clear();
            railCarTable.Columns.Add("LastOperationName", typeof(System.String));
            railCarTable.Columns.Add("InvoiceNum", typeof(System.String));
            railCarTable.Columns.Add("PositionInTrain", typeof(System.Int32));
            railCarTable.Columns.Add("CarNumber", typeof(System.Int32));
            railCarTable.Columns.Add("FreightEtsngName", typeof(System.String));
            railCarTable.Columns.Add("FreightTotalWeightKg", typeof(System.Int32));
            return railCarTable;
        }


        private List<TrainFullScalePage> ConvertTrainFullScalePages(List<Row> parsedData)
        {
            var trains = parsedData.GroupBy(x => x.TrainNumber).Select(t =>
                new TrainFullScalePage()
                {
                    TrainNumber = t.Key,
                    FromStationName = t.Select(x => x.FromStationName).FirstOrDefault(),
                    ToStationName = t.Select(x => x.ToStationName).FirstOrDefault(),
                    LastStationName = t.Select(x => x.LastStationName).FirstOrDefault(),
                    TrainIndexCombined = t.Select(x => x.TrainIndexCombined).FirstOrDefault(),
                    WhenLastOperation = t.Select(x => x.WhenLastOperation).FirstOrDefault(),
                    Сarriages = t.Select(c => 
                    new RailCar()
                    {
                        CarNumber = c.CarNumber,
                        InvoiceNum = c.InvoiceNum,
                        FreightEtsngName = c.FreightEtsngName,
                        LastOperationName = c.LastOperationName,
                        PositionInTrain = c.PositionInTrain,
                        FreightTotalWeightKg = c.FreightTotalWeightKg

                    }).OrderBy(x => x.PositionInTrain).ToList()
                }).ToList();

            return trains;
        }

        private List<Row> DeserializeTrainDataFromXml(IFormFile file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Row>), new XmlRootAttribute("Root"));
            var parsedData = new List<Row>();

            using(var stream = new StreamReader(file.OpenReadStream()))
            {
                try
                {
                    parsedData = (List<Row>)xmlSerializer.Deserialize(stream);
                }
                catch (Exception ex) 
                {
                    throw new Exception();
                }

                stream.Close();
            }
       
            return parsedData;
        }
    }
}