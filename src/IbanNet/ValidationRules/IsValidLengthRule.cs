﻿using System.Collections.Generic;

namespace IbanNet.ValidationRules
{
	/// <summary>
	/// Asserts that the IBAN has the correct length as defined for its country.
	/// </summary>
	internal class IsValidLengthRule : CountrySpecificRule
	{
		public IsValidLengthRule(IReadOnlyDictionary<string, IbanRegionDefinition> definitions) : base(definitions)
		{
		}

		/// <summary>
		/// The validation result to use when this rule is not valid.
		/// </summary>
		public override IbanValidationResult InvalidResult { get; } = IbanValidationResult.InvalidLength;

		/// <summary>
		/// Validates the IBAN according to the country specific definition.
		/// </summary>
		/// <param name="iban">The IBAN to validate.</param>
		/// <param name="definition">The country specific definition.</param>
		/// <returns>true if the IBAN is valid, or false otherwise</returns>
		protected override bool Validate(string iban, IbanRegionDefinition definition)
		{
			return iban.Length == definition.Length;
		}
	}
}
