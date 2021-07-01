using System;
using System.Xml;

namespace CleanCodeProject4
{
    public class XML
    {
        private XmlElement MembersElement;
        private XmlDocument xmldoc;
        public void CreateXmlFile()
        {
            xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Team");
            xmldoc.AppendChild(root);
            MembersElement = xmldoc.CreateElement("Members");
            root.AppendChild(MembersElement);
            AddMember("Hassan Algadah , Software Engineering");
            AddMember("Rawabi Alshaduki , Software Engineering");
            AddMember("Batool Alghamdi , Computer Science");
            AddMember("Ahmed Almutairi , Computer Science");
            AddMember("Thamer Mashni , Computer Science");
            xmldoc.Save(@"../../../Team.xml");
            Console.WriteLine(xmldoc.InnerXml);
        }
        public void AddMember(string memberinfo)
        {
            XmlElement memberElement = xmldoc.CreateElement("Member");
            XmlText memberNode = xmldoc.CreateTextNode(memberinfo);
            MembersElement.AppendChild(memberElement);
            memberElement.AppendChild(memberNode);
        }
        public void ReadFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"../../../Team.xml");
            var membersTag = xmldoc.DocumentElement.ChildNodes[0]; 
            
            foreach (XmlNode node in membersTag)
            {
                string element = node.Name;
                string text = node.InnerText;
                Console.WriteLine(element + ": "+text);
            }
        }
    }
}