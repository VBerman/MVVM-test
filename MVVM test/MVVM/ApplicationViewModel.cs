using MVVM_test.Classes;
using MVVM_test.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_test.MVVM
{
    class ApplicationViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Phone> Phones { get; set; }
        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Phone>()
            {
                new Phone(){Title="Check0"},
                new Phone(){Title="Check1"},
                new Phone(){Title="Check2"},
                new Phone(){Title="Check3"}
            };

            Assets = new ObservableCollection<Asset>(DB.Instance.Assets.ToList());

        }
        private ObservableCollection<Asset> assets;




            public ObservableCollection<Asset> Assets {
            get => assets;
            set
            {
                assets = value; 
                
            }
                
            
        }
        private RelayCommand saveChanges;

        private int myVar;



        public event PropertyChangedEventHandler PropertyChanged;



        public RelayCommand SaveChanges
        {
            get
            {
                return saveChanges ?? (saveChanges = new RelayCommand(async obj =>
                {
                    Assets.ToList()[0].AssetName = "asd";
                    //await DB.Instance.SaveChangesAsync();
                    
                }));
            }

        }
        

    }
}
