using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KiViagemDB.Models
{
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }
        public Cliente Cliente { get; set; }//FK
        public Destino Destino { get; set; }//FK
        public Promo Promo { get; set; }//FK
        
    }
}
