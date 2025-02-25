﻿using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapCertificateCustomField
{
    public int Ccfid { get; set; }

    public int? Ctfid { get; set; }

    public long? CertificateId { get; set; }

    public string? FieldValue { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Certificate? Certificate { get; set; }

    public virtual MapCertificateTypeField? Ctf { get; set; }
}
