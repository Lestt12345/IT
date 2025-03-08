using System;
using System.Collections.Generic;

namespace db_project2.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public DateOnly? DateOfRegistration { get; set; }

    public virtual Profile? Profile { get; set; }
}
