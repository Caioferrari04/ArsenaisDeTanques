using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public abstract class Tanque
    {
        private int _Id;

        private string _Nome;

        private int _Calibre;

        private int _PotenciaMotor;

        private int _QuantidadeTripulacao;

        [DataType(DataType.Date)]
        private DateTime _DataFabricacao;

        private int _Velocidade;

        [Display(Name = "ID de fábrica")]
        public int Id //Adicionar validações
        { 
            get => _Id;
            set => _Id = value; 
        }

        public string Nome
        {
            get => _Nome;
            set => _Nome = value;
        }

        public int Calibre //Adicionar validações
        {
            get => _Calibre;
            set => _Calibre = value;
        }

        [Display(Name = "Potencia do Motor")]
        public int PotenciaMotor 
        {
            get => _PotenciaMotor;
            set => _PotenciaMotor = value;
        }
        
        [Display(Name = "Quantidade de tripulantes")]
        public int QuantidadeTripulacao //Adicionar validações
        {
            get => _QuantidadeTripulacao;
            set => _QuantidadeTripulacao = value;
        }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Fabricação")]
        public DateTime DataFabricacao {
            get => _DataFabricacao;
            set => _DataFabricacao = value; 
        }

        public virtual int Velocidade { 
            get => _Velocidade; 
            set => _Velocidade = value; 
        }
    }
}
