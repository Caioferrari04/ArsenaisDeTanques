using ArsenalDeTanques.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArsenalDeTanques.Services
{
    public class TanqueAdditionalService
    {
        /*Serviço utilizado para operações adicionais da tabela Tanque, 
         que não participam inteiramente do CRUD, e que não
         possuem a necessidade de padronizar*/
        public int totalTripulacao(List<Tanque> tanques)
        {
            if(tanques.Count > 0) { 
                int totalMembros = 0;
                foreach (Tanque tanque in tanques)
                    totalMembros += tanque.QuantidadeTripulacao;
                return totalMembros;
            }
            return 0;
        }

        public string tanqueRecente(List<Tanque> tanques)
        {
            if (tanques.Count > 0)
            {
                DateTime tanqueMaisRecente = tanques.Max(t => t.DataFabricacao);
                foreach (Tanque tanque in tanques)
                {
                    if (tanque.DataFabricacao == tanqueMaisRecente)
                        return tanque.Nome;
                }
            }
                
            return "ERRO: Não existe nenhum tanque.";
        }

        public string maiorMotor(List<Tanque> tanques)
        {
            if(tanques.Count > 0) { 
                int maiorMotor = (int)tanques.Max(t => t.PotenciaMotor);
                foreach (Tanque tanque in tanques)
                {
                    if (tanque.PotenciaMotor == maiorMotor)
                        return tanque.Nome;
                }
            }
            return "ERRO: Não existe nenhum tanque.";
        }

        public string maisCaro(List<Tanque> tanques)
        {
            if(tanques.Count > 0)
            {
                int maisCaro = (int)tanques.Max(t => t.PrecoCompra);
                foreach (Tanque tanque in tanques)
                {
                    if (tanque.PrecoCompra == maisCaro)
                        return tanque.Nome;
                }
            }
            return "ERRO: Não existe nenhum tanque.";
        }

        /*Utilizados em Seed.cs para evitar o erro "Merge conflict with ID", identificam o ID de nacionalidades
         e tipos a partir de seus nomes, e os devolvem.*/
        public int GetIdFromTipo(string nome, List<TipoTanque> tipos)
        {
            TipoTanque tanque = tipos.FirstOrDefault(p => p.NomeTipo.ToLower().Contains(nome.ToLower()));
            return tanque.id;
        }

        public int GetIdFromNacionalidade(string nome, List<Nacionalidade> nacoes) 
        {
            Nacionalidade nacao = nacoes.FirstOrDefault(p => p.Nome.ToLower().Contains(nome.ToLower()));
            return nacao.Id;
        }
    }
}
