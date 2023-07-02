using System;
using System.Collections.Generic;

namespace Repository.entities;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string IdNumber { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public int Gender { get; set; }

    public string Hmo { get; set; }

}
