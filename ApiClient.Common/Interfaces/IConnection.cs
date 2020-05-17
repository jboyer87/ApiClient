using System.Collections.Generic;

namespace ApiClient.Common
{
	/// <summary>
	/// The <c>IConnection</c> interface defines the public interface for basic connections.
	/// </summary>
	public interface IConnection
	{
		#region [Interface Properties]

		/// <summary>
		/// Holds the connection configuration information.
		/// </summary>
		public IConnectionConfiguration ConnectionConfiguration { get; }

		/// <summary>
		/// Returns the current value of the connection config's request type.
		/// </summary>
		public string RequestType { get; }

		/// <summary>
		/// Returns the current value of the connection config's response type;
		/// </summary>
		public string ResponseType { get; }

		#endregion

		#region [Interface Methods]

		/// <summary>
		/// Sends a GET request to the specified <paramref name="url"/> with the specified 
		/// <paramref name="headers"/> and returns the response.
		/// </summary>
		/// <param name="url">The URL to send the request to.</param>
		/// <param name="headers">The headers to send with the request.</param>
		/// <returns>The response from the URL.</returns>
		Response Get(string url, Dictionary<string, string> headers = null);

		/// <summary>
		/// Sends a POST request to the specified <paramref name="url"/> with the specified 
		/// <paramref name="headers"/> and <paramref name="body"/> and returns the response.
		/// </summary>
		/// <param name="url">The URL to send the request to.</param>
		/// <param name="headers">The headers to send with the request.</param>
		/// <param name="body">The request body.</param>
		/// <returns>The response from the URL.</returns>
		Response Post(string url, Dictionary<string, string> headers = null, string body = "");

		#endregion
	}
}
