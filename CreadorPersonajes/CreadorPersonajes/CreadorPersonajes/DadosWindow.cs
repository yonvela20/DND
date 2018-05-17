using System;
namespace CreadorPersonajes
{
	public partial class DadosWindow : Gtk.Window
	{
		public DadosWindow() :	base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Random rnd = new Random();

			int resultado;
			string resultadoTexto;

			buttonTirar.Clicked += delegate {
				resultado = rnd.Next(1, 7);
				resultadoTexto = resultado.ToString();
				labelResultado.Text = resultadoTexto;
			};
		}
	}
}
