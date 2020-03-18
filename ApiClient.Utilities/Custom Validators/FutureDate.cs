using System;
using System.ComponentModel.DataAnnotations;

namespace ApiClient.Utilities.CustomValidators
{
	/// <summary>
	/// The <c>FutureDate</c> class implements a custom validator that ensures that a date is some
	/// time in the future.
	/// </summary>
	public class FutureDate : ValidationAttribute
	{
		#region [Public Methods]

		/// <summary>
		/// Ensures that a <c>DateTime</c> value is in the future.
		/// </summary>
		/// <param name="value">The value to validate.</param>
		/// <returns>True if the date is in the future, otherwise false.</returns>
		public override bool IsValid(object value)
		{
			var dateTime = Convert.ToDateTime(value);

			return dateTime > DateTime.Now;
		}

		#endregion
	}
}
