using System;

namespace CleanCodeProject4
{
    class Program
    {
        static void Main(string[] args)
        {
            XML xml = new XML();
            xml.CreateXmlFile();
            xml.ReadFile();
        }
    }
}