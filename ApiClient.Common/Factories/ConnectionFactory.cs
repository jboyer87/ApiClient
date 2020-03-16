using System;
using System.Collections.Generic;
using System.Text;
using ApiClient.Common.Interfaces;

namespace ApiClient.Common.Factories
{
	public class ConnectionFactory
	{
		public IConnection GetConnection(IConnectionConfiguration connectionConfig)
		{
			switch (_connectionConfigTypes[connectionConfig.GetType()])
			{
				case (int)_connectionTypes.BasicConnectionConfig:
					return new BasicConnection(connectionConfig);
				case (int)_connectionTypes.BasicAuthConnectionConfig:
					return new BasicAuthConnection(connectionConfig);
				default:
					throw new InvalidOperationException("Unable to determine connection" +
						"type based on config type.");
			}
		}

		private static Dictionary<Type, int> _connectionConfigTypes = 
			new Dictionary<Type, int>
			{
				{ 
					typeof(BasicConnectionConfig), 
					(int)_connectionTypes.BasicConnectionConfig 
				},
				{ 
					typeof(BasicAuthConnectionConfig), 
					(int)_connectionTypes.BasicAuthConnectionConfig 
				},
			};

		private enum _connectionTypes
		{
			BasicConnectionConfig = 0,
			BasicAuthConnectionConfig = 1
		};
	}
}
