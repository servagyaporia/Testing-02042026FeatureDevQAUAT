using System;
using System.Collections.Generic;

namespace Retail_Web_DFA.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
