using Microsoft.SqlServer.Server;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {  public int score = 0;
        // ищите пояснение для всех форм в Химия.xaml.cs там все комметарии по строкам
        //все последующие формы имеют одиннаковый код
        public MainWindow()
        {
            InitializeComponent();
        }
        //
        public void Addscore(int points)
        {
            score += points;
            Score.Text = "Очки:" + score.ToString();
        }

        private void Score_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        //переход на другие формы 
        private void Биология(object sender, RoutedEventArgs e)
        {
            Window1 win2 = new Window1(this);
            win2.Show();
        }

        private void Химия(object sender, RoutedEventArgs e)
        {
            Химия win2 = new Химия(this);
            win2.Show();
        }

        private void математика(object sender, RoutedEventArgs e)
        {
            Математика win2 = new Математика(this);
            win2.Show();
        }

        private void обж(object sender, RoutedEventArgs e)
        {
            ОБЖ win2 = new ОБЖ(this);
            win2.Show();
        }

        private void физика(object sender, RoutedEventArgs e)
        {
            Физика win2 = new Физика(this);
            win2.Show();
        }
    }
}
