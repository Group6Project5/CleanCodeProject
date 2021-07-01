using System;
using System.Threading;

namespace CleanCodeProject4
{
    class Program
    {
        static void Main(string[] args)
        {
            XML xml = new XML();

            Thread WriteThread = new Thread(xml.CreateXmlFile);
            Thread ReadThread = new Thread(xml.ReadFile);

            WriteThread.Start();
            WriteThread.Join();

            ReadThread.Start();
            ReadThread.Join();
        }
    }
}