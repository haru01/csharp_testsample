using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

[TestFixture()]
public class FizzBuzzTest
{
	[Test()]
	public void FizzBuzz ()
	{
		var results = new Fizzbuzz ().Take (16);
		Assert.That (results, Is.EqualTo (new []{ "1", "2", "Fizz", "4", "Buzz",
																						"Fizz", "7", "8", "Fizz", "Buzz",
																						"11", "Fizz", "13", "14", "FizzBuzz", "16" }));
	}
}
