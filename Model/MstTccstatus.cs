﻿using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MstTccstatus
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public bool? Active { get; set; }
}
