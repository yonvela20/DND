using System;
using System.Data;
using Serpis.Ad;
using CreadorPersonajes;
using MySql.Data.MySqlClient;

namespace CreadorPersonajes
{
	public partial class VisorWindow : Gtk.Window
	{
		public VisorWindow() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			App.Instance.Connection = new MySqlConnection("server=localhost;database=dnd;user=root;password=administrador");
			App.Instance.Connection.Open();

			TreeViewHelper.Fill(treeView, CreadorDao.SelectAll);

			editAction.Activated += delegate
			{
				object id = TreeViewHelper.GetId(treeView);
				Creador personaje = CreadorDao.Load(id);
				new CreadorWindow(personaje);
			};

			//Se actualiza solo 
			//refreshAction.Activated += delegate { 
			//	TreeViewHelper.Fill(treeView, CreadorDao.SelectAll);
			//};

			deleteAction.Activated += delegate
			{
				if (WindowHelper.Confirm(this, "¿Quieres eliminar el registro?"))
				{
					object id = TreeViewHelper.GetId(treeView);
					CreadorDao.Delete(id);
				}
			};

		}
	}
}
