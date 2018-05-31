using System;
namespace CreadorPersonajes
{
	public partial class DadosWindow : Gtk.Window
	{
		public DadosWindow() :	base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			Title = "Asistente de creador";
			Random rnd = new Random();

			//Resultados de los dados
			int resultadoUno = 0, resultadoDos = 0, resultadoTres = 0, resultadoCuatro = 0;
			string resultadoTextoUno, resultadoTextoDos, resultadoTextoTres, resultadoTextoCuatro;

			//Suma de los valores obtenidos
			int valorUno = 0, valorDos = 0, valorTres = 0;
			int valorCuatro = 0, valorCinco = 0, valorSeis = 0;
			string valorUnoTexto, valorDosTexto, valorTresTexto;
			string valorCuatroTexto, valorCincoTexto, valorSeisTexto;

			int contador = 0;
			string contadorTexto;

			buttonTirar.Clicked += delegate {

				//se deben tirar los dados 6 veces por habilidad. Una por cada habilidad
				contador++;
				contadorTexto = contador.ToString();
				labelContador.Text = contadorTexto;

				if (contador == 7) {
					labelContador.Text = "0";
					contador = 0;
				}

				//Borramos el valor de los labels que te dicen si son validos o no 
				validoUno.Text = " ";
				validoDos.Text = " ";
				validoTres.Text = " ";
				validoCuatro.Text = " ";

				//Resultado del primer dado
				resultadoUno = rnd.Next(1, 7);
				resultadoTextoUno = resultadoUno.ToString();
				labelResultadoUno.Text = resultadoTextoUno;

				//Resultado del segundo dado
				resultadoDos = rnd.Next(1, 7);
				resultadoTextoDos = resultadoDos.ToString();
				labelResultadoDos.Text = resultadoTextoDos;

				//Resultado del tercer dado
				resultadoTres = rnd.Next(1, 7);
				resultadoTextoTres = resultadoTres.ToString();
				labelResultadoTres.Text = resultadoTextoTres;

				//Resultado del cuarto dado
				resultadoCuatro = rnd.Next(1, 7);
				resultadoTextoCuatro = resultadoCuatro.ToString();
				labelResultadoCuatro.Text = resultadoTextoCuatro;

				//Determinamos que valor es el que no se utiliza
				//Si tenemos la casualidad de tener más de un valor igual se utilizan todos

				//if (resultadoUno < resultadoDos && resultadoUno < resultadoTres
				//	&& resultadoUno < resultadoCuatro)
				//{
				//	validoUno.Text = "Este valor se descarta";

				//}
				//else if (resultadoDos < resultadoUno && resultadoDos < resultadoTres
				//	&& resultadoDos < resultadoCuatro)
				//{
				//	validoDos.Text = "Este valor se descarta";
				//}
				//else if (resultadoTres < resultadoUno && resultadoTres < resultadoDos
				//	&& resultadoTres < resultadoCuatro)
				//{
				//	validoTres.Text = "Este valor se descarta";
				//}
				//else if (resultadoCuatro < resultadoUno && resultadoCuatro < resultadoDos
				//	&& resultadoCuatro < resultadoTres)
				//{
				//	validoCuatro.Text = "Este valor se descarta";
				//}

				//Visualizacion de los valores obtenidos (Hay que hacer que se reste el valor más pequeño)
				//TODO Hacer que el menor resultado no esté en la suma
				if (contador == 1)
				{
					valorUno = resultadoUno + resultadoDos + resultadoTres + resultadoCuatro;
					valorUnoTexto = valorUno.ToString();
					labelValorUno.Text = valorUnoTexto;
				}
				else if (contador == 2)
				{
					valorDos = resultadoUno + resultadoDos + resultadoTres + resultadoCuatro;
					valorDosTexto = valorDos.ToString();
					labelValorDos.Text = valorDosTexto;
				}
				else if (contador == 3)
				{
					valorTres = resultadoUno + resultadoDos + resultadoTres + resultadoCuatro;
					valorTresTexto = valorTres.ToString();
					labelValorTres.Text = valorTresTexto;
				}
				else if (contador == 4)
				{
					valorCuatro = resultadoUno + resultadoDos + resultadoTres + resultadoCuatro;
					valorCuatroTexto = valorCuatro.ToString();
					labelValorCuatro.Text = valorCuatroTexto;
				}
				else if (contador == 5)
				{
					valorCinco = resultadoUno + resultadoDos + resultadoTres + resultadoCuatro;
					valorCincoTexto = valorCinco.ToString();
					labelValorCinco.Text = valorCincoTexto;
				}
				else if (contador == 6)
				{
					valorSeis = resultadoUno + resultadoDos + resultadoTres + resultadoCuatro;
					valorSeisTexto = valorSeis.ToString();
					labelValorSeis.Text = valorSeisTexto;
				}else {
					labelValorUno.Text = "0";
					labelValorDos.Text = "0";
					labelValorTres.Text = "0";
					labelValorCuatro.Text = "0";
					labelValorCinco.Text = "0";
					labelValorSeis.Text = "0";
				}
			};
		}
	}
}
