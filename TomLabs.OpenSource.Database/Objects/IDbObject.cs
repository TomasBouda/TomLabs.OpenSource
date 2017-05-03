using TomLabs.Database.OpenSource.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.Database.OpenSource.Data
{
	public interface IDbObject
	{
		string Schema { get; }
		string Name { get; }

		string Script { get; }
	}
}
