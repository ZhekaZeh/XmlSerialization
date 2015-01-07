using System;

namespace XmlSerialization
{
    internal class Program
    {
        private static void Main()
        {
            var core = new Core();
            core.SerializeToXml();
            Console.WriteLine(@"Change c:\users.xml and press Enter");
            Console.ReadLine();
            core.DeserializeXmlToObject();
            core.ShowUsersInfo();
            Console.WriteLine(@"Press enter to exit");
            Console.ReadLine();
        }
    }
}

//Eugene comment 1