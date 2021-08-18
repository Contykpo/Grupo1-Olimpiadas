using System;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Modelo de datos para una configuracion red.
    /// </summary>
    public class ModeloConfiguracionRed : ModeloBase
    {
        /// <summary>
        /// IP Estatica del equipo.
        /// </summary>
        public string IPEstatica { get; set; }

        /// <summary>
        /// Puerto.
        /// </summary>
        public int Puerto        { get; set; }
    }
}
