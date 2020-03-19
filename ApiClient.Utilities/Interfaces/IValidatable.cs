namespace ApiClient.Utilities
{
	/// <summary>
	/// Represents a validatable object.
	/// </summary>
	public interface IValidatable
	{
		#region [Interface Methods]

		/// <summary>
		/// Validates the object.
		/// </summary>
		/// <returns>True if the object is valid, otherwise false.</returns>
		bool IsValid();

		#endregion
	}
}
