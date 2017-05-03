using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TomLabs.OpenSource.WinForms.Utils.SyntaxHiglithing
{
	public static class SyntaxExtensions
	{
		public static void SetSyntax(this Range range, ISyntax syntax)
		{
			syntax.SetStyles(range);
		}

		public static void HighlightText(this Range range, string text, ISyntax syntax,
			RegexOptions regexOptions = RegexOptions.IgnoreCase | RegexOptions.Singleline)
		{
			syntax.HighlightText(range, text, regexOptions);
		}
	}
}
