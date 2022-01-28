using System.Xml;



namespace XmlHandling
{
    public class XmlHelper
    {
        private string _fileName;
        public XmlHelper(string fileName = "file.xml")
        {
            _fileName = fileName;
        }
        public void CreateXmlDocument(string? path = null)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = "/Files/";
            }

            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(declaration);

            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);

            doc.Save(path + _fileName);
        }

        public XmlDocument GetXmlDocument(string pathTofile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pathTofile);

            return doc;

        } 

        public void AppendDataNode(XmlDocument doc)
        {

        }

        public string FileName
        {
           get { return _fileName; }
            set { _fileName = value; }
        }



    }
}