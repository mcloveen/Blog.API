namespace BlogApp.Business.Exceptions.Common
{
	public class EmptyPathException : Exception
	{
		public EmptyPathException():base("Path not be empty or white space.")
		{
		}

		public EmptyPathException(string? message) : base(message)
		{
		}
	}
}
