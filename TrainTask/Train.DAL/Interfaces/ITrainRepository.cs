using System.Data;

namespace Train.DAL
{
    public interface ITrainRepository
    {
        void Add(DataTable trains, DataTable railCars);
    }
}