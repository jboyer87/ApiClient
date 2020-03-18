using System;
using System.ComponentModel.DataAnnotations;
using ApiClient.Common.Interfaces;

namespace ApiClient.Common
{
	/// <summary>
	/// The <c>BasicAuthConnectionConfig</c> class contains all configuration properties required to
	/// make a <c>BasicAuthConnection</c>.
	/// </summary>
	public class BasicAuthConnectionConfig : BasicConnectionConfig, IConnectionConfiguration
	{
		#region [Constructors]

		/// <summary>
		/// Instantiates a <c>BasicConnectionConfig</c> object using the supplied parameters.
		/// </summary>
		/// <param name="baseRequestUrl">The base request URL for all API requests.</param>
		/// <param name="responseType">The API response type.</param>
		/// <param name="requestType">The client request type.</param>
		public BasicAuthConnectionConfig(Uri baseRequestUrl, ResponseType responseType, 
			RequestType requestType, string username, string password)
			: base(baseRequestUrl, responseType, requestType)
		{
			Username = username;
			Password = password;
		}

		#endregion

		#region [Properties]
		
		/// <summary>
		/// The username.
		/// </summary>
		[Required]
		public string Username { get; private set; }

		/// <summary>
		/// The password.
		/// </summary>
		[Required]
		public string Password { get; private set; }

		#endregion
	}
}
