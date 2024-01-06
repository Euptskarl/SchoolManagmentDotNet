using System;
using System.Collections.Generic;

namespace MVCApp.Data;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? Dob { get; set; }
}
