using System;
using MySql.Data.MySqlClient;
using System.Data;
using Gtk;
using Serpis.Ad;
using CreadorDnd;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Title = "Personajes";
		App.Instance.Connection = new MySqlConnection("server=localhost;database=dnd;user=root;password=sistemas");
		App.Instance.Connection.Open();

        deleteAction.Sensitive = false;
        editAction.Sensitive = false;

		TreeViewHelper.Fill(treeView, CreadorDao.SelectAll);

		treeView.Selection.Changed += delegate {
			bool hasSelected = treeView.Selection.CountSelectedRows() > 0;
			deleteAction.Sensitive = hasSelected;
			editAction.Sensitive = hasSelected;
			//if (treeView.Selection.CountSelectedRows() > 0)
			//    deleteAction.Sensitive = true;
			//else
			//deleteAction.Sensitive = false;
		};

		newAction.Activated += delegate {
            Creador personaje = new Creador();
            new CreadorWindow(personaje);
		};

		editAction.Activated += delegate {
			object id = TreeViewHelper.getId(treeView);
            Creador personaje = CreadorDao.Load(id);
			new CreadorWindow(personaje);
		};

		refreshAction.Activated += delegate {
            TreeViewHelper.Fill(treeView, CreadorDao.SelectAll);
		};

		deleteAction.Activated += delegate {
			if (WindowsHelper.Confirm(this, "¿Quieres eliminar el registro?"))
			{
				object id = TreeViewHelper.getId(treeView);
                CreadorDao.Delete(id);
			}
		};

	}

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
