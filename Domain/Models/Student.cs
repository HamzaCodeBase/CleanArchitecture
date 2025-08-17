using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public virtual StudentDetail? StudentDetail { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
