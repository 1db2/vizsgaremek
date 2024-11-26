﻿using System;
using System.Collections.Generic;

namespace ProjektBackend.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public int UserId { get; set; }

    public string FullName { get; set; } = null!;

    public string? Headline { get; set; }

    public string? Bio { get; set; }

    public string? Location { get; set; }

    public string? ProfilePicture { get; set; }

    public virtual User User { get; set; } = null!;
}