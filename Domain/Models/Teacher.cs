using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Subject123 { get; set; }

    public int? DepartmentId { get; set; }

    public int? CourseId { get; set; }

    public int? TestId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Department? Department { get; set; }
}
