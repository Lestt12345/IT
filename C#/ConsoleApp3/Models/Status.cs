using System;
using System.Collections.Generic;

namespace ConsoleApp3.Models;

public partial class Status
{
    public int Id { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<Advert> Adverts { get; set; } = new List<Advert>();
}
