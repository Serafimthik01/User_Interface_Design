using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using System.Windows.Threading;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += Timer_Tick;

            panelWidth = sidePanel.Width;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 35)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void Button_Click_LeftMenu(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void PanelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }












        #region For the visually impaired

        private void Serif(object sender, RoutedEventArgs e)
        {
            FontFamily = new FontFamily("Times New Roman");
        }

        private void Non_serif(object sender, RoutedEventArgs e)
        {
            FontFamily = new FontFamily("Segoe Ui");
        }

        private void Small_size(object sender, RoutedEventArgs e)
        {
            FontSize = 14;
        }

        private void Normal_size(object sender, RoutedEventArgs e)
        {
            FontSize = 21;
        }

        private void Large_size(object sender, RoutedEventArgs e)
        {
            FontSize = 28;
        }

        private void Normal_background(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
            Foreground = Brushes.Black;
        }

        private void Black_background(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Black;
            Foreground = Brushes.White;
        }

        private void Blue_background(object sender, RoutedEventArgs e)
        {
            Background = Brushes.SkyBlue;
            Foreground = Brushes.RoyalBlue;
        }

        #endregion

        private void Hide_BadEyes(object sender, RoutedEventArgs e)
        {
            if(For_Bad_Eyes.Visibility == Visibility.Hidden)
            {
                For_Bad_Eyes.Visibility = Visibility.Visible;
            }
            else
            {
                For_Bad_Eyes.Visibility = Visibility.Hidden;
            }

        }

        private void ListViewItem_Selected_Home(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_Selected_Inbox(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_SelectedOProgramm(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }

        private void ListViewItem_SelectedLogin(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_Selected_VisuallyImpaired(object sender, RoutedEventArgs e)
        {
            Thickness thickness = MainScreen.Margin;
            if (For_Bad_Eyes.Visibility == Visibility.Hidden)
            {
                thickness.Top = 83;
                MainScreen.Margin = thickness;
                For_Bad_Eyes.Visibility = Visibility.Visible;
            }
            else
            {
                thickness.Top = 0;
                MainScreen.Margin = thickness;
                For_Bad_Eyes.Visibility = Visibility.Hidden;
            }
        }

        private void No_Image(object sender, RoutedEventArgs e)
        {
            if (Im.Visibility == Visibility.Visible)
            {
                Im.Visibility = Visibility.Hidden;
                Im1.Visibility = Visibility.Hidden;
                Im2.Visibility = Visibility.Hidden;
                Im3.Visibility = Visibility.Hidden;
                Im4.Visibility = Visibility.Hidden;
                Im6.Visibility = Visibility.Hidden;
            }
            else
            {
                Im.Visibility = Visibility.Visible;
                Im1.Visibility = Visibility.Visible;
                Im2.Visibility = Visibility.Visible;
                Im3.Visibility = Visibility.Visible;
                Im4.Visibility = Visibility.Visible;
                Im6.Visibility = Visibility.Visible;
            }
        }


        #region Buttons Orders

        int currentValue1 = 0;
        int currentValue2 = 0;
        int currentValue3 = 0;
        int currentValue4 = 0;
        int currentValue5 = 0;
        int currentValue6 = 0;





        private void SelectOrder()
        {
            Order1.Background = Brushes.Orange; // Измените цвет на желаемый
        }

        private void ButtonMain1(object sender, RoutedEventArgs e)
        {
            SelectOrder();
            But1();
        }

        private void But1()
        {
            currentValue1++;
            labelbut1.Content = currentValue1.ToString();
        }
        private void ButtonMain2(object sender, RoutedEventArgs e)
        {
            SelectOrder();
            But2();
        }

        private void But2()
        {
            currentValue2++;
            labelbut2.Content = currentValue2.ToString();
        }

        private void ButtonMain3(object sender, RoutedEventArgs e)
        {
            SelectOrder();
            But3();
        }

        private void But3()
        {
            currentValue3++;
            labelbut3.Content = currentValue3.ToString();
        }

        private void ButtonMain4(object sender, RoutedEventArgs e)
        {
            SelectOrder();
            But4();
        }

        private void But4()
        {
            currentValue4++;
            labelbut4.Content = currentValue4.ToString();
        }
        private void ButtonMain5(object sender, RoutedEventArgs e)
        {
            SelectOrder();
            But5();
        }

        private void But5()
        {
            currentValue5++;
            labelbut5.Content = currentValue5.ToString();
        }
        private void ButtonMain6(object sender, RoutedEventArgs e)
        {
            SelectOrder();
            But6();
        }

        private void But6()
        {
            currentValue6++;
            labelbut6.Content = currentValue6.ToString();
        }

        private void ButtonOrder(object sender, RoutedEventArgs e)
        {
            if ((string)Order1.Content == "Заказать")
                Order1.Content = "Заказано";
        }
        //private void ButtonOrder2(object sender, RoutedEventArgs e)
        //{
        //    if ((string)Order2.Content == "Заказать")
        //        Order2.Content = "В корзине";
        //}
        //private void ButtonOrder3(object sender, RoutedEventArgs e)
        //{
        //    if ((string)Order3.Content == "Заказать")
        //        Order3.Content = "В корзине";
        //}
        //private void ButtonOrder4(object sender, RoutedEventArgs e)
        //{
        //    if ((string)Order4.Content == "Заказать")
        //        Order4.Content = "В корзине";
        //}
        //private void ButtonOrder5(object sender, RoutedEventArgs e)
        //{
        //    if ((string)Order5.Content == "Заказать")
        //        Order5.Content = "В корзине";
        //}
        //private void ButtonOrder6(object sender, RoutedEventArgs e)
        //{
        //    if ((string)Order6.Content == "Заказать")
        //        Order6.Content = "В корзине";
        //}
        #endregion
    }
}
