using System;
using ApiClient.Utilities.Interfaces;

namespace ApiClient.Common.Interfaces
{
	/// <summary>
	/// The <c>IAccessToken</c> interface defines the public interface for access token objects.
	/// </summary>
	public interface IAccessToken : IValidatable
	{
		#region [Interface Properties]

		/// <summary>
		/// How long until the <see cref="Token"/> expires.
		/// </summary>
		public TimeSpan ExpiresIn { get; set; }

		/// <summary>
		/// When the <see cref="Token"/> expires.
		/// </summary>
		public DateTime? ExpiresAt { get; }

		/// <summary>
		/// The token.
		/// </summary>
		public string Token { get; set; }

		/// <summary>
		/// The <see cref="Token"/> type.
		/// </summary>
		public string TokenType { get; set; }

		#endregion
	}
}
