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

namespace MortgageCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalcManager cManager = new CalcManager();
        //string[] 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void outputMortgage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MortgageEnterInput(object sender, TextChangedEventArgs e)
        {

            cManager.firstEmpty = false;
        }

        private void Button_Equals(object sender, RoutedEventArgs e)
        {
            cManager.allOutputMortgageValues.Insert(0, cManager.allInputValues[1]);
        }
    }
}
