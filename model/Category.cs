using System;
using System.Collections.Generic;
using System.Text;

namespace taskmenedger.Model;

/// <summary>Категория задач (например: Учёба, Работа).</summary>
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Color { get; set; } = "#3498DB";
}