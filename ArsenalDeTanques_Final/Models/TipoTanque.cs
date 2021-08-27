using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public class TipoTanque
    {
        public int id { get; set; }

        [Display(Name = "Tipo")]
        public string NomeTipo { get; set; }

        [Display(Name = "Ícone")]
        public string LinkImagem { get; set; }

        public List<Tanque> tanques { get; set; }
    }
}
