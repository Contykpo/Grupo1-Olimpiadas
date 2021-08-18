using System;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Modelo de datos para un usuario.
    /// </summary>
    public class ModeloUsuario : ModeloBase
    {
        /// <summary>
        /// ID del usuario.
        /// </summary>
        public int IDUsuario            { get; set; }

        /// <summary>
        /// Tipo de permisos del usuario.
        /// </summary>
        public ETipoUsuario TipoUsuario { get; set; }

        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string Nombre            { get; set; }

        /// <summary>
        /// Contraseña del usuario.
        /// </summary>
        public string Contraseña        { get; set; }
    }
}