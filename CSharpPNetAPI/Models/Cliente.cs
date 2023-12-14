using System;
using System.Collections.Generic;

namespace CSharpPNetAPI.Models
{
    public partial class Cliente
    {
        public int Idcliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        //public string? Fechanacimiento { get; set; }
        public string? Correo { get; set; }
        public decimal? Monto { get; set; }
        //public DateTime? Fechahoraregistro { get; set; }
    }
}
