using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaymentService.Models;
using PaymentService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PaymentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private ILogger<MoviesController> _logger;
        private MoviesService _moviesService;

        [HttpGet]
        public async Task<ActionResult<Movie[]>> GetAllMovies()
        {
            try
            {
                _logger.LogError("GetAllMovies INVOKED");
                HttpClient client = new HttpClient();
                var res = await client.GetAsync("http://videostreamservice/Video/LogIt");
                return Ok(res.Content.ReadAsStreamAsync().Result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        public MoviesController(MoviesService moviesService, ILogger<MoviesController> logger)
        {
            this._logger = logger;
            this._moviesService = moviesService;
        }



    }
}
