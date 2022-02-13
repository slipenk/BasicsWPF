using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModels
{
    public class ClubViewModel : ViewModelBase
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

            private string _City;

            public string City
            {
                get
                {
                    return _City;
                }
                set
                {
                    _City = value;
                    OnPropertyChanged(nameof(City));
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
