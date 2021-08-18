using System;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Tipos de usuarios posibles.
    /// </summary>
    public enum ETipoUsuario
    {
        /// <summary>
        /// Usuario con permisos para administrar de forma general todas las sucursales disponibles.
        /// </summary>
        AdministradorGeneral  = 1,

        /// <summary>
        /// Usuario con permisos para administrar la sucursal.
        /// </summary>
        AdministradorSucursal = 2
    }
}