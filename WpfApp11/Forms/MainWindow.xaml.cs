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

namespace WpfApp11
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox
               .Show("Вы действительно хотите удалить этот файл?", "внимание!",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("товар удален!");
            }
            else
            {
                MessageBox.Show("товар не удален!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox
               .Show("Добавить товар", "внимание!",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question);
            Window1 taskWindow = new Window1();
            taskWindow.Show();
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("товар добавлен!");
            }
            else
            {
                MessageBox.Show("товар не добавлен!");
            }
        }

       
    }
}
