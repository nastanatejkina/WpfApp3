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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Физика.xaml
    /// </summary>
    public partial class Физика : Window
    {
        private List<string> question = new List<string> { "Сила, с которой тело выталкивается из жидкости, называется …", "Чтобы тело полностью плавало на поверхности жидкости нужно, чтобы его плотность была…", "Как изменится уровень жидкости в стакане, если кусочек льда, который лежит сверху на поверхности воды, растает?", "Плотность измеряется в следующих единицах …", "Галилей для изучения законов свободного падения тел изучал движение тел с наклонной плоскости. Как называются такие действия ученых?" };
        private List<string> answer = new List<string> { "Сила Архимеда", "Ниже плотности жидкости", "Не изменится", "Килограмм на метр в кубе", "Опыты" };
        private List<int> score = new List<int> { 100, 200, 300, 400, 500 };

        private int currentquestion = 0;
        private MainWindow mainWindow;
        public Физика(MainWindow mainWindow)
        {
            InitializeComponent();
            Quest.Text = question[0];
            this.mainWindow = mainWindow;
        }

        private void Buttonq_Click(object sender, RoutedEventArgs e)
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
