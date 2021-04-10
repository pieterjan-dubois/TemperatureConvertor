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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var fString = fahrenheitTextBox.Text;
            var fDouble = Double.Parse(fString);
            var celsius = (fDouble - 32) / 1.8;
            var celsiusString = celsius.ToString();
            celsiusTextBox.Text = celsiusString;
        }

        private void ConvertToFarenheit(object sender, RoutedEventArgs e)
        {
            var cString = celsiusTextBox.Text;
            var cDouble = Double.Parse(cString);
            var farenheit = (cDouble * 1.8) + 32;
            var FarenheitString = farenheit.ToString();
            celsiusTextBox.Text = FarenheitString;
        }
    }
}
