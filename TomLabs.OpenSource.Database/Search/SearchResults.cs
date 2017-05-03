using TomLabs.OpenSource.Database.Data;
using TomLabs.OpenSource.Database.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.OpenSource.Database.Search
{
	public class SearchResults
	{
		public IList<IDbObject> FoundDbObjects { get; set; }
		public bool Error { get; set; }
		public string ErrorMessage { get; set; }
	}
}
