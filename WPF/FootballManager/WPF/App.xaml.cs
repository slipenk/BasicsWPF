using AutoMapper;
using Ninject;
using System;
using System.Windows;
using System.Windows.Media;
using WPF.Mapping;
using WPF.Model;
using WPF.ViewModels;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel model;
        private DataViewModel view_model;
        private IMapper mapper;
        public App()
        {
            model = DataModel.Load();
            var k = new StandardKernel(new MappingModule());
            mapper = k.Get<IMapper>();
            view_model = mapper.Map<DataModel, DataViewModel>(model);
            var window = new MainWindow() { DataContext = view_model };
            window.Background = new SolidColorBrush(Color.FromRgb(255,204,204));
            window.Show();
            
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                model = mapper.Map<DataViewModel, DataModel>(view_model);
                model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
