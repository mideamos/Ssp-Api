﻿using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwAssessmentRule
{
    public int? TaxPayerId { get; set; }

    public int TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public string? TaxPayerRin { get; set; }

    public string? AssessmentRuleId { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public int? ProfileId { get; set; }

    public string? AssessmentRuleName { get; set; }

    public int? RuleRunId { get; set; }

    public int? PaymentFrequencyId { get; set; }

    public string PaymentOptionName { get; set; } = null!;

    public string? TaxYear { get; set; }

    public string? TaxMonth { get; set; }

    public int? PaymentOptionId { get; set; }

    public int? AssetId { get; set; }

    public int AssetTypeId { get; set; }

    public string? AssetTypeName { get; set; }

    public string? AssetRin { get; set; }

    public string? ProfileReferenceNo { get; set; }

    public string RuleRunName { get; set; } = null!;

    public string PaymentFrequencyName { get; set; } = null!;

    public double? AssessmentAmount { get; set; }

    public string ProfileDescription { get; set; } = null!;
}
