using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public class TanqueLeve : Tanque
    {
        private bool _ATGM;
        private bool _CanhaoAutomatico;
        private bool _Paraquedismo;

        [Display(Name = "Possui ATGM")]
        public bool ATGM { get => _ATGM; set => _ATGM = value; }

        [Display(Name = "Possui canhão automático")]
        public bool CanhaoAutomatico { get => _CanhaoAutomatico; set => _CanhaoAutomatico = value; }

        [Display(Name = "Pode ser utilizado em operações paraquedistas")]
        public bool Paraquedismo { get => _Paraquedismo; set => _Paraquedismo = value; }
    }
}
