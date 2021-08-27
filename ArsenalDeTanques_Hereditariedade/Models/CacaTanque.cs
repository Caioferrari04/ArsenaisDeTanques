using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public class CacaTanque : Tanque
    {
        private bool _Torre;
        private bool _ATGM;

        [Display(Name = "Possui torre")]
        public bool Torre { get=>_Torre; set=>_Torre = value; }

        [Display(Name = "Possui ATGM")]
        public bool ATGM { get=>_ATGM; set => _ATGM = value; }
    }
}
