using System;
using System.Collections.Generic;

namespace ApiClient.Common
{
	/// <summary>
	/// The <c>BasicAuthConnection</c> class allows you to connect to and make requests against an API
	/// that requires token-based authentication.
	/// </summary>
	public class BasicAuthConnection : BasicConnection, IConnection
	{
		#region [Constructors]

		public BasicAuthConnection(IConnectionConfiguration connectionConfiguration) 
			: base(connectionConfiguration)
		{
			if (!connectionConfiguration.IsValid())
			{
				throw new ArgumentException("Connection configuration is not valid");
			}

			ConnectionConfiguration = (BasicAuthConnectionConfig)connectionConfiguration;
		}

		#endregion

		#region [Properties]

		/// <summary>
		/// Holds the connection configuration information.
		/// </summary>
		public new BasicAuthConnectionConfig ConnectionConfiguration { get; private set; }

		#endregion

		#region [Public Methods]

		/// <summary>
		/// Sends a GET request to the specified <paramref name="url"/> with the specified
		/// <paramref name="headers"/>.
		/// </summary>
		/// <param name="url">The API endpoint.</param>
		/// <param name="headers">The headers to send with the request (optional).</param>
		/// <returns>A <c>Response</c> object.</returns>
		public override Response Get(string url, Dictionary<string, string> headers = null)
		{
			string username = ConnectionConfiguration.Username;
			string password = ConnectionConfiguration.Password;

			AddBasicAuthenticationHeader(ref headers, username, password);

			var requestUrl = new Uri(ConnectionConfiguration.BaseRequestUrl, url);

			Response response = SendWebRequest(requestUrl, headers);

			return response;
		}

		/// <summary>
		/// Sends a POST request to the specified <paramref name="url"/> with the specified
		/// <paramref name="headers"/> and <paramref name="body"/>.
		/// </summary>
		/// <param name="url">The API endpoint.</param>
		/// <param name="headers">The headers to send with the request (optional).</param>
		/// <param name="body">The request body (optional).</param>
		/// <returns>A <c>Response</c> object.</returns>
		public override Response Post(string url, Dictionary<string, string> headers = null,
			string body = "")
		{
			string username = ConnectionConfiguration.Username;
			string password = ConnectionConfiguration.Password;

			AddBasicAuthenticationHeader(ref headers, username, password);

			var requestUrl = new Uri(ConnectionConfiguration.BaseRequestUrl, url);

			Response response = SendWebRequest(requestUrl, headers);

			return response;
		}

		#endregion

		#region [Private Methods]

		/// <summary>
		/// Encodes the <paramref name="username"/> and <paramref name="password"/> for basic 
		/// authentication into a Base 64 byte string.
		/// </summary>
		/// <param name="username">The username.</param>
		/// <param name="password">The password.</param>
		/// <returns>
		/// A Base 64-encoded byte string that represents the 
		/// <paramref name="username"/>:<paramref name="password"/> pair.
		/// </returns>
		private static string GetEncodedCredentials(string username, string password)
		{
			string combined = username + ":" + password;

			byte[] bytes = System.Text.Encoding.UTF8.GetBytes(combined);

			return System.Convert.ToBase64String(bytes);
		}

		/// <summary>
		/// Adds the provided <paramref name="username"/> and <paramref name="password"/> to the
		/// headers for basic authentication.
		/// </summary>
		/// <param name="headers">The headers to add the authentication to.</param>
		/// <param name="username">The username.</param>
		/// <param name="password">The password</param>
		private static void AddBasicAuthenticationHeader(ref Dictionary<string, string> headers, 
			string username, string password)
		{
			string credentials = GetEncodedCredentials(username, password);

			if (headers == null)
			{
				headers = new Dictionary<string, string>();
			}

			headers.Add("Authorization", "Basic " + credentials);
		}

		#endregion
	}
}
