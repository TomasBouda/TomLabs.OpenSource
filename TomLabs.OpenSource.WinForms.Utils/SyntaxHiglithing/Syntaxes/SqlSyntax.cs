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
	public class SqlSyntax : Syntax, ISyntax
	{
		public readonly Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
		public readonly Style BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
		public readonly Style GrayStyle = new TextStyle(Brushes.DarkSlateGray, null, FontStyle.Regular);
		public readonly Style PurpleStyle = new TextStyle(Brushes.DeepPink, null, FontStyle.Regular);
		public readonly Style RedStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
		public readonly Style LimeStyle = new TextStyle(Brushes.LimeGreen, null, FontStyle.Regular);
		public readonly Style BoldStyle = new TextStyle(Brushes.Black, null, FontStyle.Italic);

		public readonly string[] SQL_BLUE_KEYWORDS = new string[]
		{
			"select", "create", "as", "alter", "begin", "declare", "table", "where", "from", "end", "else", "if", "set", "procedure", "in", "insert",
			"into", "order", "by", "desc", "asc", "case", "when", "delete", "then", "cast", "union", "view", "on", "group", "int", "varchar", "truncate",
			"return", "values", "decimal", "exec", "char", "returns", "with", "SCHEMABINDING", "nvarchar", "SCOPE_IDENTITY", "IDENTITY_INSERT"
		};
		public readonly string[] SQL_GRAY_KEYWORDS = new string[] 
		{
			"and", "or", "join", "left", "right", "inner", "outer", "exists", "not"
		};
		public readonly string[] SQL_PURPLE_KEYWORDS = new string[] 
		{
			"isnull", "getdate", "update", "count", "sum"
		};

		public SqlSyntax()
		{

		}

		public override Range SetStyles(Range range)
		{
			base.SetStyles(range);

			range.ClearStyle(BlueStyle);
			range.ClearStyle(GreenStyle);
			range.ClearStyle(GrayStyle);
			range.ClearStyle(PurpleStyle);

			range.SetStyle(GreenStyle, @"--.*$", RegexOptions.Multiline);
			range.SetStyle(GreenStyle, @"^/\*(.*)\*/$", RegexOptions.Multiline);
			range.SetStyle(RedStyle, @"'(.*?)'", RegexOptions.IgnoreCase);
			range.SetStyle(GrayStyle, @"\(", RegexOptions.Multiline);
			range.SetStyle(GrayStyle, @"\)", RegexOptions.Multiline);
			range.SetStyle(GrayStyle, @",", RegexOptions.Multiline);
			range.SetStyle(GrayStyle, @"&", RegexOptions.Multiline);
			range.SetStyle(BoldStyle, @"@(.*?)\s", RegexOptions.Multiline);

			range.SetStyle(BlueStyle, $@"\b({string.Join("|", SQL_BLUE_KEYWORDS)})\b", RegexOptions.IgnoreCase);
			range.SetStyle(GrayStyle, $@"\b({string.Join("|", SQL_GRAY_KEYWORDS)})\b", RegexOptions.IgnoreCase);
			range.SetStyle(PurpleStyle, $@"\b({string.Join("|", SQL_PURPLE_KEYWORDS)})\b", RegexOptions.IgnoreCase);
			range.SetStyle(LimeStyle, @"\b(INFORMATION_SCHEMA|TABLES)\b", RegexOptions.IgnoreCase);

			return range;
		}
	}
}
