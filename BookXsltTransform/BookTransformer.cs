using System.Text;
using System.Xml;
using System.Xml.Xsl;


namespace BookXsltTransform
{
	class BookTransformer
	{
		public void Transform(bool enableScripting, string xmlPath, string xsltPath, string outputPath)
		{
			StringBuilder builder = new StringBuilder();
			XslCompiledTransform transformer = new XslCompiledTransform();
			transformer.Load(xsltPath, new XsltSettings(false, enableScripting), null);
			transformer.Transform(xmlPath, outputPath);
		}
	}
}
