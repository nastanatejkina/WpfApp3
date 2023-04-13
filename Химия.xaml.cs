using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Химия.xaml
    /// </summary>
    public partial class Химия : Window
    {
        //создание списков
        private List<string> question = new List<string> { "Жидкий метал?", "Как называются вещества, состоящие из атомов одного вида?", "Цвет фенолфталеина в щелочах?", "Газ, поддерживающий горение?", "Как называется наименьшая частица вещества, обуславливающая его свойства?" };
        private List<string> answer = new List<string> { "Ртуть", "Простые", "Малиновый", "Кислород", "Молекула" };
        private List<int> score = new List<int> { 100, 200, 300, 400, 500 };

        //текущий вопрос
        private int currentquestion = 0;
        //экземпляр MainWindow
        private MainWindow mainWindow;
        public Химия(MainWindow mainWindow)
        {
            InitializeComponent();
            Quest.Text = question[0];
            this.mainWindow = mainWindow;
        }

        private void Buttonq_Click(object sender, RoutedEventArgs e)
        {
            string user = Answers.Text.ToLower();//приведение к нижнему регистру
            //проверка
            if (user == answer[currentquestion].ToLower()) //тоже самое и сравнение
            {
                //если ответ правильный добавляем очки
                int points = score[currentquestion];
                (Application.Current.MainWindow as MainWindow).Addscore(points);
            }
            //переход к следующему вопросу
            currentquestion += 1;
            //если закончились вопросы завершаем
            if (currentquestion == question.Count)
            {
                Quest.Text = "конец";
                Answers.IsEnabled = false;
                Button.IsEnabled = false; 
                
            }
            else
            {   
                //если не закончились выводим след вопрос
                Quest.Text = question[currentquestion];
                //очищаем поле для ответа
                Answers.Text = "";
               
            }
           
        }

        private void Questq_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
