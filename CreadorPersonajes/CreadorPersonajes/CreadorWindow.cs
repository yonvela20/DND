using System;
using System.Data;
using Serpis.Ad;

namespace CreadorPersonajes
{
	public partial class CreadorWindow : Gtk.Window
	{
		public CreadorWindow(Creador personaje) : base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			comboBoxRazaDos.Changed += delegate
			{
				image.Pixbuf = new Gdk.Pixbuf(comboBoxRazaDos.ActiveText + ".png");
			};

			entryNombre.Text = personaje.Nombre;
			spinButtonFue.Value = (int)personaje.Fuerza;
			spinButtonDes.Value = (int)personaje.Destreza;
			spinButtonCon.Value = (int)personaje.Constitucion;
			spinButtonInt.Value = (int)personaje.Inteligencia;
			spinButtonSab.Value = (int)personaje.Sabiduria;
			spinButtonCar.Value = (int)personaje.Carisma;

			if (personaje.Id > 0)
			{
				comboBoxRazaDos.AppendText(personaje.Raza);
				comboBoxRazaDos.Active = 0;
			}

			else {
				comboBoxRazaDos.AppendText("Elfo");
				comboBoxRazaDos.AppendText("Enano");
				comboBoxRazaDos.AppendText("Gnomo");
				comboBoxRazaDos.AppendText("Humano");
				comboBoxRazaDos.AppendText("Mediano");
				comboBoxRazaDos.AppendText("Orco");
				comboBoxRazaDos.AppendText("Semielfo");
				comboBoxRazaDos.Active = 0;
			}

			saveAction.Activated += delegate
			{
				personaje.Nombre = entryNombre.Text;
				personaje.Raza = comboBoxRazaDos.ActiveText;
				personaje.Fuerza = (int)spinButtonFue.Value;
				personaje.Destreza = (int)spinButtonDes.Value;
				personaje.Constitucion = (int)spinButtonCon.Value;
				personaje.Inteligencia = (int)spinButtonInt.Value;
				personaje.Sabiduria = (int)spinButtonSab.Value;
				personaje.Carisma = (int)spinButtonCar.Value;
				CreadorDao.Save(personaje);
				Destroy();
			};

			buttonDados.Clicked += delegate {
				new DadosWindow();
			};
		}
	}
}
