﻿using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class ProfilesApi
{
    public long ProfileId { get; set; }

    public string ProfileReferenceNo { get; set; } = null!;

    public string ProfileDescription { get; set; } = null!;
}
