using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomLabs.OpenSource.WinForms.Utils.Controls;
using TomLabs.OpenSource.WinForms.Utils.Forms;

namespace TomLabs.OpenSource.WinForms.Utils.Forms
{
	public static class EasyMessageBox
	{
		public static DialogResult Error(string message)
		{
			return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static DialogResult Error(Exception ex)
		{
			return MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static DialogResult MessageWithActions(string title, string message, string okButtonText, params ActionButton[] actionButtons)
		{
			using(var form = new MessageForm(title, message, okButtonText, actionButtons))
			{
				return form.ShowDialog();
			}
		}
	}
}
