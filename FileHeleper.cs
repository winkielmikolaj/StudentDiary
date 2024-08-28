using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentDiary
{
    public class FileHeleper<T> where T : new()
    {
        private string _filePath;

        public FileHeleper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T students)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }

        public T DeserializerFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new T();
            }

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return students;
            }
        }
    }


}
