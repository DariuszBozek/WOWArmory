using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using System.Windows;

namespace WOWArmory
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()//nadpisanie
        {
            return Container.Resolve<VIEWS.MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();//pokaż nową powłokę 
        }
    }
}
