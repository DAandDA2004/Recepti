using System;
using System.Data.SqlClient;
using System.Windows;
namespace Recepti
{
    public partial class Comment : Window
    {
        private string connectionString = @"Data Source=DA2004DASQLEXPRESS;Initial Catalog=Kniga_Receptov;Integrated Security=True";
        public Comment()
        {
            InitializeComponent();
        }
        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            string otziv = OtzivTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(otziv))
            {
                MessageBox.Show("Отзыв не может быть пустым.");
                return;
            }
            string login = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO Otzovi (Login, Otziv) VALUES (@Login, @Otziv)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Login", (object)login ?? DBNull.Value);
                command.Parameters.AddWithValue("@Otziv", otziv);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Отзыв успешно сохранен!");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка базы данных: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
        }
        private void OtzivTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {}
    }
}