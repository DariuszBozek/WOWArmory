using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Regions;
using WOWArmory.MODELS;

namespace WOWArmory.VIEWMODELS
{
    public class ViewList : BindableBase
    {
        public ObservableCollection<ModelCharacter> CharactersList { get; set; } //Reprezentuje kolekcję danych dynamicznych, który zapewnia wysyłanie powiadomień, gdy elementy uzyskać dodane, usunięte, lub po odświeżeniu całą listę


        public ViewList(IRegionManager regionManager, IUnityContainer container)
        {


            ModelCharacter postac1 = new Alliance()
            {
                Nick = "Postac1",
                Race = "Humman",
                Class = "Paladin",
            };

            ModelCharacter postac2 = new Alliance()
            {
                Nick = "Postac2",
                Race = "Elf",
                Class = "Druid",
            };

            ModelCharacter postac3 = new Alliance()
            {
                Nick = "Postac3",
                Race = "Dwarf",
                Class = "Hunter",
            };

            ModelCharacter postac4 = new Horde()
            {
                Nick = "Postac4",
                Race = "Orc",
                Class = "Warrior",
            };

            ModelCharacter postac5 = new Horde()
            {
                Nick = "Postac5",
                Race = "Undead",
                Class = "Warlock",
            };

            ModelCharacter postac6 = new Horde()
            {
                Nick = "Postac6",
                Race = "Tauren",
                Class = "Shaman",
            };

            CharactersList = new ObservableCollection<ModelCharacter>();

            CharactersList.Add(postac1);
            CharactersList.Add(postac2);
            CharactersList.Add(postac3);
            CharactersList.Add(postac4);
            CharactersList.Add(postac5);
            CharactersList.Add(postac6);
        }

       

    }

}