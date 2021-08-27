using System.Collections.Generic;

namespace ArsenalDeTanques.Models
{
    public class Nacionalidade
    {
        public int Id { get ; set; }

        public string linkBandeira { get; set; }

        public string Nome { get; set; }

        public List<Tanque> tanques { get; set; }
    }
}
