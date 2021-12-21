using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KiViagemDB.Models
{
    public class Destino
    {
        [Key]
        public int DestinoId { get; set; }
        public float Valor { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }

    }
}
