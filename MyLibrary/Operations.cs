using System.Collections;

namespace MyLibrary
{
	public class Operations
	{
		public int Add(int number1, int number2)
		{
			return number1 + number2;
		}

		public bool IsEven(int number)
		{
			return number % 2 == 0;
		}

		public bool IsOdd(int number)
		{
			return number % 2 != 0;
		}


		public double AddDecimal(double number1, double number2)
		{
			return number1 + number2;
		}

		// ArrayList = List
		public IList<int> GetEvenNumbers(int start, int end)
		{
			return Enumerable.Range(start, end)
				.Where(IsEven)
				.ToList();
		}
	}
}
