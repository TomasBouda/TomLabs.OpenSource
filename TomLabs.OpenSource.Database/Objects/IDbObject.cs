using TomLabs.OpenSource.Database.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.OpenSource.Database.Data
{
	public interface IDbObject
	{
		string Schema { get; }
		string Name { get; }

		string Script { get; }
	}
}
