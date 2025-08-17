using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class StudentDetail
{
    public int StudentId { get; set; }

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
