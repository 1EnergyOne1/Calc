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

namespace Calc
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Star(object sender, RoutedEventArgs e)
        {
            int t1 = Convert.ToInt32(text1.Text);
            int t2 = Convert.ToInt32(text2.Text);        

            Result.Content = t1 * t2;
        }

        private void Button_Click_Cherta(object sender, RoutedEventArgs e)
        {
            int t1 = Convert.ToInt32(text1.Text);
            int t2 = Convert.ToInt32(text2.Text);

            Result.Content = t1 / t2;
        }

        private void Button_CLick_Plus(object sender, RoutedEventArgs e)
        {
            int t1 = Convert.ToInt32(text1.Text);
            int t2 = Convert.ToInt32(text2.Text);

            Result.Content = t1 + t2;
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            int t1 = Convert.ToInt32(text1.Text);
            int t2 = Convert.ToInt32(text2.Text);

            Result.Content = t1 - t2;
        }

        private void Btn_Click_Two(object sender, RoutedEventArgs e)
        {
            int c1 = Convert.ToInt32(text1Conv.Text);
            var c2 = Convert.ToString(c1, 2).PadLeft(8, '0');

            ResultConv.Content = c2;
            

            
        }

        private void Btn_Click_Ten(object sender, RoutedEventArgs e)
        {
            string c1 = text1Conv.Text;
            var c2 = Convert.ToInt32(c1, 2);

            ResultConv.Content = c2;
        }

        private void Btn_Click_Sixteen(object sender, RoutedEventArgs e)
        {
            string c1 = text1Conv.Text;
            var c2 = Convert.ToString((Convert.ToInt32(c1,2),8));

            ResultConv.Content = c2;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void RadioButtonClickedBefore(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButtonClickedAfter(object sender, RoutedEventArgs e)
        {

        }
    }
}
