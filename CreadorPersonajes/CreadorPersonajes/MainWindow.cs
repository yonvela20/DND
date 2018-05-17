﻿using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;
using CreadorPersonajes;
using Serpis.Ad;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		Title = "Personajes";
		App.Instance.Connection = new MySqlConnection("server=localhost;database=dnd;user=root;password=administrador");
		App.Instance.Connection.Open();

		image.Pixbuf = new Gdk.Pixbuf("Elfo.png");
		comboBoxRaza.Changed += delegate
		{
			image.Pixbuf = new Gdk.Pixbuf(comboBoxRaza.ActiveText + ".png");
		};

		newAction.Activated += delegate
		{
			Creador personaje = new Creador();
			new CreadorWindow(personaje);
		};

		//findAction.Activated += delegate
		//{
		//	new VisorWindow();
		//};

		buttonView.Clicked += delegate
		{
			new VisorWindow();
		};

		//El boton de los dados esta puesto en la ventana de creacion para que sea mas intuitivo
		//Aqui se pondra otra ventana para los dados
		//buttonDados.Clicked += delegate {
		//	new DadosWindow();
		//};
}
	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}