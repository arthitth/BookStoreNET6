using System;
using System.Collections.Generic;

namespace Web.API.Models
{
    public partial class TbFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public byte[] Data { get; set; } = null!;
    }
}
