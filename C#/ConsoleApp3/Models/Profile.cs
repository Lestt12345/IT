using System;
using System.Collections.Generic;

namespace ConsoleApp3.Models;

public partial class Profile
{
    public int Id { get; set; }

    public string Nickname { get; set; } = null!;

    public string VisibleName { get; set; } = null!;

    public string? Bio { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public int? Avatar { get; set; }

    public int? Banner { get; set; }

    public int Userid { get; set; }

    public virtual ICollection<Advert> Adverts { get; set; } = new List<Advert>();

    public virtual Image? AvatarNavigation { get; set; }

    public virtual Image? BannerNavigation { get; set; }

    public virtual ICollection<Chat> ChatUserOnes { get; set; } = new List<Chat>();

    public virtual ICollection<Chat> ChatUserTwos { get; set; } = new List<Chat>();

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Rating> RatingSellers { get; set; } = new List<Rating>();

    public virtual ICollection<Rating> RatingSenders { get; set; } = new List<Rating>();

    public virtual User User { get; set; } = null!;
}
