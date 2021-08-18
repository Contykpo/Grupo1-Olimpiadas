using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace Olimpiadas.RecursosWPF
{
	/// <summary>
	/// Clase base que define funciones para la conversion de variables
	/// </summary>
	/// <typeparam name="TConvertidor">Tipo de este convertidor</typeparam>
	public abstract class ConvertidorBase<TConvertidor> : MarkupExtension, IValueConverter
		where TConvertidor: ConvertidorBase<TConvertidor>, new()
	{
		public static TConvertidor instanciaConvertidor;

		public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			instanciaConvertidor ??= new TConvertidor();

			return instanciaConvertidor;
		}
	}
}
