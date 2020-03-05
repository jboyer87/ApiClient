using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClient.Utilities.Interfaces
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
