using Gtk;
using System;
namespace Serpis.Ad
{
    public class WindowHelper
    {
        public static bool Confirm(Window parent, string message) {
			MessageDialog messageDialog = new MessageDialog(
                parent,
				DialogFlags.Modal,
				MessageType.Question,
				ButtonsType.YesNo,
                message
			);

			messageDialog.Title = parent.Title;

			ResponseType response = (ResponseType)messageDialog.Run();
			messageDialog.Destroy();

            return response == ResponseType.Yes; 
        }

		public static bool Warning(Window parent, string message) {
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
