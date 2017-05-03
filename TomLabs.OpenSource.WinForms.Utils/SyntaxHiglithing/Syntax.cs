using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TomLabs.OpenSource.WinForms.Utils.SyntaxHiglithing
{
	public abstract class Syntax : ISyntax
	{
		public readonly Style HighlithStyle = new TextStyle(null, Brushes.Orange, FontStyle.Regular);

		public virtual Range SetStyles(Range range)
		{
			return range;
		}

		public virtual void HighlightText(Range range, string text, RegexOptions regexOptions = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			range.ClearStyle(HighlithStyle);
			range.SetStyle(HighlithStyle, text, regexOptions);
		}
	}
}
