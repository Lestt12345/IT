using System;
using System.Collections.Generic;

namespace ConsoleApp3.Models;

public partial class Rating
{
    public int Id { get; set; }

    public int SenderId { get; set; }

    public int SellerId { get; set; }

    public decimal Grade { get; set; }

    public virtual Profile Seller { get; set; } = null!;

    public virtual Profile Sender { get; set; } = null!;
}
