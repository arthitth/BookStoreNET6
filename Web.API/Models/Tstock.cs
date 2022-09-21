using System;
using System.Collections.Generic;

namespace Web.API.Models
{
    public partial class Tstock
    {
        public string PolId { get; set; } = null!;
        public string PolBatchNo { get; set; } = null!;
        public string PolSts { get; set; } = null!;
        public string? StsCofm { get; set; }
        public string? StsTrnf { get; set; }
        public string PolStsDtl { get; set; } = null!;
        public string? OwnerNm { get; set; }
        public string? UsrKey { get; set; }
        public string? UsrTknm { get; set; }
        public string? UsrKdep { get; set; }
        public string DepReq { get; set; } = null!;
        public string UsrReq { get; set; } = null!;
        public string ReqDate { get; set; } = null!;
        public string ReqTime { get; set; } = null!;
        public string UsrRec { get; set; } = null!;
        public string? DepRec { get; set; }
        public string RecDate { get; set; } = null!;
        public string RecTime { get; set; } = null!;
        public decimal? WanDt { get; set; }
        public string StsDtl { get; set; } = null!;
        public string StsPrt { get; set; } = null!;
        public string? StsPrtFlag { get; set; }
    }
}
