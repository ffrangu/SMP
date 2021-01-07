﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.ViewModels.Bonuset
{
    public class BonusetCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ju lutem plotësoni fushën!")]
        public int Muaji { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushën!")]
        public int Viti { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushën!")]
        public int PunetoriId { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushën!")]
        public string Pershkrimi { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushën!")]
        public decimal Vlera { get; set; }

        [Required(ErrorMessage = "Ju lutem plotësoni fushën!")]
        public bool Bruto { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

    }
}
