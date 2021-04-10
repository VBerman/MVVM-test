using MVVM_test.Classes;
using MVVM_test.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM_test
{
    /// <summary>
    /// Interaction logic for TestInstanceVIewModel.xaml
    /// </summary>
    public partial class TestInstanceVIewModel : Window
    {
        //internal ApplicationViewModel Instance {get;set;}= ViewModel.Instance;
        internal ApplicationViewModel Instance { get; set; }

        public TestInstanceVIewModel()
        {

            InitializeComponent();
            
        }
    }
}
