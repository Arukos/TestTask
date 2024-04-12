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

namespace TestTask
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void TextBox_MouseDoubleClick_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
        }
        private void TextBox_MouseDoubleClick_2(object sender, RoutedEventArgs e)
        {
            TextBox2.Clear();
        }
        private void TextBox_MouseDoubleClick_3(object sender, RoutedEventArgs e)
        {
            TextBox3.Clear();
        }
        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            SecFrame.Content = new Page3();
        }
    }
}
