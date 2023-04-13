using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {//списки вопросов и ответов
        private List<string> question = new List<string> { "Неклеточные формы жизни?", "Легочные пузырьки?", "Что такое микология?", "Что такое лейкоциты?", "Что такое хромосомы?" };
        private List<string> answer = new List<string> { "Вирусы", "Альвеолы", "Наука о грибах", "Клетки крови", "Носители наследственной информации" };
        private List<int> score = new List<int> { 100, 200, 300, 400, 500 };

        private int currentquestion = 0;
        private MainWindow mainWindow;
        public Window1(MainWindow mainWindow)
        {
            InitializeComponent();

            Quest.Text = question[0];
            this.mainWindow = mainWindow;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = Answers.Text;
            if (user == answer[currentquestion])
            {
                int points = score[currentquestion];
                (Application.Current.MainWindow as MainWindow).Addscore(points);
            }
            currentquestion += 1;
            if (currentquestion == question.Count)
            {
                Quest.Text = "конец";
                Answers.IsEnabled = false;
                Button.IsEnabled = false;
            }
            else
            {
                Quest.Text = question[currentquestion];
                Answers.Text = "";
            }
            
        }
    }
}
