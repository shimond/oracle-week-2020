using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VideoStreamService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly ILogger<VideoController> _logger;

        [HttpGet("LogIt")]
        public ActionResult LogIt() { 
            _logger.LogError("LogIt Invoked");
            return Ok(DateTime.Now);
        }

        [HttpGet("{name}")]
        public ActionResult GetFileByName(string name)
        {
            _logger.LogInformation("GetFileByName Invoked");
            string root = Directory.GetCurrentDirectory();
            string path = Path.Combine(root, "wwwroot", "Content", name + ".mp4");
            return PhysicalFile(path, "application/octet-stream", true);
        }

        public VideoController(ILogger<VideoController> logger)
        {
            _logger = logger;
        }
    }
}
