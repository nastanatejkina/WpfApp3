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
    /// Логика взаимодействия для ОБЖ.xaml
    /// </summary>
    public partial class ОБЖ : Window
    {
        private List<string> question = new List<string> { "Вещество (алкалоид) в листьях табака, вредное для здоровья человека.", "Специалист по ликвидациям ЧС", "Массовое заболевание людей.", "Добровольное отравление никотином.", "Как называется сигнал оповещения, подаваемый прерывистыми гудками, сиренами предприятий и транспортных средств?" };
        private List<string> answer = new List<string> { "Никотин", "Спасатель", "Эпидемия", "Курение", "Внимание всем" };
        private List<int> score = new List<int> { 100, 200, 300, 400, 500 };

        private int currentquestion = 0;
        private MainWindow mainWindow;
        public ОБЖ(MainWindow mainWindow)
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
