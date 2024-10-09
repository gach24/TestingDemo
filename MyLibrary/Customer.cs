namespace MyLibrary
{
	public class Customer
	{

		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string FullName => $"{FirstName} {LastName}";
    }
}
