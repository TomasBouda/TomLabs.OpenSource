using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.Database.OpenSource.DataProviders.ConnectionParams
{
	public interface IConnectionParams
	{
		string Server { get; set; }
		string Database { get; set; }
	}
}
