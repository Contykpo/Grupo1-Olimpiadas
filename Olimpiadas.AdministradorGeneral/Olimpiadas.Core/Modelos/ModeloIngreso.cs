using System;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Modelo de datos para un ingreso al local.
    /// </summary>
    public class ModeloIngreso : ModeloBase
    {
        /// <summary>
        /// Horario del ingreso.
        /// </summary>
        public DateTime Horario { get; set; }
    }
}
