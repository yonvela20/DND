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

			TreeViewHelper.Fill(treeView, CreadorDao.SelectAll);

			editAction.Sensitive = false;
			deleteAction.Sensitive = false;

			treeView.Selection.Changed += delegate {
				bool hasSelected = treeView.Selection.CountSelectedRows() > 0;
				deleteAction.Sensitive = hasSelected;
				editAction.Sensitive = hasSelected;
			};

			editAction.Activated += delegate
			{
				object id = TreeViewHelper.GetId(treeView);
				Creador personaje = CreadorDao.Load(id);
				new CreadorWindow(personaje);
			};

			refreshAction.Activated += delegate { 
				TreeViewHelper.Fill(treeView, CreadorDao.SelectAll);
			};

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
