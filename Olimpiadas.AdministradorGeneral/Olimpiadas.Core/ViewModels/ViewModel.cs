using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace Olimpiadas.Core
{
	/// <summary>
	/// Clase base para los ViewModels
	/// </summary>
	[AddINotifyPropertyChangedInterface]
	public class ViewModel : INotifyPropertyChanged
	{
		/// <summary>
		/// Evento que se dispara cuando el valor de una propiedad contenida por este vm cambio
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged = delegate{};

		/// <summary>
		/// Dispara <see cref="PropertyChanged"/>
		/// </summary>
		/// <param name="nombrePropiedad">Nombre de la propiedad cuyo valor cambio</param>
		public void DispararPropertyChanged(string nombrePropiedad) =>
			PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
	}
}
