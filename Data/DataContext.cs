using System.Collections.Generic;
using lista_de_computadores.Models;
using Microsoft.EntityFrameworkCore;

namespace lista_de_computadores.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        
        public DbSet<Computador> Computador { get; set; }

        public string g = "generico";
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            
            builder.Entity<Computador>()
                .HasData(new List<Computador>(){
                    
                    new Computador(2, "Compaq", "Compaq", "3354288", g,"500gb SeaGate",g,g),
                    new Computador(3, "IBM", "Antonia", "55668899", g,g,g,g),
                    new Computador(4, "Dell", "Maria", "6565659", g,g,g,g),
                    new Computador(5, "SAMSUNG", "Machado", "565685415", g,g,g,g),
                    new Computador(6, "Toshiba", "Alvares", "456454545", g,g,g,g),
                    new Computador(7, "Positivo", "José", "9874512", g,g,g,g)
                });


        }
    }
}
