using System;
using System.Collections.Generic;

namespace db_project2.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Advert> Adverts { get; set; } = new List<Advert>();
}
