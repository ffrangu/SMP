using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.ViewModels.Pozita
{
    public class PozitaCreateViewModel
    {
    }

    public class PozitaListViewModel
    {
        public int Id { get; set; }

        public int KompaniaId { get; set; }

        public string Kompania { get; set; }

        public int DepartmentiId { get; set; }

        public string Departamenti { get; set; }

        public string Emri { get; set; }

        public bool Status { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }
    }
}
