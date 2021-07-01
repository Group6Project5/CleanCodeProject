using System;
using System.Xml;

namespace CleanCodeProject4
{
    public class XML
    {
        public void CreateXmlFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Team");
            xmldoc.AppendChild(root);

            XmlElement element1 = xmldoc.CreateElement("Members");
            root.AppendChild(element1);

            XmlElement element2 = xmldoc.CreateElement("Member");
            XmlText text2 = xmldoc.CreateTextNode("Batool Alghamdi , Computer Science");
            element1.AppendChild(element2);
            element2.AppendChild(text2);

            XmlElement element3 = xmldoc.CreateElement("Member");
            XmlText text3 = xmldoc.CreateTextNode("Rawabi Alshaduki , Software Engineer");
            element1.AppendChild(element3);
            element3.AppendChild(text3);

            XmlElement element4 = xmldoc.CreateElement("Member");
            XmlText text4 = xmldoc.CreateTextNode("Ahmed Almutairi, Computer science ");
            element1.AppendChild(element4);
            element4.AppendChild(text4);

            XmlElement element5 = xmldoc.CreateElement("Member");
            XmlText text5 = xmldoc.CreateTextNode("Thamer Mashni, Computer science ");
            element1.AppendChild(element5);
            element5.AppendChild(text5);

            XmlElement element6 = xmldoc.CreateElement("Member");
            XmlText text6 = xmldoc.CreateTextNode("Hassam Algudah, Software Engineer ");
            element1.AppendChild(element6);
            element6.AppendChild(text6);

            xmldoc.Save(@"/Users/rawabeebrahim/Desktop/Team.xml");
            Console.WriteLine(xmldoc.InnerXml);
        }
        public void ReadFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"/Users/rawabeebrahim/Desktop/Team.xml");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.WriteLine(element + ": ");
                string text = node.InnerText;
                Console.WriteLine(text);
            }
        }
    }
}