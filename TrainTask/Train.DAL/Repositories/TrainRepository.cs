using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Train.DAL
{
    public class TrainRepository : ITrainRepository
    {
        //Так ссделал для чтобы с экономить время. Но это стоит от сюда убрать. Можно записать строку в appsetings json и прокидывать через IOptions.
        string connectionString = "Data Source=DESKTOP-4NOA943;Initial Catalog=Trains;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Add(DataTable trains, DataTable railCars)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var orderDetails = connection.Execute("[dbo].[AddTrainsWithRailCars]", new
                {
                    @trains = trains,
                    @railCars = railCars
                },
                commandType: CommandType.StoredProcedure
                );
            }
        }

    }
}