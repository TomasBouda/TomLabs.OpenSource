using TomLabs.Database.OpenSource.Data;
using TomLabs.Database.OpenSource.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.Database.OpenSource.Search
{
	public class SearchResults
	{
		public IList<IDbObject> FoundDbObjects { get; set; }
		public bool Error { get; set; }
		public string ErrorMessage { get; set; }
	}
}
