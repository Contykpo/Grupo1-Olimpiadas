using System;
using System.Collections.Generic;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Modelo de datos para el historial de ingresos a una sucursal.
    /// </summary>
    public class ModeloHistorialIngresos : ModeloBase
    {
        /// <summary>
        /// Numero del dia de ingresos.
        /// </summary>
        public int Dia { get; set; }

        /// <summary>
        /// Total de ingresos.
        /// </summary>
        public List<TIHistorialIngresos> Ingresos { get; set; } = new List<TIHistorialIngresos>();
    }
}
