using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public class TanqueMedio : Tanque
    {
        private bool _Autoloader;
        private bool _MBT;

        [Display(Name = "Possui carregador automático")]
        public bool Autoloader { get => _Autoloader; set => _Autoloader = value; }

        [Display(Name = "É um MBT")]
        public bool MBT { get => _MBT; set => _MBT = value; }
    }
}
