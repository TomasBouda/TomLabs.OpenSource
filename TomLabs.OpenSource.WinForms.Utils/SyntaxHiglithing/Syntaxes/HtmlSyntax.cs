using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TomLabs.OpenSource.WinForms.Utils.SyntaxHiglithing.Syntaxes
{
	public class HtmlSyntax : Syntax, ISyntax
	{
		public readonly Style BlueVioletStyle = new TextStyle(Brushes.LightSkyBlue, null, FontStyle.Regular);
		public readonly Style BlueStyle = new TextStyle(Brushes.DodgerBlue, null, FontStyle.Regular);
		public readonly Style CoralStyle = new TextStyle(Brushes.Coral, null, FontStyle.Regular);
		public readonly Style GreenStyle = new TextStyle(Brushes.LimeGreen, null, FontStyle.Italic);
		public readonly Style RedStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);

		public readonly string[] HTML_ATTR_KEYWORDS = new string[]
		{
			"href","src","height","width","rowspan","colspan","target","style","onclick","id","name","class", "alt", "rel", "charset"
		};


		public HtmlSyntax()
		{

		}

		public override Range SetStyles(Range range)
		{
			base.SetStyles(range);

			range.ClearStyle(BlueStyle);
			range.ClearStyle(CoralStyle);
			range.ClearStyle(BlueVioletStyle);
			range.ClearStyle(GreenStyle);
			range.ClearStyle(RedStyle);

			range.SetStyle(BlueStyle, @"(<\w|</|<!)(.*?)(/?>|\s)", RegexOptions.Multiline);
			range.SetStyle(BlueStyle, ">", RegexOptions.Multiline);
			range.SetStyle(CoralStyle, "\"(.*?)\"", RegexOptions.Multiline);
			range.SetStyle(GreenStyle, "<!--(.*?)>", RegexOptions.Multiline);
			range.SetStyle(RedStyle, "{{(.*?)}}", RegexOptions.Multiline);
			range.SetStyle(BlueVioletStyle, $@"\b({string.Join("|", HTML_ATTR_KEYWORDS)})\b", RegexOptions.IgnoreCase);

			return range;
		}
	}
}
