using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using Train.BLL;
using Train.BLL.Models;

namespace Train.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private readonly IUploadXmlFileService _uploadXmlFileService;

        public TrainController(IUploadXmlFileService uploadXmlFileService)
        {
            _uploadXmlFileService = uploadXmlFileService;   
        }

        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file)
        {
            var data = await _uploadXmlFileService.UploadData(file);
            return Ok(data);
        }
    }
}
