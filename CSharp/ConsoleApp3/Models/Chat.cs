using System;
using System.Collections.Generic;

namespace ConsoleApp3.Models;

public partial class Chat
{
    public int Id { get; set; }

    public int UserOneId { get; set; }

    public int UserTwoId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual Profile UserOne { get; set; } = null!;

    public virtual Profile UserTwo { get; set; } = null!;
}
