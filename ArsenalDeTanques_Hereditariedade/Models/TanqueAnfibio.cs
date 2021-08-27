using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public class TanqueAnfibio : Tanque
    {
        private int _VelocidadeAquatica;
        private int _CapacidadeTransporte;

        [Display(Name = "Velocidade aquática")]
        public int VelocidadeAquatica { 
            get => _VelocidadeAquatica; 
            set => _VelocidadeAquatica = value; 
        }

        [Display(Name = "Capacidade de Transporte")]
        public int CapacidadeTransporte { 
            get => _CapacidadeTransporte; 
            set => _CapacidadeTransporte = value; 
        }
    }
}
