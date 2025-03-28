﻿using System;
using System.Collections.Generic;

namespace ConsoleApp3.Models;

public partial class Image
{
    public int Id { get; set; }

    public string? ImageUrl { get; set; }

    public virtual Profile? ProfileAvatarNavigation { get; set; }

    public virtual Profile? ProfileBannerNavigation { get; set; }
}
