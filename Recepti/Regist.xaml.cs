using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
namespace Recepti
{
    public partial class Regist : Window
    {
        private readonly string connectionString = @"Data Source=DA2004DA\SQLEXPRESS;Initial Catalog=Kniga_Receptov;Integrated Security=True";
        public Regist()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Polzovateli (Name, Surname, Login, Password) VALUES (@Name, @Surname, @Login, @Password)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно зарегистрирован!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e) { }
        private void SurnameTextBox_TextChanged(object sender, TextChangedEventArgs e) { }
        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e) { }
        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e) { }
    }
}