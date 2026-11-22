using System;
using System.Collections.Generic;
using System.Text;
namespace taskmenedger.Model;

/// <summary>Задача в расписании.</summary>
public class TaskItem
{
    public int Id { get; set; }
    public int? CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public DateTime StartTime { get; set; } = DateTime.Now;
    public DateTime EndTime { get; set; } = DateTime.Now.AddHours(1);
    public int RemindBeforeMinutes { get; set; } = 10;
    public int Priority { get; set; } = 1; // 0 низкий, 1 средний, 2 высокий
    public bool IsDone { get; set; }
    public bool IsReminded { get; set; }

    /// <summary>Время задачи в виде строки «09:00 – 10:00».</summary>
    public string TimeText => $"{StartTime:HH:mm} – {EndTime:HH:mm}";

    /// <summary>Название приоритета для таблицы.</summary>
    public string PriorityText => Priority switch
    {
        0 => "Низкий",
        2 => "Высокий",
        _ => "Средний"
    };
}