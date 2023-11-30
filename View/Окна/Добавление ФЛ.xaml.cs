using Microsoft.EntityFrameworkCore;
using System.Windows;
using Model;
using System.Linq;

namespace View.Окна
{
    /// <summary>
    /// Логика взаимодействия для Добавление_ФЛ.xaml
    /// </summary>
    public partial class Добавление_ФЛ : Window
    {
        private DBCont db = new DBCont();
        public Добавление_ФЛ()
        {
            InitializeComponent();
        }
        public void OnAddButtonPressed(object sender, RoutedEventArgs e)
        {

        }
        public void OnExitButtonPressed(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
