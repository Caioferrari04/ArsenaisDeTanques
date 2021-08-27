using System;
using System.ComponentModel.DataAnnotations;

namespace ArsenalDeTanques.Models
{
    public class Tanque
    {
        
        private int? _Calibre;

        private int? _PotenciaMotor;

        private int _QuantidadeTripulacao;

        private int? _Velocidade;

        private int? _Visitas;

        [Display(Name = "ID de fábrica")]
        public int Id{ get; set; } //Removi encapsulamento pois não fazia sentido, não é possível alterar o ID

        [Display(Name = "Link da imagem")]
        public string LinkImagem { get; set; }

        [Required(ErrorMessage = "Nome é necessário!")]
        public string Nome{ get; set; }

        [Required(ErrorMessage = "Insira um calibre válido para o armamento. ")]
        public int? Calibre
        {
            get => _Calibre;
            set => _Calibre = value > 10 && value < 230 ? value : null;
        }

        [Required(ErrorMessage = "Insira um valor válido para o motor. ")]
        [Display(Name = "Potencia do Motor")]
        public int? PotenciaMotor 
        {
            get => _PotenciaMotor;
            set => _PotenciaMotor = value > 10 && value < 5000 ? value : null;
        }

        [Display(Name = "Quantidade de tripulantes")]
        public int QuantidadeTripulacao //Adicionar validações
        {
            get => _QuantidadeTripulacao;
            set => _QuantidadeTripulacao = value >= 0 && value < 100 ? value : 0;
        }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Fabricação")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "É um tanque, não um bunker! Informe a velocidade!")]
        public int? Velocidade { 
            get => _Velocidade; 
            set => _Velocidade = value > 0 && value < 250 ? value : null; 
        }
        
        //Valor não pode ser maior que 1, nem menor
        //Utilizado para determinar se o tanque em específico está em destaque ou não,
        //Pode ser visto sendo utilizado em services, TanquesSqlService, Get e GetDestaques.
        public int? Visitas { 
            get => _Visitas; 
            set => _Visitas = value - _Visitas == 1 ? value : _Visitas; 
        } 
       
        [Required(ErrorMessage = "Tanque deve possuir uma nacionalidade!")]
        [Display(Name = "Nacionalidade")]
        public int nacionalidadeId { get; set; }

        public Nacionalidade nacionalidade { get; set; }

        [Required(ErrorMessage = "Tanque deve possuir um tipo!")]
        [Display(Name = "Tipo")]
        public int tipoId { get; set; }

        public TipoTanque tipo { get; set; }

        [Required(ErrorMessage = "Tanque deve possuir um preço!")]
        [Display(Name = "Preço")]
        public double? PrecoCompra { get; set; }

    }
}
