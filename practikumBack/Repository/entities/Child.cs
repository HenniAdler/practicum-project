using System;
using System.Collections.Generic;

namespace Repository.entities;

public partial class Child
{
    public int ChildId { get; set; }

    public string FirstName { get; set; } = null!;

    public string IdNumber { get; set; } = null!;

    public DateTime DateOfBirth { get; set; } 

    public int FatherId { get; set; }

    public int MotherId { get; set; }

    
}
