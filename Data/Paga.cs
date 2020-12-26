using System;
using System.Collections.Generic;

namespace SMP.Data
{
    public partial class Paga
    {
        public int Id { get; set; }
        public int PunetoriId { get; set; }
        public int GradaId { get; set; }
        public int Viti { get; set; }
        public int Muaji { get; set; }
        public decimal Bruto { get; set; }
        public decimal KontributiPunetori { get; set; }
        public decimal KontributiPunedhenesi { get; set; }
        public decimal PagaTatim { get; set; }
        public decimal Tatimi { get; set; }
        public decimal PagaNeto { get; set; }
        public decimal? Bonuse { get; set; }
        public decimal PagaFinale { get; set; }
        public int MenyraEkzekutimit { get; set; }
        public DateTime DataEkzekutimit { get; set; }
        public string CreatedBy { get; set; }

        public virtual Grada Grada { get; set; }
        public virtual Punetori Punetori { get; set; }
    }
}
