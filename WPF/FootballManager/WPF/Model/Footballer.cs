using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
    [Serializable]
    public class Footballer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Club Club { get; set; }
        public int Number { get; set; }
        public string Country { get; set; }
        public double Value { get; set; }

        public Footballer(string Name, string Surname, Club Club, int Number, string Country, double Value)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Club = Club;
            this.Number = Number;
            this.Country = Country;
            this.Value = Value;
        }

       
    }
}
