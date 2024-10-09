using NUnit.Framework;

namespace MyLibrary
{
	[TestFixture]
	public class OperationsNUnitTest
	{
		[Test]
		public void Add_InputNumbers_ReturnNumber()
		{
			// 1. Arrange
			// Operations operations = new Operations();
			// Operations operations = new();
			var operations = new Operations();
			int number1 = 2;
			int number2 = 5;

			// 2. Act
			int result = operations.Add(number1, number2);

			// 3. Assert
			Assert.That(result, Is.EqualTo(7));
			Assert.That(result, Is.Not.EqualTo(8));
			Assert.That(result, Is.Not.EqualTo(6));
		}

		[Test]
		[TestCase(10)]
		[TestCase(12)]
		[TestCase(14)]
		public void IsEven_InputNumber_ReturnTrue(int number)
		{
			// 1. Arrange
			Operations operations = new Operations();
			// int number = 10;

			var result = operations.IsEven(number);

			Assert.That(result, Is.True);
		}


		[Test]
		[TestCase(2.2, 1.2)]
		[TestCase(2.23, 1.24)]
		public void AddDecimal_InputDoubleNumbers_ReturnsDoubleNumber(double number1, double number2)
		{
			// 1. Arrange
			Operations operations = new();

			// 2. Act
			double result = operations.AddDecimal(number1, number2);

			Assert.That(result, Is.EqualTo(3.4).Within(0.1));
		}

		[Test]
		public void GetEvenNumbers_InputRange_ReturnEvenNumbers()
		{
			// 1. Arrange
			Operations operations = new();
			int start = 0;
			int end = 10;

			// 2. Act
			var result = operations.GetEvenNumbers(start, end);

			// 3. Assert
			Assert.That(result, Is.Not.Empty);
			Assert.That(result, Is.TypeOf<List<int>>());
			Assert.That(result[0], Is.TypeOf<int>());
			Assert.That(result.Count, Is.EqualTo(5));
			Assert.That(result, Has.Exactly(5).Items);
			Assert.That(result, Is.Ordered);
			Assert.That(result, Has.No.Member(-1));
			Assert.That(result, Does.Contain(0));
			Assert.That(result, Has.Member(6));
			Assert.That(result, Has.Member(8));
			Assert.That(result, Has.No.Member(11));
			Assert.That(result, Has.All.InRange(0, 8));
			Assert.That(result, Has.All.GreaterThanOrEqualTo(0));
			Assert.That(result, Has.All.LessThanOrEqualTo(10));
			Assert.That(result, Is.EquivalentTo(new[] { 0, 2, 4, 6, 8 }));
			Assert.That(result, Is.Unique);

		}

		[Test]
		[TestCase(1, 20)]
		[TestCase(100, 1000)]
		public void GetEvenNumbers_SeveralInputRange_ReturnEvenNumbers(int start, int end)
		{
			// 1. Arrange
			Operations operations = new();
			int startNumber = start % 2 == 0 ? start : start + 1;
			int endNumber = end % 2 == 0 ? end : end - 1;

			int middleNumber = (startNumber + endNumber) / 2;
			middleNumber = middleNumber % 2 == 0 ? middleNumber : middleNumber + 1;


			// 2. Act
			var result = operations.GetEvenNumbers(start, end);

			// 3. Assert
			Assert.That(end - start >= 2, Is.True);
			Assert.That(result, Is.Not.Empty);
			Assert.That(result, Is.TypeOf<List<int>>());
			Assert.That(result[0], Is.TypeOf<int>());
			Assert.That(result, Is.Ordered);

			Assert.That(result, Has.No.All.LessThan(startNumber));
			Assert.That(result, Has.Member(startNumber));
			Assert.That(result, Has.Member(middleNumber));
			Assert.That(result, Has.Member(endNumber));
			Assert.That(result, Has.No.All.GreaterThan(endNumber));
			// Assert.That(result, Has.All.InRange(startNumber, endNumber));
			Assert.That(result, Is.Unique);

		}
	}
}
