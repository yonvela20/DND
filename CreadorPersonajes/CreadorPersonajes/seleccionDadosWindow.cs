using System;
using System.Media;

namespace CreadorPersonajes
{
	public partial class seleccionDadosWindow : Gtk.Window
	{
		public seleccionDadosWindow() :	base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			Random rnd = new Random();
			SoundPlayer sonido = new SoundPlayer("dados.wav");
			sonido.SoundLocation = "dados.wav";

			int resultado = 0;
			string resultadoTexto;

			int dado = 0;

			image.Pixbuf = new Gdk.Pixbuf("d4.png");
			comboboxDados.Changed += delegate
			{
				image.Pixbuf = new Gdk.Pixbuf(comboboxDados.ActiveText + ".png");
			};

			//Sonidito al tirar los dados si no se queda muy soso
			buttonTirar.Clicked += delegate {
				sonido.Stop();
				sonido.Play();

				if (comboboxDados.ActiveText == "d4")
				{
					dado = 5;
				}
				else if (comboboxDados.ActiveText == "d6")
				{
					dado = 7;
				}
				else if (comboboxDados.ActiveText == "d8")
				{
					dado = 9;
				}
				else if (comboboxDados.ActiveText == "d10")
				{
					dado = 11;
				}
				else {
					dado = 21;
				}

				resultado = rnd.Next(1, dado);
				resultadoTexto = resultado.ToString();

				labelResultado.Text = resultadoTexto;
			};
		}
	}
}
