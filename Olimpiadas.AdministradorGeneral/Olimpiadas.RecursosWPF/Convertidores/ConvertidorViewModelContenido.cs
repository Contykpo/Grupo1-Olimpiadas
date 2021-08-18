using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

using Olimpiadas.Core;

namespace Olimpiadas.RecursosWPF
{
	/// <summary>
	/// Convierte de un <see cref="ViewModel"/> a un <see cref="UserControl"/> correspondiente
	/// </summary>
	[ValueConversion(sourceType: typeof(ViewModel), targetType: typeof(UserControl))]
	public class ConvertidorViewModelContenido : ConvertidorBase<ConvertidorViewModelContenido>
	{
		public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is not ViewModel)
				throw new System.ArgumentException($"Valor debe ser un {nameof(ViewModel)}", nameof(value));

			switch (value)
			{
				case ViewModelCreacionDeUsuario vm:
					return new UserControlCreacionUsuario {DataContext = vm};

				default:
					return null;
			}
		}
	}
}
