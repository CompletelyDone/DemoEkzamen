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

namespace View.Окна
{
    /// <summary>
    /// Логика взаимодействия для Добавление_ЮЛ.xaml
    /// </summary>
    public partial class Добавление_ЮЛ : Window
    {
        public Добавление_ЮЛ()
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
