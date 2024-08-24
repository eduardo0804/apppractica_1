using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apppractica_1.Models
{
    public class Operaciones
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public List<string>? Instrumentos { get; set; }
        public decimal MontoAbonar { get; set; }
        public decimal IGV;
        public decimal Comision { get; set; }
        public decimal Total { get; set; }

        public void CalcularOperacion()
        {
            IGV = MontoAbonar * 0.18M;
            Comision = MontoAbonar > 300 ? 3 : 1;
            Total = MontoAbonar + IGV + Comision;
        }
    }
}