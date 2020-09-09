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

namespace WPF_Participation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string year;

            year = txtYear.Text;

          
            DateTime birthday = Convert.ToDateTime(year);

            var age = DateTime.Now - birthday;
            int old = Convert.ToInt32(age.TotalDays / 365);

            btnCalculate.Background = new SolidColorBrush(Colors.Red);

            MessageBox.Show($"You are {old} years old!");







        }

       
    }
}
