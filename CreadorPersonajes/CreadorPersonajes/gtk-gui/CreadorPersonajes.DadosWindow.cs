
// This file has been generated by the GUI designer. Do not modify.
namespace CreadorPersonajes
{
	public partial class DadosWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Table table1;

		private global::Gtk.Button buttonTirar;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label labelContador;

		private global::Gtk.Label labelResultadoCuatro;

		private global::Gtk.Label labelResultadoDos;

		private global::Gtk.Label labelResultadoTres;

		private global::Gtk.Label labelResultadoUno;

		private global::Gtk.Label validoCuatro;

		private global::Gtk.Label validoDos;

		private global::Gtk.Label validoTres;

		private global::Gtk.Label validoUno;

		private global::Gtk.Table table2;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label14;

		private global::Gtk.Label label15;

		private global::Gtk.Label labelValorCinco;

		private global::Gtk.Label labelValorCuatro;

		private global::Gtk.Label labelValorDos;

		private global::Gtk.Label labelValorSeis;

		private global::Gtk.Label labelValorTres;

		private global::Gtk.Label labelValorUno;

		private global::Gtk.Label valorar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget CreadorPersonajes.DadosWindow
			this.Name = "CreadorPersonajes.DadosWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("DadosWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child CreadorPersonajes.DadosWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(5)), ((uint)(6)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonTirar = new global::Gtk.Button();
			this.buttonTirar.CanFocus = true;
			this.buttonTirar.Name = "buttonTirar";
			this.buttonTirar.UseUnderline = true;
			this.buttonTirar.Label = global::Mono.Unix.Catalog.GetString("Tirar dados");
			this.table1.Add(this.buttonTirar);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.buttonTirar]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Resultado 1");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Resultado 2");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(3));
			w3.RightAttach = ((uint)(4));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Resultado 3");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(4));
			w4.RightAttach = ((uint)(5));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Resultado 4");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(5));
			w5.RightAttach = ((uint)(6));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Contador de tiradas:");
			this.table1.Add(this.label6);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w6.LeftAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelContador = new global::Gtk.Label();
			this.labelContador.Name = "labelContador";
			this.labelContador.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table1.Add(this.labelContador);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.labelContador]));
			w7.LeftAttach = ((uint)(4));
			w7.RightAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelResultadoCuatro = new global::Gtk.Label();
			this.labelResultadoCuatro.Name = "labelResultadoCuatro";
			this.labelResultadoCuatro.LabelProp = global::Mono.Unix.Catalog.GetString("1");
			this.table1.Add(this.labelResultadoCuatro);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.labelResultadoCuatro]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(5));
			w8.RightAttach = ((uint)(6));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelResultadoDos = new global::Gtk.Label();
			this.labelResultadoDos.Name = "labelResultadoDos";
			this.labelResultadoDos.LabelProp = global::Mono.Unix.Catalog.GetString("1");
			this.table1.Add(this.labelResultadoDos);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.labelResultadoDos]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelResultadoTres = new global::Gtk.Label();
			this.labelResultadoTres.Name = "labelResultadoTres";
			this.labelResultadoTres.LabelProp = global::Mono.Unix.Catalog.GetString("1");
			this.table1.Add(this.labelResultadoTres);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.labelResultadoTres]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.LeftAttach = ((uint)(4));
			w10.RightAttach = ((uint)(5));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelResultadoUno = new global::Gtk.Label();
			this.labelResultadoUno.Name = "labelResultadoUno";
			this.labelResultadoUno.LabelProp = global::Mono.Unix.Catalog.GetString("1");
			this.table1.Add(this.labelResultadoUno);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.labelResultadoUno]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.validoCuatro = new global::Gtk.Label();
			this.validoCuatro.Name = "validoCuatro";
			this.validoCuatro.LabelProp = global::Mono.Unix.Catalog.GetString(" ");
			this.table1.Add(this.validoCuatro);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.validoCuatro]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.LeftAttach = ((uint)(5));
			w12.RightAttach = ((uint)(6));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.validoDos = new global::Gtk.Label();
			this.validoDos.Name = "validoDos";
			this.validoDos.LabelProp = global::Mono.Unix.Catalog.GetString(" ");
			this.table1.Add(this.validoDos);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.validoDos]));
			w13.TopAttach = ((uint)(4));
			w13.BottomAttach = ((uint)(5));
			w13.LeftAttach = ((uint)(3));
			w13.RightAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.validoTres = new global::Gtk.Label();
			this.validoTres.Name = "validoTres";
			this.validoTres.LabelProp = global::Mono.Unix.Catalog.GetString(" ");
			this.table1.Add(this.validoTres);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.validoTres]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.LeftAttach = ((uint)(4));
			w14.RightAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.validoUno = new global::Gtk.Label();
			this.validoUno.Name = "validoUno";
			this.validoUno.LabelProp = global::Mono.Unix.Catalog.GetString(" ");
			this.table1.Add(this.validoUno);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.validoUno]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w16.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(4)), ((uint)(7)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Valor 1");
			this.table2.Add(this.label10);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.label10]));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XPadding = ((uint)(15));
			w17.YPadding = ((uint)(15));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Valor 2");
			this.table2.Add(this.label11);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2[this.label11]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XPadding = ((uint)(15));
			w18.YPadding = ((uint)(15));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Valor 3");
			this.table2.Add(this.label12);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.label12]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XPadding = ((uint)(15));
			w19.YPadding = ((uint)(15));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Valor 4");
			this.table2.Add(this.label13);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2[this.label13]));
			w20.LeftAttach = ((uint)(4));
			w20.RightAttach = ((uint)(5));
			w20.XPadding = ((uint)(15));
			w20.YPadding = ((uint)(15));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Valor 5");
			this.table2.Add(this.label14);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2[this.label14]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.LeftAttach = ((uint)(4));
			w21.RightAttach = ((uint)(5));
			w21.XPadding = ((uint)(15));
			w21.YPadding = ((uint)(15));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Valor 6");
			this.table2.Add(this.label15);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.label15]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.LeftAttach = ((uint)(4));
			w22.RightAttach = ((uint)(5));
			w22.XPadding = ((uint)(15));
			w22.YPadding = ((uint)(15));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelValorCinco = new global::Gtk.Label();
			this.labelValorCinco.Name = "labelValorCinco";
			this.labelValorCinco.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table2.Add(this.labelValorCinco);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2[this.labelValorCinco]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.LeftAttach = ((uint)(5));
			w23.RightAttach = ((uint)(6));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelValorCuatro = new global::Gtk.Label();
			this.labelValorCuatro.Name = "labelValorCuatro";
			this.labelValorCuatro.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table2.Add(this.labelValorCuatro);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2[this.labelValorCuatro]));
			w24.LeftAttach = ((uint)(5));
			w24.RightAttach = ((uint)(6));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelValorDos = new global::Gtk.Label();
			this.labelValorDos.Name = "labelValorDos";
			this.labelValorDos.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table2.Add(this.labelValorDos);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2[this.labelValorDos]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(2));
			w25.RightAttach = ((uint)(3));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelValorSeis = new global::Gtk.Label();
			this.labelValorSeis.Name = "labelValorSeis";
			this.labelValorSeis.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table2.Add(this.labelValorSeis);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2[this.labelValorSeis]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.LeftAttach = ((uint)(5));
			w26.RightAttach = ((uint)(6));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelValorTres = new global::Gtk.Label();
			this.labelValorTres.Name = "labelValorTres";
			this.labelValorTres.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table2.Add(this.labelValorTres);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2[this.labelValorTres]));
			w27.TopAttach = ((uint)(2));
			w27.BottomAttach = ((uint)(3));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelValorUno = new global::Gtk.Label();
			this.labelValorUno.Name = "labelValorUno";
			this.labelValorUno.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table2.Add(this.labelValorUno);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2[this.labelValorUno]));
			w28.LeftAttach = ((uint)(2));
			w28.RightAttach = ((uint)(3));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.valorar = new global::Gtk.Label();
			this.valorar.Name = "valorar";
			this.table2.Add(this.valorar);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2[this.valorar]));
			w29.LeftAttach = ((uint)(6));
			w29.RightAttach = ((uint)(7));
			w29.XPadding = ((uint)(15));
			w29.YPadding = ((uint)(15));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table2);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table2]));
			w30.Position = 1;
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
