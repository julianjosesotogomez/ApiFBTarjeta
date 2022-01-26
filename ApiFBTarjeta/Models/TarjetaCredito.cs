using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFBTarjeta.Models
{
    public class TarjetaCredito
    {

        public int Id { get; set; }
        [Required] //Me referencia que el campo no puede ser NULL
        public string Titular { get; set; }
        [Required] //Me referencia que el campo no puede ser NULL
        public string NumeroTrajeta { get; set; }
        [Required] //Me referencia que el campo no puede ser NULL
        public string FechaDeExpiracion { get; set; }
        [Required] //Me referencia que el campo no puede ser NULL
        public string CVV { get; set; }
    }
}
