using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiViagemDB.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Promo> promos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opitionsBuilder)
        {
            opitionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=KiViagemDB;Integrated Security=True");
        }
    }
}
