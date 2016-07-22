using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float Result = 0;
        private string btnContent = String.Empty;

        private string displayValue;
        DataTable dt = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string value = (sender as Button).Content.ToString();

            switch (value)
            {
                case "0":
                    displayValue += "0";
                    lblDisplay.Content += "0";
                    break;
                case "1":
                    displayValue += "1";
                    lblDisplay.Content += "1";
                    break;
                case "2":
                    displayValue += "2";
                    lblDisplay.Content += "2";
                    break;
                case "3":
                    displayValue += "3";
                    lblDisplay.Content += "3";
                    break;
                case "4":
                    displayValue += "4";
                    lblDisplay.Content += "4";
                    break;
                case "5":
                    displayValue += "5";
                    lblDisplay.Content += "5";
                    break;
                case "6":
                    displayValue += "6";
                    lblDisplay.Content += "6";
                    break;
                case "7":
                    displayValue += "7";
                    lblDisplay.Content += "7";
                    break;
                case "8":
                    displayValue += "8";
                    lblDisplay.Content += "8";
                    break;
                case "9":
                    displayValue += "9";
                    lblDisplay.Content += "9";
                    break;
                case "+":
                    displayValue += "+";
                    lblDisplay.Content += "+";
                    break;
                case "-":
                    displayValue += "-";
                    lblDisplay.Content += "-";
                    break;
                case "*":
                    displayValue += "*";
                    lblDisplay.Content += "*";
                    break;
                case "/":
                    displayValue += "/";
                    lblDisplay.Content += "/";
                    break;
                case ")":
                    displayValue += ")";
                    lblDisplay.Content += ")";
                    break;
                case "(":
                    displayValue += "(";
                    lblDisplay.Content += "(";
                    break;
                case "C":
                    displayValue = "";
                    lblDisplay.Content = "";
                    break;
                case ".":
                    displayValue += ".";
                    lblDisplay.Content += ".";
                    break;
                case "=":
                    var v = dt.Compute(displayValue, "");
                    lblDisplay.Content = v.ToString();
                    break;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.NumPad0:
                    displayValue += "0";
                    lblDisplay.Content += "0";
                    break;
                case Key.NumPad1:
                    displayValue += "1";
                    lblDisplay.Content += "1";
                    break;
                case Key.NumPad2:
                    displayValue += "2";
                    lblDisplay.Content += "2";
                    break;
                case Key.NumPad3:
                    displayValue += "3";
                    lblDisplay.Content += "3";
                    break;
                case Key.NumPad4:
                    displayValue += "4";
                    lblDisplay.Content += "4";
                    break;
                case Key.NumPad5:
                    displayValue += "5";
                    lblDisplay.Content += "5";
                    break;
                case Key.NumPad6:
                    displayValue += "6";
                    lblDisplay.Content += "6";
                    break;
                case Key.NumPad7:
                    displayValue += "7";
                    lblDisplay.Content += "7";
                    break;
                case Key.NumPad8:
                    displayValue += "8";
                    lblDisplay.Content += "8";
                    break;
                case Key.NumPad9:
                    displayValue += "9";
                    lblDisplay.Content += "9";
                    break;
                case Key.Add:
                    displayValue += "+";
                    lblDisplay.Content += "+";
                    break;
                case Key.Subtract:
                    displayValue += "-";
                    lblDisplay.Content += "-";
                    break;
                case Key.Multiply:
                    displayValue += "*";
                    lblDisplay.Content += "*";
                    break;
                case Key.Divide:
                    displayValue += "/";
                    lblDisplay.Content += "/";
                    break;
                case Key.OemCloseBrackets:
                    displayValue += ")";
                    lblDisplay.Content += ")";
                    break;
                case Key.OemOpenBrackets:
                    displayValue += "(";
                    lblDisplay.Content += "(";
                    break;
                case Key.Enter:
                    var v = dt.Compute(displayValue, "");
                    lblDisplay.Content = v.ToString();
                    break;
            }
        }
    }
}
