
using Dapper;
using PerformanceAnalysis.Infrastructure.Reports;
using System.Data;

public class ReportService : IReportService
{
    private readonly IDapperExecutor _dapper;

    public ReportService(IDapperExecutor dapper)
    {
        _dapper = dapper;
    }

    public async Task<IEnumerable<GroupLeadersAndLaggardsItem>> GetGroupLeadersAndLaggardsAsync(GroupLeadersAndLaggardsFilter filter)
    {
        return await _dapper.QueryAsync<GroupLeadersAndLaggardsItem>(
            ReportQueries.GroupLeadersAndLaggards, filter);
    }

    public async Task<IEnumerable<StudentTestResultsItem>> GetStudentTestResultsAsync(StudentTestResultsFilter filter)
    {
        return await _dapper.QueryAsync<StudentTestResultsItem>(
            ReportQueries.StudentTestResults, filter);
    }

    public async Task<IEnumerable<GroupTrendItem>> GetGroupTrendAsync(GroupTrendFilter filter)
    {
        return await _dapper.QueryAsync<GroupTrendItem>(
            ReportQueries.GroupTrend,
            new { GroupIds = filter.GroupIds?.ToArray(), filter.DateFrom, filter.DateTo });
    }

    public async Task<IEnumerable<StudentRatingItem>> GetStudentRatingAsync(StudentRatingFilter filter)
    {
        return await _dapper.QueryAsync<StudentRatingItem>(ReportQueries.StudentRating, filter);
    }

    public async Task<IEnumerable<StudentMonthlyProgressItem>> GetStudentMonthlyProgressAsync(StudentMonthlyProgressFilter filter)
    {
        return await _dapper.QueryAsync<StudentMonthlyProgressItem>(ReportQueries.StudentMonthlyProgress, filter);
    }

    public async Task<IEnumerable<StudentPassRateItem>> GetStudentPassRateAsync(StudentPassRateFilter filter)
    {
        return await _dapper.QueryAsync<StudentPassRateItem>(ReportQueries.StudentPassRate, filter);
    }

    public async Task<StudentPassRateSummaryItem?> GetStudentPassRateSummaryAsync(StudentPassRateSummaryFilter filter)
    {
        return await _dapper.QueryFirstOrDefaultAsync<StudentPassRateSummaryItem>(ReportQueries.StudentPassRateSummary, filter);
    }

    public async Task<IEnumerable<DayOfWeekActivityItem>> GetDayOfWeekActivityAsync(DayOfWeekActivityFilter filter)
    {
        return await _dapper.QueryAsync<DayOfWeekActivityItem>(ReportQueries.DayOfWeekActivity, filter);
    }
}
