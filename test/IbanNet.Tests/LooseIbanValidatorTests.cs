﻿using NUnit.Framework;

namespace IbanNet
{
	[TestFixture]
	internal class LooseIbanValidatorTests : IbanValidatorIntegrationTests
	{
		public LooseIbanValidatorTests()
			: base(new IbanValidator(new IbanValidatorOptions { ValidationMethod = ValidationMethod.Loose }))
		{
		}
	}
}
