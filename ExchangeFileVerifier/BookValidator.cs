using System;
using System.Xml;
using System.Xml.Schema;


namespace ExchangeFileVerifier
{
	class BookValidator
	{
		public bool Validate(string xmlFileName, string xsdFileName)
		{
			bool isValid = true;
			XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();		
			xmlReaderSettings.Schemas.Add("http://library.by/catalog", xsdFileName);
			
			xmlReaderSettings.ValidationEventHandler += (object sender, ValidationEventArgs e) => isValid = false;

			xmlReaderSettings.ValidationFlags = xmlReaderSettings.ValidationFlags | XmlSchemaValidationFlags.ReportValidationWarnings;
			xmlReaderSettings.ValidationType = ValidationType.Schema;
			XmlReader reader = XmlReader.Create(xmlFileName, xmlReaderSettings);
			while (reader.Read()){}

			return isValid;
		}
	}
}
