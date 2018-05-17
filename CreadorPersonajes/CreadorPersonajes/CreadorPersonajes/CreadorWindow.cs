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

			entryNombre.Text = personaje.Nombre;
			spinButtonFue.Value = (int)personaje.Fuerza;
			spinButtonDes.Value = (int)personaje.Destreza;
			spinButtonCon.Value = (int)personaje.Constitucion;
			spinButtonInt.Value = (int)personaje.Inteligencia;
			spinButtonSab.Value = (int)personaje.Sabiduria;
			spinButtonCar.Value = (int)personaje.Carisma;

			//ComboBoxHelper.Fill(comboBoxRazaDos, "select id, nombre from personaje order by nombre", personaje.Raza);

			saveAction.Activated += delegate
			{
				personaje.Nombre = entryNombre.Text;
				personaje.Fuerza = (int)spinButtonFue.Value;
				personaje.Destreza = (int)spinButtonDes.Value;
				personaje.Constitucion = (int)spinButtonCon.Value;
				personaje.Inteligencia = (int)spinButtonInt.Value;
				personaje.Sabiduria = (int)spinButtonSab.Value;
				personaje.Carisma = (int)spinButtonCar.Value;
				//personaje.Raza = long.Parse(comboBoxCategoria.Text);
				CreadorDao.Save(personaje);
				Destroy();
			};
		}
	}
}
