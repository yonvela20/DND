using System;
namespace CreadorPersonajes
{
	public class Creador
	{

		//He cambiado Raza por un string antes era un int 
		private long id;
		private String nombre = "";
		private String raza = "";
		private int fuerza;
		private int destreza;
		private int constitución;
		private int inteligencia;
		private int sabiduria;
		private int carisma;

		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		public String Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public String Raza
		{
			get { return raza; }
			set { raza = value; }
		}

		public int Fuerza
		{
			get { return fuerza; }
			set { fuerza = value; }
		}

		public int Destreza
		{
			get { return destreza; }
			set { destreza = value; }
		}

		public int Constitucion
		{
			get { return constitución; }
			set { constitución = value; }
		}

		public int Inteligencia
		{
			get { return inteligencia; }
			set { inteligencia = value; }
		}
		public int Sabiduria
		{
			get { return sabiduria; }
			set { sabiduria = value; }
		}
		public int Carisma
		{
			get { return carisma; }
			set { carisma = value; }
		}
	}
}
