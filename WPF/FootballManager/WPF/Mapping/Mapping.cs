using AutoMapper;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model;
using WPF.ViewModels;

namespace WPF.Mapping
{
    class Mapping
    {
        public MapperConfiguration config { get; set; }
        public Mapping()
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Footballer, FootballerViewModel>();
                cfg.CreateMap<FootballerViewModel, Footballer>();
               
                cfg.CreateMap<Club, ClubViewModel>();
                cfg.CreateMap<ClubViewModel, Club>();
            });
        }
    }

    public class MappingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToMethod(context => new Mapping().config.CreateMapper());
        }
    }
}

