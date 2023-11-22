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

namespace VhodRegistr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> user;
        static int counter;
        public MainWindow()
        {
            InitializeComponent();
            user = new List<User>();
            user.Add(new User("admin", "123456"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = loginEnter.Text;
            string password = passwordEnter.Password;
            int schet = 0;
            for(int i = 0; i < user.Count; i++)
            {
                if (login.Equals(user[i].login)  && password.Equals(user[i].password))
                {
                    UserWindow window = new UserWindow();
                    window.Show();
                    this.Close();
                }
                else
                {
                    schet++;
                    if(schet == user.Count)
                    {
                        forErrors.Text = "Ошибка ввода";
                    }
                }

            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = nameCreate.Text;
            string email = emailCreate.Text;
            bool sex = false;
            if(counter == 0)
            {
                
            }
            sex = (bool)mSexCreate.IsChecked;

            string password = passwordCreate.Text;
            string passwordD = passwordDuplicate.Text;
            user.Add(new User(name, email, sex, password, passwordD));
            logInTab.IsSelected = true;
            nameCreate.Text = "";
            emailCreate.Text = "";
            passwordCreate.Text = "";
            passwordDuplicate.Text = "";
            mSexCreate.IsChecked = true;
        }

      
    }
}
