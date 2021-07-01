using System;
using System.Xml;

namespace CleanCodeProject
{
    public class XML
    {
        static void CreateXmlFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("email");
            xmldoc.AppendChild(root);
            XmlElement element1 = xmldoc.CreateElement("from");
            XmlText text1 = xmldoc.CreateTextNode("Toto");
            root.AppendChild(element1);
            element1.AppendChild(text1);
            XmlElement element2 = xmldoc.CreateElement("to");
            XmlText text2 = xmldoc.CreateTextNode("roro");
            root.AppendChild(element2);
            element2.AppendChild(text2);
            XmlElement element3 = xmldoc.CreateElement("Content");
            root.AppendChild(element3);
            XmlElement element4 = xmldoc.CreateElement("intro");
            XmlText text4 = xmldoc.CreateTextNode("intro ");
            element3.AppendChild(element4);
            element4.AppendChild(text4);
            XmlElement element5 = xmldoc.CreateElement("body");
            XmlText text5 = xmldoc.CreateTextNode("body ");
            element3.AppendChild(element5);
            element5.AppendChild(text5);
            XmlElement element6 = xmldoc.CreateElement("conc");
            XmlText text6 = xmldoc.CreateTextNode("conc ");
            element3.AppendChild(element6);
            element6.AppendChild(text6);
            xmldoc.Save(@"/Users/batoolalghamdi/Desktop/email.xml");
            Console.WriteLine(xmldoc.InnerXml);
        }
        static void ReadFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"/Users/batoolalghamdi/Desktop/email.xml");
            foreach(XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.WriteLine(element + ": ");
                string text = node.InnerText;
                Console.WriteLine(text);
            }
        }
    }
}