﻿using MVVM_test.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ApplicationViewModel Instance { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = ViewModel.Instance;
           
        }

        private void DataGrid_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}
