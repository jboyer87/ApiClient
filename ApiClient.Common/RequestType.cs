namespace ApiClient.Common
{
	/// <summary>
	/// The <c>RequestType</c> class models the common API request types.
	/// </summary>
	public class RequestType
	{
		#region [Constructors]

		/// <summary>
		/// Sets the <see cref="Type"/> to the specified <paramref name="type"/>.
		/// </summary>
		/// <param name="type">The API request type.</param>
		private RequestType(string type)
		{
			Type = type;
		}

		#endregion

		#region [Properties]

		/// <summary>
		/// The API request type.
		/// </summary>
		public string Type { get; private set; }

		/// <summary>
		/// Represents the application/x-www-form-urlencoded request type.
		/// </summary>
		public static RequestType Form
		{
			get
			{
				return new RequestType("application/x-www-formurlencoded");
			}
		}

		/// <summary>
		/// Represents the application/json request type.
		/// </summary>
		public static RequestType Json
		{
			get
			{
				return new RequestType("application/json");
			}
		}

		#endregion
	}
}
