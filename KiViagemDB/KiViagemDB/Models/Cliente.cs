using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KiViagemDB.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public Destino Destino { get; set; } //FK
        public Promo Promo { get; set; } //FK

    }
}
