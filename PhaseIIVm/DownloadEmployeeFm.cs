﻿namespace SelfPortalAPi.PhaseIIVm
{
    public class DownloadEmployeeFm
    {
        public string? CompanyRin { get; set; }
        public string? BusinessRin { get; set; }
        public int TaxYear { get; set; }
        public string? TaxMonth { get; set; }
    }

    public class TccSent{
        public List<int> EmployeeIds{get;set;}
        public string busId{get;set;}
    }
    public class TccSentToEras{
        public int TaxPayerID{get;set;}
        public int TaxYear{get;set;}
    }
   
public class EmployeeStatus
{
    public string EmployeeId { get; set; }
    public string EmployeeRIN { get; set; }
    public string EmployeeName { get; set; }
    public string TCCStatus { get; set; }
}
    public class DownloadEmployeeResponse
    {
        public string? EmployeeRin { get; set; }
        public string? FullName { get; set; }
        public string? PHONENUMBER { get; set; }
        public string? NIN { get; set; }
        public string? NATIONALITY { get; set; }
        public int? TaxYear { get; set; }
        public string? TaxMonth { get; set; }
        public decimal? GrossIncome { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? NonTaxibleIncome { get; set; }
        public decimal? Cra { get; set; }
        public decimal? Tfp { get; set; }
        public decimal? Ci { get; set; }
        public decimal? Tax { get; set; }

    }

}
