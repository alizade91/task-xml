namespace ExchangeFileVerifier
{
	class Program
	{
		static void Main(string[] args)
		{
			BookValidator bookValidator = new BookValidator();
			bool validBook = bookValidator.Validate("books.xml", "BookSchema.xsd");
			System.Console.WriteLine(validBook);

			bool inValidBook = bookValidator.Validate("invalid-books.xml", "BookSchema.xsd");
			System.Console.WriteLine(inValidBook);
		}
	}
}
