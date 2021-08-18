using System.ComponentModel.DataAnnotations.Schema;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Representa una relacion con <see cref="ModeloSucursal"/>
    /// </summary>
    public class TISucursal : ModeloBase
    {
        [ForeignKey(nameof(Sucursal))]
        public int IDSucursal { get; set; }
        public ModeloSucursal Sucursal { get; set; }
    }

    /// <summary>
    /// Representa una relacion con <see cref="ModeloUsuario"/>
    /// </summary>
    public class TISucursalUsuario : TISucursal
    {
        [ForeignKey(nameof(Usuario))]
        public int IDSucursal { get; set; }
        public ModeloUsuario Usuario { get; set; }
    }

    public class TIHistorialSucursal : TISucursal
    {
        [ForeignKey(nameof(HistorialIngresos))]
        public int IDHistorialIngresos { get; set; }
        public ModeloHistorialIngresos HistorialIngresos { get; set; }
    }

    public class TIConfiguracionRedSucursal : TISucursal
    {
        [ForeignKey(nameof(ConfiguracionRed))]
        public int IDConfiguracionRed { get; set; }
        public ModeloConfiguracionRed ConfiguracionRed { get; set; }
    }

    /// <summary>
    /// Representa una relacion entre <see cref="ModeloModeloAdministradorGeneral"/> y un <see cref="ModeloSucursal"/>
    /// </summary>
    public class TIAdministradorGeneralSucursal : TISucursal
    {
        [ForeignKey(nameof(AdministradorGeneral))]
        public int IDAdministradorGeneral { get; set; }
        public ModeloAdministradorGeneral AdministradorGeneral { get; set; }
    }

}
