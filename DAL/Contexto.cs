using Microsoft.EntityFrameworkCore;
using RegistroPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroPeliculas.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Peliculas> Peliculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\Peliculas.db");
        }

      
    }
}
