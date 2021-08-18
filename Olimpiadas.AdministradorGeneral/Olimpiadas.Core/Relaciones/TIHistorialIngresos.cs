using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olimpiadas.Core
{
    public class TIHistorialIngresos : ModeloBase
    {
        [ForeignKey(nameof(HistorialIngresos))]
        public int IDHistorialIngresos { get; set; }
        public ModeloHistorialIngresos HistorialIngresos { get; set; }

        [ForeignKey(nameof(Ingreso))]
        public int IDIngresos { get; set; }
        public ModeloIngreso Ingreso { get; set; }
    }
}
