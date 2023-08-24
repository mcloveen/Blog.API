namespace BlogApp.Business.Exceptions.Common
{
	public class NegativeIdException : Exception
	{
		public NegativeIdException():base("Id not be negative.")
		{
		}

		public NegativeIdException(string? message) : base(message)
		{
		}
	}
}
