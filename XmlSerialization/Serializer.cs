using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerialization
{
    internal class Serializer<T>
    {

        /// <summary>
        /// Serializes object to Xml.
        /// </summary>
        /// <param name="inputObject">Object to serializer</param>
        public void Serialize(T inputObject)
        {
            try
            {
                var formatter = new XmlSerializer(typeof(T));
                using (var fileStream = new FileStream(@"C:\users.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fileStream, inputObject);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(@"Can't create XmlSerializer for this type [{0}]", typeof(T).Name);
            }   
            Console.WriteLine(@"Serialization comlete for {0} type", typeof(T).Name);
        }
    }
}