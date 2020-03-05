using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ApiClient.Utilities.Interfaces;

namespace ApiClient.Utilities
{
	public class Validatable : IValidatable
	{
		#region [Public Methods]

		/// <summary>
		/// Validates the object properties based on the data annotations on each property.
		/// </summary>
		/// <returns>
		/// True if the properties are valid, otherwise false.
		/// </returns>
		public bool IsValid()
		{
			var validationContext = new ValidationContext(this);
			var validationResults = new List<ValidationResult>();

			Validator.TryValidateObject(this, validationContext, validationResults, true);

			if (validationResults.Any())
			{
				return false;
			}

			return true;
		}

		#endregion
	}
}
