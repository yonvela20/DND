
// This file has been generated by the GUI designer. Do not modify.
namespace CreadorPersonajes
{
	public partial class seleccionDadosWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Table table1;

		private global::Gtk.Button buttonTirar;

		private global::Gtk.ComboBox comboboxDados;

		private global::Gtk.Label label1;

		private global::Gtk.Label labelResultado;

		private global::Gtk.Table table2;

		private global::Gtk.Image image;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget CreadorPersonajes.seleccionDadosWindow
			this.Name = "CreadorPersonajes.seleccionDadosWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("seleccionDadosWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child CreadorPersonajes.seleccionDadosWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonTirar = new global::Gtk.Button();
			this.buttonTirar.CanFocus = true;
			this.buttonTirar.Name = "buttonTirar";
			this.buttonTirar.UseUnderline = true;
			this.buttonTirar.Label = global::Mono.Unix.Catalog.GetString("Lanzar");
			this.table1.Add(this.buttonTirar);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonTirar]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxDados = global::Gtk.ComboBox.NewText();
			this.comboboxDados.AppendText(global::Mono.Unix.Catalog.GetString("d4"));
			this.comboboxDados.AppendText(global::Mono.Unix.Catalog.GetString("d6"));
			this.comboboxDados.AppendText(global::Mono.Unix.Catalog.GetString("d8"));
			this.comboboxDados.AppendText(global::Mono.Unix.Catalog.GetString("d10"));
			this.comboboxDados.AppendText(global::Mono.Unix.Catalog.GetString("d20"));
			this.comboboxDados.Name = "comboboxDados";
			this.comboboxDados.Active = 0;
			this.table1.Add(this.comboboxDados);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxDados]));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Resultado:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelResultado = new global::Gtk.Label();
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.LabelProp = global::Mono.Unix.Catalog.GetString("1");
			this.table1.Add(this.labelResultado);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.labelResultado]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XPadding = ((uint)(11));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.image = new global::Gtk.Image();
			this.image.Name = "image";
			this.table2.Add(this.image);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.image]));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table2]));
			w7.Position = 2;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
