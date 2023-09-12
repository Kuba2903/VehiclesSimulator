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
        /// <summary>
        /// Serializes (saves) the object to the file in xml format
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="fileName">enter the file name</param>
        /// <param name="obj">object that needs to be serialized</param>
        public static void SerializeToFile<T>(string fileName, T obj)
        {
            using var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            serializer.WriteObject(stream, obj);
        }

        /// <summary>
        /// Deserializes (reads) the object from the file
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="fileName">file name of the serialized object</param>
        /// <returns>returns the new object</returns>
        public static T DeserializeFromFile<T>(string fileName)
        {
            using var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            return (T)serializer.ReadObject(stream);
        }
    }
}
