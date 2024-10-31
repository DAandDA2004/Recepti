using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
namespace Recepti
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (AuthorizeUser(login, password))
            {
                MessageBox.Show("Авторизация прошла успешно!");
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }
        private bool AuthorizeUser(string login, string password)
        {
            string connectionString = @"Data Source=DA2004DA\SQLEXPRESS;Initial Catalog=Kniga_Receptov;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Surname FROM Polzovateli WHERE Login = @Login AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CurrentUser.Login = login;
                    CurrentUser.Name = reader["Name"].ToString();
                    CurrentUser.Surname = reader["Surname"].ToString();

                    return true; 
                }
                else
                {
                    return false;
                }
            }
        }
        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {}
        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regist registWindow = new Regist();
            registWindow.Show();
        }
    }
}