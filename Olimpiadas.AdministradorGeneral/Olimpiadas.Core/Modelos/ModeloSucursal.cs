using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Modelo de datos para una sucursal.
    /// </summary>
    public class ModeloSucursal : ModeloBase
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Cantidad maxima de clientes dentro de la sucursal.
        /// </summary>
        public int CantidadMaximaDeClientes { get; set; }

        /// <summary>
        /// Direccion de la sucursal,
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Usuarios que operan en la sucursal.
        /// </summary>
        public List<TISucursalUsuario> UsuariosSucursal { get; set; } = new List<TISucursalUsuario>();

        /// <summary>
        /// Historial de ingresos a la sucursal.
        /// </summary>
        public List<TIHistorialSucursal> HistorialesSucursal { get; set; } = new List<TIHistorialSucursal>();

        /// <summary>
        /// Configuracion red del servidor.
        /// </summary>
        public List<TIConfiguracionRedSucursal> ConfiguracionRedServidor { get; set; } = new List<TIConfiguracionRedSucursal>();

        /// <summary>
        /// Configuracion red local.
        /// </summary>
        public List<TIConfiguracionRedSucursal> ConfiguracionRedLocal { get; set; } = new List<TIConfiguracionRedSucursal>();
    }
}
