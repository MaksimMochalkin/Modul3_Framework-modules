using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace StudentsLINQ
{
    public class StudentStorage
    {
        
        public List<StudensInformation> Load(string path)
        {
            var binary = new BinaryFormatter();
            List<StudensInformation> studensInformation = new List<StudensInformation>();
            using (var file = new FileStream(path, FileMode.OpenOrCreate))
            {
                studensInformation = (List<StudensInformation>)binary.Deserialize(file);
            }

            return studensInformation;
        }

        public void Save(List<StudensInformation> studensInformation, string path)
        {
            var binary = new BinaryFormatter();

            using (var file = new FileStream(path, FileMode.OpenOrCreate))
                binary.Serialize(file, studensInformation);
        }
    }
}
