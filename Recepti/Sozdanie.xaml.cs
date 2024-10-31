using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
namespace Recepti
{
    public partial class Sozdanie : Window
    {
        private readonly string connectionString = @"Data Source=DA2004DA\SQLEXPRESS;Initial Catalog=Kniga_Receptov;Integrated Security=True";
        public Sozdanie()
        {
            InitializeComponent();
            Avtor_Recepta.Text = CurrentUser.Login;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Glavnoe Glavnoe = new Glavnoe();
            Glavnoe.Show();
            this.Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            string nazvanie = Nazvanie.Text;
            string avtor = Avtor_Recepta.Text;
            string opisanie = Opisanie.Text;
            string kategoria = Kategoria.Text;
            string ingredienti = Ingredienti.Text;
            string instrukcia = Instrukcia.Text;
            if (string.IsNullOrWhiteSpace(nazvanie) || string.IsNullOrWhiteSpace(avtor) ||
                string.IsNullOrWhiteSpace(opisanie) || string.IsNullOrWhiteSpace(kategoria) ||
                string.IsNullOrWhiteSpace(ingredienti) || string.IsNullOrWhiteSpace(instrukcia))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Recept (Nazvanie, Opisanie, Ingredienti, Kategoria, Avtor_Recepta, Instrukcia) VALUES (@Nazvanie, @Opisanie, @Ingredienti, @Kategoria, @Avtor_Recepta, @Instrukcia)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nazvanie", nazvanie);
                    command.Parameters.AddWithValue("@Opisanie", opisanie);
                    command.Parameters.AddWithValue("@Ingredienti", ingredienti);
                    command.Parameters.AddWithValue("@Kategoria", kategoria);
                    command.Parameters.AddWithValue("@Avtor_Recepta", avtor);
                    command.Parameters.AddWithValue("@Instrukcia", instrukcia);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Рецепт успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении рецепта: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void ClearFields()
        {
            Nazvanie.Clear();
            Opisanie.Clear();
            Kategoria.Clear();
            Ingredienti.Clear();
            Instrukcia.Clear();
        }
        private void NazvanieTextBox_TextChanged(object sender, TextChangedEventArgs e) 
        {}
        private void OpisanieTextBox_TextChanged(object sender, TextChangedEventArgs e) 
        {}
        private void KategoriaTextBox_TextChanged(object sender, TextChangedEventArgs e) 
        {}
        private void IngredientiTextBox_TextChanged(object sender, TextChangedEventArgs e) 
        {}
        private void InstrukciaTextBox_TextChanged(object sender, TextChangedEventArgs e) 
        {}
        private void Avtor_ReceptaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {}
    }
}