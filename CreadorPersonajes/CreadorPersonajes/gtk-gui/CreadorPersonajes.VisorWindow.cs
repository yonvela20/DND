
// This file has been generated by the GUI designer. Do not modify.
namespace CreadorPersonajes
{
	public partial class VisorWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action editAction;

		private global::Gtk.Action refreshAction;

		private global::Gtk.Action deleteAction;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Toolbar toolbar3;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TreeView treeView;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget CreadorPersonajes.VisorWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.editAction = new global::Gtk.Action("editAction", null, null, "gtk-edit");
			w1.Add(this.editAction, null);
			this.refreshAction = new global::Gtk.Action("refreshAction", null, null, "gtk-refresh");
			w1.Add(this.refreshAction, null);
			this.deleteAction = new global::Gtk.Action("deleteAction", null, null, "gtk-delete");
			w1.Add(this.deleteAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "CreadorPersonajes.VisorWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("VisorWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child CreadorPersonajes.VisorWindow.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar3\'><toolitem name=\'editAction\' action=\'editAction\'/><to" +
					"olitem name=\'refreshAction\' action=\'refreshAction\'/><toolitem name=\'deleteAction" +
					"\' action=\'deleteAction\'/></toolbar></ui>");
			this.toolbar3 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar3")));
			this.toolbar3.Name = "toolbar3";
			this.toolbar3.ShowArrow = false;
			this.vbox5.Add(this.toolbar3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.toolbar3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.treeView = new global::Gtk.TreeView();
			this.treeView.CanFocus = true;
			this.treeView.Name = "treeView";
			this.scrolledwindow1.Add(this.treeView);
			this.vbox5.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.scrolledwindow1]));
			w4.Position = 1;
			this.Add(this.vbox5);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 399;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
