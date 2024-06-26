using System;
using System.Collections.Generic;

namespace ApiAuthorization.Models;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string EnterPassword { get; set; } = null!;
}
