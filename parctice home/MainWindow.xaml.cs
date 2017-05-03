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

namespace parctice_home
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  //binding the viewmodel class
        //Binding to the result window
        VM vm;
        Result result;
        public MainWindow()
        {
            vm = new parctice_home.VM();
            InitializeComponent();
            DataContext = vm;
            vm.Getlist();
           
        }

        private void Personname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   //displays details in the resultwindow when name selected from main window
            vm.Selector(Personname.SelectedIndex);
            result = new parctice_home.Result();
            result.DataContext = vm;
            result.ShowDialog();


        }
    }
}
