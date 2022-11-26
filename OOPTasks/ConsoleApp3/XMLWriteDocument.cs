using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class XMLWriteDocument
    {
        private XmlWriter writer;
        private XmlWriterSettings settings = new XmlWriterSettings();
        private string _fileName;
        private XDocument _document;

        public XMLWriteDocument(string fileName)
        {
            _fileName = fileName;
        }
        

        public void Write(string? content)
        {
            settings.Indent = true;
            settings.IndentChars = "\t";
            
            if (!File.Exists(_fileName))
            {
                using (writer = XmlWriter.Create(_fileName, settings))
                {
                    _document = new XDocument(new XElement("content", content));
                    _document.WriteTo(writer);
                }
            }
            else
            {
                _document = XDocument.Load(_fileName);
                XElement? root = _document.Element("content");
                
                root?.Add(new XElement("content", content));
                _document.Save(_fileName);
            }

            

        }
        
    }
}