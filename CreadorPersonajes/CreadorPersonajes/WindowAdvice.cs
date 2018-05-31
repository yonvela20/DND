using System;
using Gtk;
namespace CreadorPersonajes
{

	//Clase provisional hasta que sepa cogerla desde WindowHelper
	public class WindowAdvice
	{
		public static bool Warning(Window parent, string message)
		{
			MessageDialog messageDialog = new MessageDialog(
				parent,
				DialogFlags.Modal,
				MessageType.Warning,
				ButtonsType.Ok,
				message
			);

			messageDialog.Title = parent.Title;
			ResponseType response = (ResponseType)messageDialog.Run();

			return response == ResponseType.Ok;
		}
	}
}
