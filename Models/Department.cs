using System;
using System.Collections.Generic;

namespace Retail_Web_DFA.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }
}
