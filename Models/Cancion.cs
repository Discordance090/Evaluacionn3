using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Evaluacionn3.Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Descripcion { get; set; }       
    }

    public class CancionDBContext : DbContext
    {
        public DbSet<Cancion>Canciones { get; set; }
    }
}