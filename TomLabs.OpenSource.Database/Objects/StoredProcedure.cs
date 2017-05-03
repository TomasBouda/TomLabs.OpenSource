using TomLabs.Database.OpenSource.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.Database.OpenSource.Data
{
	public interface IStoredProcedure : IDbObject
	{
	}

	public class StoredProcedure<T> : DbObject<T>, IStoredProcedure, IDbObject where T : class, IDB, new()
	{
		public StoredProcedure(string schema, string name, T db) 
			: base(schema, name, db, () => db.GetScriptFor(name, EDbObjects.StoredProcedures)) { }


	}
}
