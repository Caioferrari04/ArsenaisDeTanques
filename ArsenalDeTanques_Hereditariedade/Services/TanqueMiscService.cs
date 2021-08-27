using ArsenalDeTanques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Services
{
    public class TanqueMiscService : ITanquesMisc
    {
        public int totalTripulacao(List<Tanque> tanques)
        {
            int totalMembros = 0;
            foreach (Tanque tanque in tanques)
                totalMembros += tanque.QuantidadeTripulacao;
            return totalMembros;
        }

        public string tanqueRecente(List<Tanque> tanques)
        {
            DateTime tanqueMaisRecente = tanques.Max(t => t.DataFabricacao);
            foreach (Tanque tanque in tanques)
            {
                if (tanque.DataFabricacao == tanqueMaisRecente)
                    return tanque.Nome;
            }
            return "ERRO: Não existe nenhum tanque.";
        }

        public string maiorMotor(List<Tanque> tanques)
        {
            int maiorMotor = tanques.Max(t => t.PotenciaMotor);
            foreach (Tanque tanque in tanques)
            {
                if (tanque.PotenciaMotor == maiorMotor)
                    return tanque.Nome;
            }
            return "ERRO: Não existe nenhum tanque.";
        }

        public List<Tanque> ordenarTanques(List<Tanque> tanques)
        {
            return tanques.OrderBy(t => t.Nome).ToList();
        }
    }
}
