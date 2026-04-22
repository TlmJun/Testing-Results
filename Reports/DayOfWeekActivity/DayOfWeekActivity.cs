public class DayOfWeekActivityFilter
{
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public int? GroupId { get; set; } // Опциональный фильтр по группе
}

public class DayOfWeekActivityItem
{
    public int DayOfWeek { get; set; } // 0=Sunday, 1=Monday, ... 6=Saturday
    public string DayName { get; set; } = string.Empty; // "Пн", "Вт", ...
    public int TestsCompleted { get; set; } // Количество завершённых попыток
    public int UniqueStudents { get; set; } // Уникальные студенты (опционально)
}