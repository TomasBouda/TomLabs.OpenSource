﻿using TomLabs.Database.OpenSource.DataProviders;
using TomLabs.Database.OpenSource.DataProviders.ConnectionParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.Database.OpenSource.Search
{
	public class DataProvider
	{

		private IList<IDatabaseManager> DatabaseManagers { get; set; }

		public IDatabaseManager ActiveManager { get; set; }

		public DataProvider()
		{
			DatabaseManagers = new List<IDatabaseManager>();
		}

		public IDatabaseManager SetActiveManager(string managerName)
		{
			return ActiveManager = DatabaseManagers.SingleOrDefault(m => m.Name == managerName);
		}

		public void AddManager(IDatabaseManager manager)
		{
			if (!DatabaseManagers.Any(m => m.Name == manager.Name))
				DatabaseManagers.Add(manager);
			else
			{
				//throw new Exception("Database manager name must be unique");
				var mgr = DatabaseManagers.Single(m => m.Name == manager.Name);
				mgr = manager;
				Console.WriteLine("Manager replaced."); //TODO
			}	
		}
		
		public void AddMssqlManager(string managerName, string server, string database, string username = null, string password = null)
		{
			DatabaseManager<MSSQL> manager = new DatabaseManager<MSSQL>(managerName);
			manager.Connect(new MSSQLConnectionParams() { Server = server, Database = database, Username = username, Password = password });
			AddManager(manager);
		}

		public ConnectionResult AddMSSqlManager(string managerName, MSSQLConnectionParams connParams, bool setActive = false)
		{
			DatabaseManager<MSSQL> manager = new DatabaseManager<MSSQL>(managerName);
			var connResult = manager.Connect(connParams);
			if (connResult.Success)
			{
				AddManager(manager);
				SetActiveManager(managerName);
			}

			return connResult;
		}

		public ConnectionResult AddMySqlManager(string managerName, MySqlConnectionParams connParams)
		{
			DatabaseManager<DataProviders.MySql> manager = new DatabaseManager<DataProviders.MySql>(managerName);
			var connResult = manager.Connect(connParams);
			if (connResult.Success)
				AddManager(manager);

			return connResult;
		}

		public IDatabaseManager GetMssqlManager(string managerName)// TODO lambda - m => m.ConnectionString ==...
		{
			return DatabaseManagers.SingleOrDefault(m => m.Name == managerName);
		}
	}
}
