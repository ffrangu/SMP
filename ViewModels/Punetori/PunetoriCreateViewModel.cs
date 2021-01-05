using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.ViewModels.Punetori
{
        public class PunetoriCreateViewModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public string Emri { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public string Mbiemri { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public string NumriPersonal { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public DateTime Datelindja { get; set; }


        public string Adresa { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public int KomunaId { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public int KompaniaId { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public int DepartamentiId { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public int PozitaId { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public int BankaId { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public string Xhirollogaria { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushen!")]
        public int GradaId { get; set; }

        
        public DateTime Created { get; set; }

        
        public string CreatedBy { get; set; }

    }

    public class PunetoriListViewModel
    {
        public int Id { get; set; }
        public string Emri { get; set; }

        public string Mbiemri { get; set; }

        public string NumriPersonal { get; set; }

        public DateTime Datelindja { get; set; }

        public string Adresa { get; set; }

        public int KomunaId { get; set; }

        public string Komuna { get; set; }

        public int KompaniaId { get; set; }

        public string Kompania { get; set; }

        public int DepartamentiId { get; set; }

        public string Departamenti { get; set; }

        public int PozitaId { get; set; }

        public string Pozita { get; set; }

        public int BankaId { get; set; }

        public string Banka { get; set; }

        public string Xhirollogaria { get; set; }

        public int GradaId { get; set; }

        public string Grada { get; set; }

    }
}


