using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using WPF.Model;

namespace WPF.ViewModels
{
    class DataViewModel : ViewModelBase
    {
        

            private string _Visible_control = "Clubs";

            public string VisibleControl
            {
                 get
                 {
                     return _Visible_control;
                 }
                 set
                 {
                     _Visible_control = value;
                     OnPropertyChanged(nameof(VisibleControl));
                 }
            }

        public  ICommand SetControlVisibility { get; set; }

       
        DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            SetMusic = new Command(Music);
        } 

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        public ICommand SetMusic { get; set; }

        private MediaPlayer player = new MediaPlayer();
        int count = 0;
        private void Music(object parameter)
        {

            ++count;
            if (count == 1)
            {
                string executableFilePath = Assembly.GetExecutingAssembly().Location;
                string executableDirectoryPath = Path.GetDirectoryName(executableFilePath);
                string audioFilePath = Path.Combine(executableDirectoryPath, @"Music\You'll Never Walk Alone.mp3");
                Uri audioFileUri = new Uri(audioFilePath);
                player.Open(audioFileUri);
                player.MediaFailed += (o, args) => { MessageBox.Show("Помилка"); };
                player.Volume = 1;
                player.Play();
            } else if (count > 1 && count % 2 == 0)
            {
                player.Pause();
            } else
            {
                player.Play();

            }

            
        }

       
        private ObservableCollection<FootballerViewModel> _Footballers;

            public ObservableCollection<FootballerViewModel> Footballers
            {
                get
                {
                    return _Footballers;
                }
                set
                {
                    _Footballers = value;
                    OnPropertyChanged(nameof(Footballers));
                }
            }

            private ObservableCollection<ClubViewModel> _Clubs;

            public ObservableCollection<ClubViewModel> Clubs
            {
                get
                {
                    return _Clubs;
                }
                set
                {
                    _Clubs = value;
                    OnPropertyChanged(nameof(Clubs));
                }
            }
        
    }
}
