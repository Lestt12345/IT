﻿using System;
using System.Collections.Generic;

namespace db_project2.Models;

public partial class Advert
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Bio { get; set; } = null!;

    public decimal? Price { get; set; }

    public DateTime DateOfPublication { get; set; }

    public int? CategoryId { get; set; }

    public int? StatusId { get; set; }

    public int? ProfileId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Profile? Profile { get; set; }

    public virtual Status? Status { get; set; }
}
