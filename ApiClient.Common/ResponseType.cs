namespace ApiClient.Common
{
	/// <summary>
	/// The <c>ResponseType</c> class models the common API response types.
	/// </summary>
	public class ResponseType
	{
		#region [Constructors]

		/// <summary>
		/// Sets the <see cref="Type"/> to the specified <paramref name="type"/>.
		/// </summary>
		/// <param name="type">The API response type.</param>
		private ResponseType(string type)
		{
			Type = type;
		}

		#endregion

		#region [Properties]

		/// <summary>
		/// The API response type.
		/// </summary>
		public string Type { get; private set; }

		/// <summary>
		/// Represents the text/html response type.
		/// </summary>
		public static ResponseType Html { 
			get { 
				return new ResponseType("text/html"); 
			} 
		}

		/// <summary>
		/// Represents the application/json response type.
		/// </summary>
		public static ResponseType Json
		{
			get
			{
				return new ResponseType("application/json");
			}
		}

		/// <summary>
		/// Represents the text/plain response type.
		/// </summary>
		public static ResponseType PlainText { 
			get { 
				return new ResponseType("text/plain"); 
			} 
		}

		#endregion
	}
}
