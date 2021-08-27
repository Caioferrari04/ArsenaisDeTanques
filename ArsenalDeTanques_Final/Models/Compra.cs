using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Models
{
    public class Compra
    {
        public int id { get; set; }

        [Display(Name = "Preço")]
        public double? PrecoCompra { get; set; }

        [Display(Name = "Data de compra")]
        public DateTime DataCompra { get; set; }

        [Display(Name = "Tanque comprado")]
        public int tanqueId { get; set; }

        public Tanque tanque { get; set; }

        public string userId { get; set; }

        public IdentityUser user { get; set; }
    }
}
