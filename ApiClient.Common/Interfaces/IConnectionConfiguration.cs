using System;
using System.ComponentModel.DataAnnotations;
using ApiClient.Utilities.Interfaces;

namespace ApiClient.Common.Interfaces
{
	/// <summary>
	/// The <c>IConnectionConfiguration</c> interface defines the public interface for connection
	/// configuration objects.
	/// </summary>
	public interface IConnectionConfiguration : IValidatable
	{
		#region [Properties]

		/// <summary>
		/// The base request URL for the API connection.
		/// </summary>
		[Required]
		public Uri BaseRequestUrl { get; }

		/// <summary>
		/// The <c>ResponseType</c> for all API connection responses.
		/// </summary>
		[Required]
		public ResponseType ResponseType { get; }

		/// <summary>
		/// The <c>RequestType</c> for all API connection request.
		/// </summary>
		[Required]
		public RequestType RequestType { get; }

		#endregion
	}
}
