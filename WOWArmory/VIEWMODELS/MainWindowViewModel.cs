using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using Prism.Commands;
using WOWArmory.VIEWS;
using System.Collections.ObjectModel;
using WOWArmory.MODELS;
using System.ComponentModel;
using Prism.Events;
using System.Windows.Controls;


namespace WOWArmory.VIEWMODELS
{
    public class MainWindowViewModel : ViewList
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;


        public MainWindowViewModel(IRegionManager regionManager, IUnityContainer container)
            : base(regionManager, container)//Umożliwia dostęp do elementów członkowskich klasy podstawowej z w klasie pochodnej
        {

            _regionManager = regionManager;
            _container = container;

            //_container.RegisterType<ILoginViewModel, ViewList>();
            IRegion detailsRegion = _regionManager.Regions["DetailsRegion"];
            if (detailsRegion != null)
            {
                //detailsRegion.Add(new ViewA());
                detailsRegion.Add(_container.Resolve<ViewA>());
                detailsRegion.Add(_container.Resolve<ViewB>());
            }
            
    }

        ModelCharacter WyborPostaci;// przeniesc do viewlist
        public ModelCharacter SelectedModelCharacter
        {
            get
            {
                return WyborPostaci;
            }
            set
            {
                IRegion detailsRegion = _regionManager.Regions["DetailsRegion"];
                value.Show(detailsRegion);

                WyborPostaci = value;
                RaisePropertyChanged(nameof(SelectedModelCharacter));//powiadom klientów o zmianie właściwości
            }
        }


    }
}
