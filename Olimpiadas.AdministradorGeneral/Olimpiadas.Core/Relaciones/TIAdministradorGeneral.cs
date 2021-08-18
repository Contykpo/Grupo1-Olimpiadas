using System.ComponentModel.DataAnnotations.Schema;

namespace Olimpiadas.Core
{
    /// <summary>
    /// Representa una relacion con <see cref="ModeloAdministradorGeneral"/>
    /// </summary>
    public class TIAdministradorGeneral : ModeloBase
    {
        [ForeignKey(nameof(AdministradorGeneral))]
        public int IDAdministradorGeneral { get; set; }
        public ModeloAdministradorGeneral AdministradorGeneral { get; set; }
    }

    /// <summary>
    /// Representa una relacion con <see cref="ModeloConfiguracionRed"/>
    /// </summary>
    public class TIAdministradorGeneralConfiguracionRed : TIAdministradorGeneral
    {
        [ForeignKey(nameof(ConfiguracionRed))]
        public int IDConfiguracionRed { get; set; }
        public ModeloConfiguracionRed ConfiguracionRed { get; set; }
    }
}
