using System;
using System.Collections.Generic;

namespace Web.API.Models
{
    public partial class training
    {
        public int Ref { get; set; }
        public string Area { get; set; } = null!;
        public string Place { get; set; } = null!;
        public string Coudt { get; set; } = null!;
        public string Coutm { get; set; } = null!;
        public string Course { get; set; } = null!;
        public string Property { get; set; } = null!;
        public string Enddt { get; set; } = null!;
        public decimal Regisamt { get; set; }
        public string Regismax { get; set; } = null!;
        public int Count { get; set; }
        public string Status { get; set; } = null!;
        public string Crtdt { get; set; } = null!;
        public string Crttm { get; set; } = null!;
        public string Crtusr { get; set; } = null!;
        public string Upddt { get; set; } = null!;
        public string Updtm { get; set; } = null!;
        public string Updusr { get; set; } = null!;
    }
}
