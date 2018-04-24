using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Mvvm;
using Prism.Regions;

using WOWArmory.VIEWS;

namespace WOWArmory.MODELS
{
    public abstract class ModelCharacter : BindableBase // abstract - klasa jest przeznaczona tylko jako klasę podstawową innych klas - nie posiada ciała
    {
        protected ModelCharacter(string nick) //
        {
            Nick = nick;
        }

        public string Nick { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }


        protected Type viewType;//zmiena typu Type chroniona w klasie pochodnej : Alliance/Horde

        public void Show(IRegion detailsRegion)//metoda nie zwraca wartosci
        {
            var view = (UserControl)detailsRegion.Views.FirstOrDefault(x => x.GetType() == viewType);//var(typ ustalamy wg przypisanej zmiennej)
            detailsRegion.Activate(view);
            view.DataContext = this;
        }
    }

    public class Alliance : ModelCharacter
    {

        public Alliance()
            : base(null)//Umożliwia dostęp do elementów członkowskich klasy podstawowej z w klasie pochodnej
        {
            viewType = typeof(ViewA);
        }


    }
    public class Horde : ModelCharacter
    {

        public Horde()
            : base(null)
        {
            viewType = typeof(ViewB);
        }
    }

}
