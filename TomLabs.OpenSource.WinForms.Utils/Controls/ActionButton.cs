using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomLabs.OpenSource.WinForms.Utils.Controls
{
	public class ActionButton : Button
	{
		public Action Action { get; set; }

		public ActionButton(Action action, string text)
		{
			Action = action;
			Text = text;

			Click += (object sender, EventArgs e) => { Action.Invoke(); };
		}
	}
}
