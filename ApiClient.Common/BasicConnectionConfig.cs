using System;
using System.ComponentModel.DataAnnotations;
using ApiClient.Utilities;

namespace ApiClient.Common
{
	/// <summary>
	/// The <c>BasicConnectionConfig</c> class contains all configuration properties required to
	/// make a <c>BasicConnection</c>.
	/// </summary>
	public class BasicConnectionConfig : BasicValidator, IConnectionConfiguration
	{
		#region [Constructors]

		/// <summary>
		/// Instantiates a <c>BasicConnectionConfig</c> object using the supplied parameters.
		/// </summary>
		/// <param name="baseRequestUrl">The base request URL for all API requests.</param>
		/// <param name="responseType">The API response type.</param>
		/// <param name="requestType">The client request type.</param>
		public BasicConnectionConfig(Uri baseRequestUrl, ResponseType responseType, 
			RequestType requestType)
		{
			BaseRequestUrl = baseRequestUrl;
			ResponseType = responseType;
			RequestType = requestType;
		}

		#endregion

		#region [Properties]

		/// <summary>
		/// The base request URL for the API connection.
		/// </summary>
		[Required]
		public Uri BaseRequestUrl { get; private set; }

		/// <summary>
		/// The <c>ResponseType</c> for all API connection responses. Defaults to application/json.
		/// </summary>
		[Required]
		public ResponseType ResponseType { get; private set; } = ResponseType.Json;

		/// <summary>
		/// The <c>RequestType</c> for all API connection request. Defaults to application/json.
		/// </summary>
		[Required]
		public RequestType RequestType { get; private set; } = RequestType.Json;

		#endregion
	}
}
