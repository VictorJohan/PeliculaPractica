using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Controls;

namespace RegistroPeliculas.Entidades
{
    public class Peliculas
    {
        [Key]
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public string Sipnosis { get; set; }
        public string Genero { get; set; }
        public DateTime FechaEstreno { get; set; } = DateTime.Now;
    }
}
