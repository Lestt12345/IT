using System;
using System.Collections.Generic;

namespace db_project2.Models;

public partial class Message
{
    public int Id { get; set; }

    public string Mess { get; set; } = null!;

    public int UserId { get; set; }

    public int ChatId { get; set; }

    public DateTime DateOfSend { get; set; }

    public bool? IsRead { get; set; }

    public virtual Chat Chat { get; set; } = null!;

    public virtual Profile User { get; set; } = null!;
}
