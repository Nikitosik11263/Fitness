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
using Fitness.PrimaryWindow;

namespace Fitness
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegistrationWindow1 registrationWindow1 = new RegistrationWindow1(); 
            registrationWindow1.ShowDialog();
            this.Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FinalDataWindow1 finaldataWindow1 = new FinalDataWindow1();
            finaldataWindow1.ShowDialog();
            this.Close();
        }
    }
}
