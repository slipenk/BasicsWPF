using System;
using System.Collections.Generic;
using System.IO;
using WPF.Model.Serialization;


namespace WPF.Model
{
    [Serializable]
    public class DataModel
    {
        public IEnumerable<Footballer> Footballers { get; set; }
        public IEnumerable<Club> Clubs { get; set; }

        public DataModel()
        {
            Footballers = new List<Footballer>();
            Clubs = new List<Club>();
        }

        public static string path = @"D:\Юра\C#\Lab_5\Ser\SerializeData.dat";

        public void Save()
        {
            Serialize.SerializeData(path, this);
        }

        public static DataModel Load()
        {
            if (File.Exists(path))
                return Serialize.DeserializeData(path);
            return new DataModel();
        }
    }
}
