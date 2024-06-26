using System;
using System.Collections.Generic;

namespace ApiAuthorization.Models;

public partial class Patient
{
    public long Oms { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateOnly Birthdate { get; set; }

    public string Address { get; set; } = null!;

    public string? LivingAddress { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Nickname { get; set; }
}
