using System;
using System.ComponentModel.DataAnnotations;
using ApiClient.Utilities;

namespace ApiClient.Common
{
	public class AccessToken : BasicValidator, IAccessToken
	{
		#region [Properties]
		
		/// <summary>
		/// How long until the token expires.
		/// </summary>
		[Required]
		public TimeSpan ExpiresIn
		{
			get {
				return _expiresIn;
			}

			set
			{
				_expiresIn = value;
				this.ExpiresAt = DateTime.Now.Add(value);
			}
		}
		
		/// <summary>
		/// When the token is set to expire.
		/// </summary>
		[Required]
		[FutureDate(ErrorMessage = "Access token has expired.")]
		public DateTime? ExpiresAt { get; private set; }
		
		/// <summary>
		/// The token's type.
		/// </summary>
		[Required]
		public string TokenType { get; set; }
		
		/// <summary>
		/// The access token.
		/// </summary>
		[Required]
		public string Token { get; set; }

		#endregion

		#region [Fields]

		/// <summary>
		/// Backing field for <see cref="ExpiresIn"/>.
		/// </summary>
		private TimeSpan _expiresIn;

		#endregion
	}
}
