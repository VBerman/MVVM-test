using MVVM_test.Classes;
using MVVM_test.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_test.MVVM
{
    public class ApplicationViewModel:INotifyPropertyChanged
    {

        private ObservableCollection<Phone> phone;

        public ObservableCollection<Phone> Phones
        {
            get => phone; 
            set 
            { 
                phone = value;
                OnPropertyChanged("Phones");
            }
        }

       
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
        public ObservableCollection<Asset> Assets { get; set; }

        private RelayCommand saveChanges;

        

        public RelayCommand SaveChanges
        {
            get { return saveChanges ?? new RelayCommand(async obj => 
            {
                
                await DB.Instance.SaveChangesAsync();
            }); }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
