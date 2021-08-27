using ArsenalDeTanques.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArsenalDeTanques.Services
{
    public class TanquesStaticService : ICrudService
    {
        List<Tanque> getTanques()
        {
            List<Tanque> tanques = new List<Tanque>();
            tanques.Add(new Tanque
            {
                Id = 1,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/2/2e/GarageImage_AMX-13.jpg/800px-GarageImage_AMX-13.jpg",
                Nome = "AMX-13",
                Calibre = 75,
                PotenciaMotor = 270,
                QuantidadeTripulacao = 3,
                DataFabricacao = new DateTime(1946, 6, 22),
                Velocidade = 65,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 2,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/3/31/GarageImage_Lorraine_40t.jpg/800px-GarageImage_Lorraine_40t.jpg",
                Nome = "Lorraine 40t",
                Calibre = 100,
                PotenciaMotor = 850,
                QuantidadeTripulacao = 4,
                DataFabricacao = new DateTime(1949, 9, 15),
                Velocidade = 65,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 3,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/5/5c/GarageImage_M10_GMC.jpg/800px-GarageImage_M10_GMC.jpg",
                Nome = "M10",
                Calibre = 76,
                PotenciaMotor = 410,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1942, 3, 29),
                Velocidade = 49,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 4,
                LinkImagem = "https://wiki.warthunder.com/images/d/d7/GarageImage_Ho-Ri_Production.jpg",
                Nome = "Ho-Ri",
                Calibre = 105,
                PotenciaMotor = 1100,
                QuantidadeTripulacao = 6,
                DataFabricacao = new DateTime(1945, 3, 3),
                Velocidade = 40,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 5,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/a/ac/GarageImage_T34.jpg/800px-GarageImage_T34.jpg",
                Nome = "T34",
                Calibre = 120,
                PotenciaMotor = 810,
                QuantidadeTripulacao = 6,
                DataFabricacao = new DateTime(1944, 11, 25),
                Velocidade = 32,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 6,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/5/5f/GarageImage_Type_75_SPH.jpg/800px-GarageImage_Type_75_SPH.jpg",
                Nome = "Type 75 SPH",
                Calibre = 155,
                PotenciaMotor = 450,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1965, 8, 16),
                Velocidade = 47,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 7,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/2/29/GarageImage_Tiger_H1.jpg/800px-GarageImage_Tiger_H1.jpg",
                Nome = "Tiger",
                Calibre = 88,
                PotenciaMotor = 700,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1942, 10, 23),
                Velocidade = 45,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 8,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/3/32/GarageImage_M36_GMC.jpg/800px-GarageImage_M36_GMC.jpg",
                Nome = "M36",
                Calibre = 90,
                PotenciaMotor = 500,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1944, 10, 27),
                Velocidade = 45,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 9,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/0/04/GarageImage_Churchill_VII.jpg/800px-GarageImage_Churchill_VII.jpg",
                Nome = "Churchill mk.VII",
                Calibre = 75,
                PotenciaMotor = 350,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1939, 7, 14),
                Velocidade = 20,
                PrecoCompra = 25000
            });
            tanques.Add(new Tanque
            {
                Id = 10,
                LinkImagem = "https://wiki.warthunder.com/images/thumb/c/c8/GarageImage_Panther_II.jpg/800px-GarageImage_Panther_II.jpg",
                Nome = "Panther II",
                Calibre = 88,
                PotenciaMotor = 900,
                QuantidadeTripulacao = 5,
                DataFabricacao = new DateTime(1945, 2, 1),
                Velocidade = 54,
                PrecoCompra = 10000000
            });
            return tanques;
        }
        public bool Create(Tanque tanqueCriado)
        {
            try
            {
                List<Tanque> tanques = getTanques();
                tanqueCriado.Id = tanques.Max(p => p.Id) + 1;
                tanques.Add(tanqueCriado);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                List<Tanque> tanques = getTanques();
                Tanque tanque = tanques.FirstOrDefault(t => t.Id == id);

                if (tanque != null)
                {
                    tanques.Remove(tanque);
                }
                return true;
            }
            catch
            {
                throw new Exception();
            }
        }

        public Tanque Get(int id, bool visitou = false)
        {
            Tanque tanque = getTanques().FirstOrDefault(p => p.Id == id);
            if (visitou) tanque.Visitas += 1;
            return tanque != null ? tanque : null;
        }

        public List<Tanque> GetAll(string busca = null, string ord = null)
        {
            /*Achei útil utilizar o contains nessa situação, mesmo que redundante,
            para ter mais facilidade em manipular futuras aplicações utilizando a variável servico.*/
            if (ord != null ? ord.Contains("ord") : false)
            {
                var lista = getTanques();
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return busca != null ? getTanques().FindAll(a => a.Nome.ToLower().Contains(busca.ToLower())) : getTanques();
        }

        public bool Update(Tanque tanqueEditado)
        {
            try
            {
                List<Tanque> tanques = getTanques();
                var tanqueOriginal = tanques.FirstOrDefault(t => t.Nome == tanqueEditado.Nome);
                if (tanqueOriginal != null)
                {
                    int indice = tanques.IndexOf(tanqueOriginal);
                    tanques[indice] = tanqueEditado;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Tanque> GetDestaques(List<Tanque> tanques)
        {
            List<Tanque> tanquesDestaque = new List<Tanque>();
            var newtanques = tanques.OrderByDescending(p => p.Visitas).ToList();
            int i = 0;
            while (tanquesDestaque.Count < 5)
            {
                tanquesDestaque.Add(newtanques[i]);
                i++;
            }
            return tanquesDestaque;
        }
    }
}
