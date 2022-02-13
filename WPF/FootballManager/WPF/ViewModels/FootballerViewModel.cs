using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model;

namespace WPF.ViewModels
{
    class FootballerViewModel : ViewModelBase
    {
            private string _Name;

            public string Name
            {
                get
                {
                    return _Name;
                }
                set
                {
                    _Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }

            private string _Surname;

            public string Surname
            {
                get
                {
                    return _Surname;
                }
                set
                {
                    _Surname = value;
                    OnPropertyChanged(nameof(Surname));
                }
            }

            private Club _Club;

            public Club Club
            {
                get
                {
                    return _Club;
                }
                set
                {
                    _Club = value;
                    OnPropertyChanged(nameof(Club));
                }
            }

            private int _Number;

            public int Number
            {
                get
                {
                    return _Number;
                }
                set
                {
                    _Number = value;
                    OnPropertyChanged(nameof(Number));
                }
            }

            private string _Country;

            public string Country
            {
                 get
                 {
                    return _Country;
                 }
                 set
                 {
                    _Country = value;
                    OnPropertyChanged(nameof(Country));
                 }
            }

            private double _Value;

            public double Value
            {
                get
                {
                    return _Value;
                }
                set
                {
                    _Value = value;
                    OnPropertyChanged(nameof(Value));
                }
            }

           

           
        
    }
}
