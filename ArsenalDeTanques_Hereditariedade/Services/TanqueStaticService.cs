using ArsenalDeTanques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Services
{
    public class TanqueStaticService : ITanquesStatic
    {
        List<Tanque> getTanques()
        {
            List<Tanque> tanques = new List<Tanque>();
            tanques.Add(new TanqueLeve
            {
                Id = 1,
                Nome = "AMX-13",
                Calibre = 75,
                PotenciaMotor = 270,
                QuantidadeTripulacao = 3,
                DataFabricacao = new DateTime(1946, 6, 22),
                Velocidade = 65,
                Paraquedismo = false,
                ATGM = false,
                CanhaoAutomatico = false,
            });
            tanques.Add(new TanqueMedio
            {
                Id = 2,
                Nome = "Lorraine 40t",
                Calibre = 100,
                PotenciaMotor = 850,
                QuantidadeTripulacao = 4,
                DataFabricacao = new DateTime(1949, 9, 15),
                Velocidade = 65,
                Autoloader = true
            });
            tanques.Add(new CacaTanque
            {
                Id = 3,
                Nome = "M10",
                Calibre = 76,
                PotenciaMotor = 410,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1942, 3, 29),
                Velocidade = 49,
                ATGM = false,
                Torre = true
            });
            tanques.Add(new CacaTanque
            {
                Id = 4,
                Nome = "Ho-Ri",
                Calibre = 105,
                PotenciaMotor = 1100,
                QuantidadeTripulacao = 6,
                DataFabricacao = new DateTime(1945, 3, 3),
                Velocidade = 40,
                ATGM = false,
                Torre = false
            });
            tanques.Add(new TanquePesado
            {
                Id = 5,
                Nome = "T34",
                Calibre = 120,
                PotenciaMotor = 810,
                QuantidadeTripulacao = 6,
                DataFabricacao = new DateTime(1944, 11, 25),
                Velocidade = 32,
                VelocidadeMaxima = 22
            });
            tanques.Add(new CacaTanque
            {
                Id = 6,
                Nome = "Type 75 SPH",
                Calibre = 155,
                PotenciaMotor = 450,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1965, 8, 16),
                Velocidade = 47,
                Torre = true,
                ATGM = false
            });
            tanques.Add(new TanquePesado
            {
                Id = 7,
                Nome = "Tiger",
                Calibre = 88,
                PotenciaMotor = 700,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1942, 10, 23),
                Velocidade = 45,
                VelocidadeMaxima = 25
            });
            tanques.Add(new CacaTanque
            {
                Id = 8,
                Nome = "M36",
                Calibre = 90,
                PotenciaMotor = 500,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1944, 10, 27),
                Velocidade = 45,
                ATGM = false,
                Torre = true
            });
            tanques.Add(new TanquePesado
            {
                Id = 9,
                Nome = "Churchill mk.VII",
                Calibre = 75,
                PotenciaMotor = 350,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1939, 7, 14),
                Velocidade = 20,
                VelocidadeMaxima = 20
            });
            tanques.Add(new TanqueMedio
            {
                Id = 10,
                Nome = "Panther II",
                Calibre = 88,
                PotenciaMotor = 900,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1945, 2, 1),
                Velocidade = 54,
                MBT = false,
                Autoloader = false
            });
            tanques.Add(new TanqueAnfibio
            {
                Id = 11,
                Nome = "PT-76B",
                Calibre = 76,
                PotenciaMotor = 300,
                QuantidadeTripulacao = 3,
                DataFabricacao = new DateTime(1950, 5, 2),
                Velocidade = 44,
                VelocidadeAquatica = 8,
                CapacidadeTransporte = 0
            });
            tanques.Add(new TanqueAnfibio
            {
                Id = 12,
                Nome = "BMP-1",
                Calibre = 73,
                PotenciaMotor = 300,
                QuantidadeTripulacao = 3,
                DataFabricacao = new DateTime(1965, 5, 2),
                Velocidade = 66,
                VelocidadeAquatica = 9,
                CapacidadeTransporte = 8
            });
            tanques.Add(new TanqueAnfibio
            {
                Id = 13,
                Nome = "AMX-10RC",
                Calibre = 105,
                PotenciaMotor = 280,
                QuantidadeTripulacao = 4,
                DataFabricacao = new DateTime(1980, 5, 2),
                Velocidade = 95,
                VelocidadeAquatica = 10,
                CapacidadeTransporte = 0

            });
            tanques.Add(new TanqueAnfibio
            {
                Id = 14,
                Nome = "AUBL/74",
                Calibre = 90,
                PotenciaMotor = 160,
                QuantidadeTripulacao = 3,
                DataFabricacao = new DateTime(1974, 5, 2),
                Velocidade = 100,
                VelocidadeAquatica = 7,
                CapacidadeTransporte = 10
            });
            return tanques;
        }
        public dynamic Create(dynamic tanqueCriado)
        {
            try { 
                List<Tanque> tanques = getTanques();
                tanqueCriado.Id = tanques.Max(p => p.Id) + 1;
                tanques.Add(tanqueCriado);
                return tanqueCriado;
            }
            catch
            {
                throw new EntryPointNotFoundException();
            }
        }

        public List<Tanque> Delete(int id)
        {
            try
            {
                List<Tanque> tanques = getTanques();
                Tanque tanque = tanques.FirstOrDefault(t => t.Id == id);

                if (tanque != null)
                {
                    tanques.Remove(tanque);
                }
                return tanques;
            }
            catch
            {
                throw new Exception();
            }
        }

        public dynamic Get(int id)
        {
            Tanque tanque = getTanques().FirstOrDefault(p => p.Id == id);
            return tanque != null ? tanque : null;
        }

        public List<Tanque> GetAll(string busca = null, bool ord = false)
        {

            if (ord == true)
            {
                var lista = getTanques();
                //lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return busca != null ? getTanques().FindAll(a =>a.Nome.ToLower().Contains(busca.ToLower())) : getTanques();
        }

        public dynamic UpdateOne(dynamic tanqueEditado)
        {
            List<Tanque> tanques = getTanques();
            var tanqueOriginal = tanques.FirstOrDefault(t => t.Nome == tanqueEditado.Nome);
            if (tanqueOriginal != null) { 
                int indice = tanques.IndexOf(tanqueOriginal);
                tanques[indice] = tanqueEditado;
            }
            return tanqueEditado;
        }

        //public List<Tanque> UpdateOne(TanqueMedio tanque)
        //{
        //    List<Tanque> tanques = getTanques();
        //    var tanqueOriginal = tanques.FirstOrDefault(t => t.Id == tanque.Id);
        //    if (tanqueOriginal == null)
        //    {
        //        int indice = tanques.IndexOf(tanqueOriginal);
        //        tanques[indice] = tanque;
        //    }
        //    return tanques;
        //}

        //public List<Tanque> UpdateOne(TanquePesado tanque)
        //{
        //    List<Tanque> tanques = getTanques();
        //    var tanqueOriginal = tanques.FirstOrDefault(t => t.Id == tanque.Id);
        //    if (tanqueOriginal == null)
        //    {
        //        int indice = tanques.IndexOf(tanqueOriginal);
        //        tanques[indice] = tanque;
        //    }
        //    return tanques;
        //}

        //public List<Tanque> UpdateOne(CacaTanque tanque)
        //{
        //    List<Tanque> tanques = getTanques();
        //    var tanqueOriginal = tanques.FirstOrDefault(t => t.Id == tanque.Id);
        //    if (tanqueOriginal == null)
        //    {
        //        int indice = tanques.IndexOf(tanqueOriginal);
        //        tanques[indice] = tanque;
        //    }
        //    return tanques;
        //}

        //public List<Tanque> UpdateOne(TanqueAnfibio tanque)
        //{
        //    List<Tanque> tanques = getTanques();
        //    var tanqueOriginal = tanques.FirstOrDefault(t => t.Id == tanque.Id);
        //    if (tanqueOriginal == null)
        //    {
        //        int indice = tanques.IndexOf(tanqueOriginal);
        //        tanques[indice] = tanque;
        //    }
        //    return tanques;
        //}
    }
}
