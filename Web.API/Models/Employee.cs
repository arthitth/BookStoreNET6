using System;
using System.Collections.Generic;

namespace Web.API.Models
{
    public partial class Employee
    {
        public int Ref { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public short Age { get; set; }
    }
}
