using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KiViagemDB.Models
{
    public class Promo
    {
        [Key]
        public int PromoId { get; set; }
        public string NomePromo { get; set; }
        public int PorcentagemDesc { get; set; }
        public int ClienteID { get; set; }//FK

    }
}
