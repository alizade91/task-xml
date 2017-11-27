using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookXsltTransform
{
	class Program
	{
		static void Main(string[] args)
		{
			BookTransformer transformer = new BookTransformer();
			//generate RSS
			transformer.Transform(false, "books.xml", "RSS.xslt", "output.xml");

			//generate HTML
			transformer.Transform(true, "books.xml", "HTML.xslt", "output.html");
		}
	}
}
