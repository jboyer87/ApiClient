using System;
using System.Collections.Generic;

namespace ApiClient.Common
{
	/// <summary>
	/// The <c>ConnectionFactory</c> class creates <c>IConnection</c> objects.
	/// </summary>
	public static class ConnectionFactory
	{
		#region [Constructors]

		/// <summary>
		/// Gets a connection based on the type of <paramref name="connectionConfig"/> passed in.
		/// </summary>
		/// <param name="connectionConfig">The connection configuration for the connection</param>
		/// <returns>
		/// An <c>IConnection</c> matching the <paramref name="connectionConfig"/> type.
		/// </returns>
		public static IConnection GetConnection(IConnectionConfiguration connectionConfig)
		{
			switch (_connectionConfigTypes[connectionConfig.GetType()])
			{
				case (int)_connectionTypes.BasicConnectionConfig:
					return new BasicConnection(connectionConfig);
				case (int)_connectionTypes.BasicAuthConnectionConfig:
					return new BasicAuthConnection(connectionConfig);
				default:
					throw new InvalidOperationException("Unable to determine connection" +
						"type based on configuration type.");
			}
		}

		#endregion

		#region [Fields]

		/// <summary>
		/// Exposes the different available connection types.
		/// </summary>
		private static readonly Dictionary<Type, int> _connectionConfigTypes = 
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

		/// <summary>
		/// The different available connection types.
		/// </summary>
		private enum _connectionTypes
		{
			BasicConnectionConfig = 0,
			BasicAuthConnectionConfig = 1
		};

		#endregion
	}
}
