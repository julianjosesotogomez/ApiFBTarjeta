using ApiFBTarjeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFBTarjeta
{
    public class AplicationDbContext: DbContext //DbContext crea una instancia en nuestra base de datos
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }//Mapear el modelo de la tabla de la base de datos 

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)//Se instancia la clase
        {

        }
    }
}
