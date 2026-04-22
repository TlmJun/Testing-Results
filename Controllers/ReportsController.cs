using Microsoft.AspNetCore.Mvc;

namespace PerformanceAnalysis.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("group-leaders")]
        public async Task<IActionResult> GetGroupLeaders([FromQuery] GroupLeadersAndLaggardsFilter filter)
        {
            var result = await _reportService.GetGroupLeadersAndLaggardsAsync(filter);
            return Ok(result);
        }

        [HttpGet("student-test-results")]
        public async Task<IActionResult> GetStudentTestResults([FromQuery] StudentTestResultsFilter filter)
        {
            var result = await _reportService.GetStudentTestResultsAsync(filter);
            return Ok(result);
        }

        [HttpGet("group-trend")]
        public async Task<IActionResult> GetGroupTrend([FromQuery] GroupTrendFilter filter)
        {
            var result = await _reportService.GetGroupTrendAsync(filter);
            return Ok(result);
        }


        [HttpGet("student-monthly-progress")]
        public async Task<IActionResult> GetStudentMonthlyProgress([FromQuery] StudentMonthlyProgressFilter filter)
        {
            var result = await _reportService.GetStudentMonthlyProgressAsync(filter);
            return Ok(result);
        }

        [HttpGet("student-rating")]
        public async Task<IActionResult> GetStudentRating([FromQuery] StudentRatingFilter filter)
        {
            var result = await _reportService.GetStudentRatingAsync(filter);
            return Ok(result);
        }

        [HttpGet("student-pass-rate")]
        public async Task<IActionResult> GetStudentPassRate([FromQuery] StudentPassRateFilter filter)
        {
            var result = await _reportService.GetStudentPassRateAsync(filter);
            return Ok(result);
        }

        [HttpGet("student-pass-rate-summary")]
        public async Task<IActionResult> GetStudentPassRateSummary([FromQuery] StudentPassRateSummaryFilter filter)
        {
            var result = await _reportService.GetStudentPassRateSummaryAsync(filter);
            return result is null ? NotFound() : Ok(result);
        }

        [HttpGet("day-of-week-activity")]
        public async Task<IActionResult> GetDayOfWeekActivity([FromQuery] DayOfWeekActivityFilter filter)
        {
            var result = await _reportService.GetDayOfWeekActivityAsync(filter);
            return Ok(result);
        }



    }
}
