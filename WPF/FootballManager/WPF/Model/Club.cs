using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
    [Serializable]
    public class Club
    {
        public string Name { get; set; }
        public string City { get; set; }
        public double Value { get; set; }

        public Club (string Name, string City, double Value)
        {
            this.Name = Name;
            this.City = City;
            this.Value = Value;

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
