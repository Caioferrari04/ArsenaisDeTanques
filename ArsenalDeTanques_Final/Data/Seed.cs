using ArsenalDeTanques.Models;
using ArsenalDeTanques.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArsenalDeTanques.Data
{
    public static class Seed
    {
        public static void Inicializar(IHost app)
        {
            TanqueAdditionalService service = new TanqueAdditionalService();
            
            using (var scope = app.Services.CreateScope())
            {
                List<TipoTanque> tanques = new List<TipoTanque>();
                List<Nacionalidade> nacionalidades = new List<Nacionalidade>();
                var provedorServico = scope.ServiceProvider;
                var context = provedorServico.GetRequiredService<ArsenalContext>();
                context.Database.Migrate();

                if (!context.TipoTanque.Any())
                {
                    context.TipoTanque.Add(new TipoTanque
                    {
                        NomeTipo = "Caça-Tanque",
                        LinkImagem = "https://wiki.warthunder.com/images/6/65/Tank_destroyers_icon.png"
                    });
                    context.TipoTanque.Add(new TipoTanque
                    {
                        NomeTipo = "Tanque médio",
                        LinkImagem = "https://wiki.warthunder.com/images/2/20/Medium_tanks_icon.png"
                    });
                    context.TipoTanque.Add(new TipoTanque
                    {
                        NomeTipo = "Tanque leve",
                        LinkImagem = "https://wiki.warthunder.com/images/4/45/Light_tanks_icon.png"
                    });
                    context.TipoTanque.Add(new TipoTanque
                    {
                        NomeTipo = "Tanque pesado",
                        LinkImagem = "https://wiki.warthunder.com/images/c/ca/Heavy_tanks_icon.png"
                    });
                }
                context.SaveChanges();
                tanques = context.TipoTanque.ToList();

                if (!context.Nacionalidade.Any())
                {
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People's_Republic_of_China.svg/2560px-Flag_of_the_People's_Republic_of_China.svg.png",
                        Nome = "China" //1
                    });
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Flag_of_the_United_States.svg/2560px-Flag_of_the_United_States.svg.png",
                        Nome = "USA" //2
                    });
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Flag_of_Italy.svg/2560px-Flag_of_Italy.svg.png",
                        Nome = "Itália" //3
                    });
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Russia.svg/2560px-Flag_of_Russia.svg.png",
                        Nome = "Rússia" //4
                    });
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Flag_of_Japan.svg/2560px-Flag_of_Japan.svg.png",
                        Nome = "Japão" //5
                    });
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Germany.svg/2560px-Flag_of_Germany.svg.png",
                        Nome = "Alemanha" //6
                    });
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Flag_of_France.svg/2560px-Flag_of_France.svg.png",
                        Nome = "França" //7
                    });
                    context.Nacionalidade.Add(new Nacionalidade
                    {
                        linkBandeira = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/2560px-Flag_of_the_United_Kingdom.svg.png",
                        Nome = "Reino Unido" //8
                    });
                }
                context.SaveChanges();
                nacionalidades = context.Nacionalidade.ToList();

                if (!context.Tanque.Any())
                {
                    context.Tanque.Add(new Tanque { 
                        LinkImagem = "https://www.army-technology.com/wp-content/uploads/sites/3/2017/09/3-ztz99.jpg",
                        Nome = "ZTZ99", 
                        DataFabricacao = new DateTime(1980,06,09), 
                        Calibre = 120, 
                        PotenciaMotor = 1200, 
                        QuantidadeTripulacao = 3, 
                        Velocidade = 65,
                        nacionalidadeId = service.GetIdFromNacionalidade("China",nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 65000.00,
                        tipoId = service.GetIdFromTipo("médio",tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://upload.wikimedia.org/wikipedia/commons/7/70/Centauro01.JPEG",
                        Nome = "Centauro I 120",
                        DataFabricacao = new DateTime(1970, 06, 09),
                        Calibre = 120,
                        PotenciaMotor = 510,
                        QuantidadeTripulacao = 4,
                        Velocidade = 110,
                        nacionalidadeId = service.GetIdFromNacionalidade("Itália", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 120000.00,
                        tipoId = service.GetIdFromTipo("leve", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/e/ee/GarageImage_Somua_SM.jpg",
                        Nome = "Somua SM",
                        DataFabricacao = new DateTime(1949, 06, 09),
                        Calibre = 100,
                        PotenciaMotor = 1000,
                        QuantidadeTripulacao = 5,
                        Velocidade = 41,
                        nacionalidadeId = service.GetIdFromNacionalidade("França", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 30000.00,
                        tipoId = service.GetIdFromTipo("médio", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/3/33/GarageImage_Caernarvon.jpg",
                        Nome = "Caernarvon",
                        DataFabricacao = new DateTime(1965, 06, 09),
                        Calibre = 84,
                        PotenciaMotor = 810,
                        QuantidadeTripulacao = 4,
                        Velocidade = 34,
                        nacionalidadeId = service.GetIdFromNacionalidade("Reino", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 20000.00,
                        tipoId = service.GetIdFromTipo("pesado", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/0/0f/GarageImage_M103.jpg/800px-GarageImage_M103.jpg",
                        Nome = "M103",
                        DataFabricacao = new DateTime(1955, 06, 09),
                        Calibre = 120,
                        PotenciaMotor = 810,
                        QuantidadeTripulacao = 5,
                        Velocidade = 34,
                        nacionalidadeId = service.GetIdFromNacionalidade("US", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 300000.00,
                        tipoId = service.GetIdFromTipo("pesado", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/2/2d/GarageImage_E-100.jpg",
                        Nome = "E100",
                        DataFabricacao = new DateTime(1945, 02, 20),
                        Calibre = 128,
                        PotenciaMotor = 900,
                        QuantidadeTripulacao = 6,
                        Velocidade = 40,
                        nacionalidadeId = service.GetIdFromNacionalidade("Alemanha", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 1000000.00,
                        tipoId = service.GetIdFromTipo("pesado", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/b/bb/GarageImage_Maus.jpg/800px-GarageImage_Maus.jpg",
                        Nome = "Maus",
                        DataFabricacao = new DateTime(1945, 02, 12),
                        Calibre = 128,
                        PotenciaMotor = 1200,
                        QuantidadeTripulacao = 6,
                        Velocidade = 22,
                        nacionalidadeId = service.GetIdFromNacionalidade("Alemanha", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 10000000.00,
                        tipoId = service.GetIdFromTipo("pesado", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/6/60/GarageImage_Matilda_III.jpg/800px-GarageImage_Matilda_III.jpg",
                        Nome = "Matilda III",
                        DataFabricacao = new DateTime(1933, 09, 28),
                        Calibre = 40,
                        PotenciaMotor = 190,
                        QuantidadeTripulacao = 4,
                        Velocidade = 24,
                        nacionalidadeId = service.GetIdFromNacionalidade("Reino", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 10000.00,
                        tipoId = service.GetIdFromTipo("pesado", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/a/a5/GarageImage_Type_90.jpg/1024px-GarageImage_Type_90.jpg",
                        Nome = "Type 90",
                        DataFabricacao = new DateTime(2000, 08, 22),
                        Calibre = 120,
                        PotenciaMotor = 1500,
                        QuantidadeTripulacao = 3,
                        Velocidade = 73,
                        nacionalidadeId = service.GetIdFromNacionalidade("Japão", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 50000000.00,
                        tipoId = service.GetIdFromTipo("médio", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/6/67/GarageImage_Object_685.jpg/800px-GarageImage_Object_685.jpg",
                        Nome = "Object 685",
                        DataFabricacao = new DateTime(1978, 05, 14),
                        Calibre = 100,
                        PotenciaMotor = 400,
                        QuantidadeTripulacao = 3,
                        Velocidade = 70,
                        nacionalidadeId = service.GetIdFromNacionalidade("Rússia", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 500000.00,
                        tipoId = service.GetIdFromTipo("leve", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/d/d3/GarageImage_Type_16.jpg/1024px-GarageImage_Type_16.jpg",
                        Nome = "Type 16",
                        DataFabricacao = new DateTime(2012, 02, 29),
                        Calibre = 105,
                        PotenciaMotor = 570,
                        QuantidadeTripulacao = 4,
                        Velocidade = 100,
                        nacionalidadeId = service.GetIdFromNacionalidade("Japão", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 600000.00,
                        tipoId = service.GetIdFromTipo("leve", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/b/ba/GarageImage_R3_T20_FA-HS.jpg/800px-GarageImage_R3_T20_FA-HS.jpg",
                        Nome = "RT T20 FA-HS",
                        DataFabricacao = new DateTime(1982, 08, 05),
                        Calibre = 20,
                        PotenciaMotor = 95,
                        QuantidadeTripulacao = 4,
                        Velocidade = 115,
                        nacionalidadeId = service.GetIdFromNacionalidade("Itália", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 5000.00,
                        tipoId = service.GetIdFromTipo("leve", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/2/2f/GarageImage_PTZ89.jpg/1024px-GarageImage_PTZ89.jpg",
                        Nome = "PTZ 89",
                        DataFabricacao = new DateTime(1988, 01, 07),
                        Calibre = 120,
                        PotenciaMotor = 520,
                        QuantidadeTripulacao = 4,
                        Velocidade = 52,
                        nacionalidadeId = service.GetIdFromNacionalidade("China", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 100000.00,
                        tipoId = service.GetIdFromTipo("Caça", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/0/0a/GarageImage_PTL02.jpg/800px-GarageImage_PTL02.jpg",
                        Nome = "WMA301",
                        DataFabricacao = new DateTime(1992, 03, 05),
                        Calibre = 105,
                        PotenciaMotor = 320,
                        QuantidadeTripulacao = 4,
                        Velocidade = 84,
                        nacionalidadeId = service.GetIdFromNacionalidade("China", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 60000.00,
                        tipoId = service.GetIdFromTipo("leve", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/c/c0/GarageImage_M1128.jpg/800px-GarageImage_M1128.jpg",
                        Nome = "M1128",
                        DataFabricacao = new DateTime(1992, 01, 07),
                        Calibre = 105,
                        PotenciaMotor = 350,
                        QuantidadeTripulacao = 3,
                        Velocidade = 121,
                        nacionalidadeId = service.GetIdFromNacionalidade("USA", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 7000000.00,
                        tipoId = service.GetIdFromTipo("Caça", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/5/56/GarageImage_M4A3_%2876%29_W.jpg/800px-GarageImage_M4A3_%2876%29_W.jpg",
                        Nome = "M4A3 (76) W",
                        DataFabricacao = new DateTime(1944, 05, 04),
                        Calibre = 76,
                        PotenciaMotor = 450,
                        QuantidadeTripulacao = 5,
                        Velocidade = 43,
                        nacionalidadeId = service.GetIdFromNacionalidade("USA", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 50000.00,
                        tipoId = service.GetIdFromTipo("médio", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/1/14/GarageImage_FV4005.jpg/1024px-GarageImage_FV4005.jpg",
                        Nome = "FV4005",
                        DataFabricacao = new DateTime(1952, 04, 10),
                        Calibre = 183,
                        PotenciaMotor = 650,
                        QuantidadeTripulacao = 5,
                        Velocidade = 28,
                        nacionalidadeId = service.GetIdFromNacionalidade("Reino", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 2000000.00,
                        tipoId = service.GetIdFromTipo("Caça", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/7/7d/GarageImage_TTD.jpg/1024px-GarageImage_TTD.jpg",
                        Nome = "TTD",
                        DataFabricacao = new DateTime(1992, 06, 28),
                        Calibre = 105,
                        PotenciaMotor = 1250,
                        QuantidadeTripulacao = 4,
                        Velocidade = 72,
                        nacionalidadeId = service.GetIdFromNacionalidade("Reino", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 550000.00,
                        tipoId = service.GetIdFromTipo("médio", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/1/1a/GarageImage_Sturer_Emil.jpg/800px-GarageImage_Sturer_Emil.jpg",
                        Nome = "Sturer Emil",
                        DataFabricacao = new DateTime(1942, 09, 12),
                        Calibre = 120,
                        PotenciaMotor = 310,
                        QuantidadeTripulacao = 5,
                        Velocidade = 26,
                        nacionalidadeId = service.GetIdFromNacionalidade("Alemanha", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 35000.00,
                        tipoId = service.GetIdFromTipo("Caça", tanques)
                    });
                    context.Tanque.Add(new Tanque
                    {
                        LinkImagem = "https://wiki.warthunder.com/images/thumb/1/16/GarageImage_Tiger_E.jpg/800px-GarageImage_Tiger_E.jpg",
                        Nome = "Tiger E",
                        DataFabricacao = new DateTime(1942, 08, 22),
                        Calibre = 88,
                        PotenciaMotor = 700,
                        QuantidadeTripulacao = 5,
                        Velocidade = 45,
                        nacionalidadeId = service.GetIdFromNacionalidade("Alemanha", nacionalidades),
                        Visitas = 0,
                        PrecoCompra = 135000.00,
                        tipoId = service.GetIdFromTipo("pesado", tanques)
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
