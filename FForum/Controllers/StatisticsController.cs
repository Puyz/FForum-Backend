using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstracts;

namespace FForum.Controllers
{
    [Route("api/statistics")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        IStatisticsService statisticsService;

        public StatisticsController(IStatisticsService statisticsService) {
            this.statisticsService = statisticsService;
        }

        [HttpGet]
        public IActionResult GetStatistics() {
            return Ok(statisticsService.GetStatistics());
        }
    }
}
