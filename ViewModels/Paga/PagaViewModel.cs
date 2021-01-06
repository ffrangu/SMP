using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.ViewModels.Paga
{
    public class PagaViewModel
    {
        public int Viti { get; set; }

        public int Muaji { get; set; }

        public string Data { get; set; }

        public string Kompania { get; set; }

        public string Pershkrimi { get; set; }
    }

    public class PagaCreateViewModel
    {
        [Required(ErrorMessage = "Plotësoni fushën")]
        public int KompaniaId { get; set; }
        [Required(ErrorMessage = "Plotësoni fushën")]
        public string Pershkrimi { get; set; }
        [Required(ErrorMessage = "Plotësoni fushën")]
        public int Muaji { get; set; }
        [Required(ErrorMessage = "Plotësoni fushën")]
        public int Viti { get; set; }
    }
}
