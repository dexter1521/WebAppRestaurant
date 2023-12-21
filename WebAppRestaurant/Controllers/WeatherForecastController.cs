using DataBase.Context;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using DataBase.Tables;
namespace WebAppRestaurant.Controllers
{

    public class TestRequest
    {
        
        public string? Id { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly _DBContext _context;

        private readonly IDbConnection _dbConnection;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, _DBContext context, IDbConnection dbConnection)
        {
            _logger = logger;
            _context = context;
            _dbConnection = dbConnection;
        }

        [HttpPost("GetWeatherForecast")]
        public async Task<IActionResult> Get(TestRequest request)
        {
            List<PRodsResponse> response = new ();

            if ( string.IsNullOrEmpty(request.Id) ) {
                var result = await _dbConnection.GetAllAsync<Prod>();
                response = result.Adapt<List<PRodsResponse>>();
            } else {
                var result = await _dbConnection.GetAsync<Prod>(request.Id);
                if ( result == null ) return NotFound("No se localizo el producto solicitado");
                
                response.Add(result.Adapt<PRodsResponse>());

            }
            
            return Ok(response);
        }
    }
}
