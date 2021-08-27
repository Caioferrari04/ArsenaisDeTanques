using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public class TanquePesado : Tanque
    {
        private int _VelocidadeMaxima;

        [Display(Name = "Velocidade máxima sem danos ao motor")]
        public int VelocidadeMaxima { get => _VelocidadeMaxima; set => _VelocidadeMaxima = value; }
    }
}
