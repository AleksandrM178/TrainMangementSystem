using Microsoft.AspNetCore.Http;
using Train.BLL.Models;

namespace Train.BLL
{
    public interface IUploadXmlFileService
    {
        Task<List<TrainFullScalePage>> UploadData(IFormFile file);
    }
}