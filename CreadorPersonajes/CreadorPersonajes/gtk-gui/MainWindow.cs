
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action newAction;

	private global::Gtk.Action newAction1;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Toolbar toolbar1;

	private global::Gtk.Table table1;

	private global::Gtk.Button buttonDados;

	private global::Gtk.Button buttonNuevo;

	private global::Gtk.Button buttonView;

	private global::Gtk.ComboBox comboBoxRaza;

	private global::Gtk.Image image;

	private global::Gtk.Table table3;

	private global::Gtk.Image imageTitulo;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.newAction = new global::Gtk.Action("newAction", null, null, "gtk-new");
		w1.Add(this.newAction, null);
		this.newAction1 = new global::Gtk.Action("newAction1", null, null, "gtk-new");
		w1.Add(this.newAction1, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem/><toolitem name=\'newAction1\' action=\'newAc" +
				"tion1\'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox2.Add(this.toolbar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.toolbar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table(((uint)(6)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.buttonDados = new global::Gtk.Button();
		this.buttonDados.CanFocus = true;
		this.buttonDados.Name = "buttonDados";
		this.buttonDados.UseUnderline = true;
		this.buttonDados.Label = global::Mono.Unix.Catalog.GetString("Dados");
		this.table1.Add(this.buttonDados);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonDados]));
		w3.TopAttach = ((uint)(3));
		w3.BottomAttach = ((uint)(4));
		w3.XPadding = ((uint)(20));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(2));
		// Container child table1.Gtk.Table+TableChild
		this.buttonNuevo = new global::Gtk.Button();
		this.buttonNuevo.CanFocus = true;
		this.buttonNuevo.Name = "buttonNuevo";
		this.buttonNuevo.UseUnderline = true;
		this.buttonNuevo.Label = global::Mono.Unix.Catalog.GetString("Nuevo Personaje");
		this.table1.Add(this.buttonNuevo);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonNuevo]));
		w4.TopAttach = ((uint)(2));
		w4.BottomAttach = ((uint)(3));
		w4.XPadding = ((uint)(20));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(2));
		// Container child table1.Gtk.Table+TableChild
		this.buttonView = new global::Gtk.Button();
		this.buttonView.CanFocus = true;
		this.buttonView.Name = "buttonView";
		this.buttonView.UseUnderline = true;
		this.buttonView.Label = global::Mono.Unix.Catalog.GetString("Visualizar personajes");
		this.table1.Add(this.buttonView);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonView]));
		w5.TopAttach = ((uint)(4));
		w5.BottomAttach = ((uint)(5));
		w5.XPadding = ((uint)(20));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(2));
		// Container child table1.Gtk.Table+TableChild
		this.comboBoxRaza = global::Gtk.ComboBox.NewText();
		this.comboBoxRaza.AppendText(global::Mono.Unix.Catalog.GetString("Elfo"));
		this.comboBoxRaza.AppendText(global::Mono.Unix.Catalog.GetString("Enano"));
		this.comboBoxRaza.AppendText(global::Mono.Unix.Catalog.GetString("Gnomo"));
		this.comboBoxRaza.AppendText(global::Mono.Unix.Catalog.GetString("Humano"));
		this.comboBoxRaza.AppendText(global::Mono.Unix.Catalog.GetString("Mediano"));
		this.comboBoxRaza.AppendText(global::Mono.Unix.Catalog.GetString("Orco"));
		this.comboBoxRaza.AppendText(global::Mono.Unix.Catalog.GetString("Semielfo"));
		this.comboBoxRaza.Name = "comboBoxRaza";
		this.comboBoxRaza.Active = 0;
		this.table1.Add(this.comboBoxRaza);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.comboBoxRaza]));
		w6.TopAttach = ((uint)(1));
		w6.BottomAttach = ((uint)(2));
		w6.XPadding = ((uint)(20));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(2));
		// Container child table1.Gtk.Table+TableChild
		this.image = new global::Gtk.Image();
		this.image.Name = "image";
		this.table1.Add(this.image);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.image]));
		w7.TopAttach = ((uint)(1));
		w7.BottomAttach = ((uint)(5));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.YPadding = ((uint)(20));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.table3 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.imageTitulo = new global::Gtk.Image();
		this.imageTitulo.Name = "imageTitulo";
		this.table3.Add(this.imageTitulo);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3[this.imageTitulo]));
		w8.XPadding = ((uint)(20));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		this.table1.Add(this.table3);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.table3]));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox2.Add(this.table1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
		w10.Position = 1;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 362;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
