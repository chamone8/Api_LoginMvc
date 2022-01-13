using Api_LoginMvc.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Api_LoginMvc.Context
{
    public class BancoDados : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public BancoDados(DbContextOptions options) : base(options) { }
        public BancoDados()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("baseLogin"); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(c => c.Id);
            
        }
    }
}
