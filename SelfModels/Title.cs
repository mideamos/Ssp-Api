﻿using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class Title
{
    public int TitleId { get; set; }

    public int TitleCreateBy { get; set; }

    public DateTime TitleCreateAt { get; set; }

    public string Gender { get; set; } = null!;

    public string Title1 { get; set; } = null!;

    public string TitleStatus { get; set; } = null!;
}
