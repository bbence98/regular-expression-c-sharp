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
using System.Text.RegularExpressions;

namespace RegularExpression
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
            if (!Regex.IsMatch(txtName.Text, @"^([A-Za-z]+\s*)+$"))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed");
            }

            if (!Regex.IsMatch(txtPhone.Text, @"((?:\(?[2-9](?(?=1)1[02-9]|(?(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})"))
            {
                MessageBox.Show("The Phone is invalid (try a different format)");
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("The E-mail address is invalid (use a valid address)");
            }
            string formattedNumber = ReformatPhone(txtPhone.Text);
            Console.WriteLine(formattedNumber);
        }

        private string ReformatPhone(string input)
        {
            string result = null;
            string start = input.Substring(0, 4);
            string mid = input.Substring(4, 3);
            string end = input.Substring(7, 4);
            
            // (###) ###-####
            result = String.Format("({0}) {1}-{2}", start, mid, end);

            return result;
        }
    }
}
