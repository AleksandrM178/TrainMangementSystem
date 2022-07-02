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
        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file)
        {
            var parser = new UploadXmlFileService();
            var data = await parser.UploadData(file);
            return Ok(data);
        }
    }
}
