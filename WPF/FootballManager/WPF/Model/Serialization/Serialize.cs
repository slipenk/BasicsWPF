using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Serialization
{
    public class Serialize
    {
        public static void SerializeData(string file, DataModel data)
        {
            var formatter = new BinaryFormatter();
            var create = new FileStream(file, FileMode.Create);
            formatter.Serialize(create, data);
            create.Close();
        }

        public static DataModel DeserializeData(string file)
        {
            var temp = new FileStream(file, FileMode.Open);
            var formatter = new BinaryFormatter();
            return (DataModel)formatter.Deserialize(temp);
        }
    }
}
