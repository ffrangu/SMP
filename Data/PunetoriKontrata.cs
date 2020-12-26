using System;
using System.Collections.Generic;

namespace SMP.Data
{
    public partial class PunetoriKontrata
    {
        public int Id { get; set; }
        public int PunetoriId { get; set; }
        public string Emri { get; set; }
        public string Path { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public virtual Punetori Punetori { get; set; }
    }
}
