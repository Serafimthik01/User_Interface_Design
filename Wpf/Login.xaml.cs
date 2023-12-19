using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true; // Если не является, игнорируем ввод
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NumberBox.Text, out int number))
            {
                if (number < 13)
                {
                    Label1.Visibility = Visibility.Visible;
                }
            }
            else if(string.IsNullOrEmpty(passwordbox.Password))
            {
                Label2.Visibility = Visibility.Visible;
            }
            else { this.Close(); }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.TextChanged -= textBox_TextChanged;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text);
                textBox.CaretIndex = textBox.Text.Length; 
            }
            textBox.TextChanged += textBox_TextChanged;
        }
    }
}
