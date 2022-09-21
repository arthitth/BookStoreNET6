using System;
using System.Collections.Generic;

namespace Web.API.Models
{
    public partial class Tpol
    {
        public string PolId { get; set; } = null!;
        public string StsCd { get; set; } = null!;
        public string StsStk { get; set; } = null!;
        public string StsCofm { get; set; } = null!;
        public string PlanCd { get; set; } = null!;
        public string PlanTxt { get; set; } = null!;
        public string PrtDt { get; set; } = null!;
        public string BillMd { get; set; } = null!;
        public string BillTyp { get; set; } = null!;
        public string AppId { get; set; } = null!;
        public string InsurTitle { get; set; } = null!;
        public string InsurNm { get; set; } = null!;
        public string InsurSnm { get; set; } = null!;
        public string PayTitle { get; set; } = null!;
        public string PayNm { get; set; } = null!;
        public string PaySnm { get; set; } = null!;
        public string Addr01 { get; set; } = null!;
        public string Addr02 { get; set; } = null!;
        public string Addr03 { get; set; } = null!;
        public string CityNm { get; set; } = null!;
        public string ProvNm { get; set; } = null!;
        public string PostCd { get; set; } = null!;
        public string AgtCd { get; set; } = null!;
        public string AgtNm { get; set; } = null!;
        public string AgtBrnCd { get; set; } = null!;
        public string AgtBrnTxt { get; set; } = null!;
    }
}
