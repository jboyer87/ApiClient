using System.Collections.Generic;

namespace ApiClient.Common.Interfaces
{
	/// <summary>
	/// The <c>IConnection</c> interface defines the public interface for basic connections.
	/// </summary>
	public interface IConnection
	{
		#region [Interface Methods]

		/// <summary>
		/// Sends a GET request to the specified <paramref name="url"/> with the specified 
		/// <paramref name="headers"/> and returns the response.
		/// </summary>
		/// <param name="url">The URL to send the request to.</param>
		/// <param name="headers">The headers to send with the request.</param>
		/// <returns>The response from the URL.</returns>
		Response Get(string url, Dictionary<string, string> headers);

		/// <summary>
		/// Sends a POST request to the specified <paramref name="url"/> with the specified 
		/// <paramref name="headers"/> and <paramref name="body"/> and returns the response.
		/// </summary>
		/// <param name="url">The URL to send the request to.</param>
		/// <param name="headers">The headers to send with the request.</param>
		/// <param name="body">The request body.</param>
		/// <returns>The response from the URL.</returns>
		Response Post(string url, Dictionary<string, string> headers, string body);

		#endregion
	}
}
