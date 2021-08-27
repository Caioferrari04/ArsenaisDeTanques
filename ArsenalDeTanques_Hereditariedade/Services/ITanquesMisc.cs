using ArsenalDeTanques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Services
{
    public interface ITanquesMisc
    {
        public int totalTripulacao(List<Tanque> tanques);
        public string tanqueRecente(List<Tanque> tanques);
        public string maiorMotor(List<Tanque> tanques);
        public List<Tanque> ordenarTanques(List<Tanque> tanques);
    }
}
