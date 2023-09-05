using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    public static class XMLSerialization
    {
        public static void SerializeToFile<T>(string fileName, T obj)
        {
            using var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            serializer.WriteObject(stream, obj);
        }

        public static T DeserializeFromFile<T>(string fileName)
        {
            using var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            return (T)serializer.ReadObject(stream);
        }
    }
}
