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
	}
}
