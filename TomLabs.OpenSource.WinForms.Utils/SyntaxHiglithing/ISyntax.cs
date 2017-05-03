using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TomLabs.OpenSource.WinForms.Utils.SyntaxHiglithing
{
	public interface ISyntax
	{
		Range SetStyles(Range range);
		void HighlightText(Range range, string text, RegexOptions regexOptions);
	}
}
