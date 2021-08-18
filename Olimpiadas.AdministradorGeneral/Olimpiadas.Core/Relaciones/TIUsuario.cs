using System.ComponentModel.DataAnnotations.Schema;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Representa una relacion con <see cref="ModeloUsuario"/>
    /// </summary>
    public class TIUsuario : ModeloBase
    {
        [ForeignKey(nameof(Sucursal))]
        public int IDSucursal { get; set; }
        public ModeloUsuario Sucursal { get; set; }
    }

    /// <summary>
    /// Representa una relacion con <see cref="ModeloUsuario"/>
    /// </summary>
    public class TIUsuarioAdministradorGeneral : TIUsuario
    {
        [ForeignKey(nameof(AdministradorGeneral))]
        public int IDAdministradorGeneral { get; set; }
        public ModeloAdministradorGeneral AdministradorGeneral { get; set; }
    }
}
