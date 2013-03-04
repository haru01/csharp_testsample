using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Fizzbuzz : IEnumerable<String> {

	public IEnumerator<String> GetEnumerator()
	{
		int from = 1;
		while (true) {
			yield return convert(from);
			from += 1;
		}
	}

	private String convert(int num) {
		if (num % 15 == 0)
		{
			return "FizzBuzz";
		}
		else if (num % 3 == 0)
		{
			return "Fizz";
		}
		else if (num % 5 == 0)
		{
			return "Buzz";
		} else {
			return num.ToString();
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

}

class MainClass {
	public static void Main ()
	{
	}
}
