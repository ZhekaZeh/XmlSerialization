using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerialization
{
    class Deserializer<T>
    {

        /// <summary>
        /// Deserializes an xml file to object.
        /// </summary>
        /// <returns>return deserialized object</returns>
        public T Deserialize()
        {
            try
            {
                var formatter = new XmlSerializer(typeof(T));
                using (var fileStream = new FileStream(@"C:\users.xml", FileMode.OpenOrCreate))
                {
                    return (T)formatter.Deserialize(fileStream);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(@"Deserialization didn't complete[{0}]", typeof(T).Name);
                return default(T);
            }     
        }
    }
}
