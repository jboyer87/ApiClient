using System.Net;

namespace ApiClient.Common
{
	/// <summary>
	/// The <c>Response</c> class represents an API response.
	/// </summary>
	public class Response
	{
		#region [Constructors]

		public Response(HttpStatusCode statusCode, string message)
		{
			StatusCode = statusCode;
			Message = message;
		}

		#endregion

		#region [Properties]

		/// <summary>
		/// The message returned by the API.
		/// </summary>
		public string Message { get; private set; }

		/// <summary>
		/// The <c>HttpStatusCode</c> returned by the API.
		/// </summary>
		public HttpStatusCode StatusCode { get; private set; }

		#endregion

	}
}
