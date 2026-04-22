public class StudentPassRateFilter
{
    public int? GroupId { get; set; }
}

public class StudentPassRateItem
{
    public int StudentId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public int TestsAvailable { get; set; }
    public int TestsPassed { get; set; }
    public decimal PassRate { get; set; } // 0-100
}