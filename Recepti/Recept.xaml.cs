using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
namespace Recepti
{
    public partial class Recept : Window
    {
        private string connectionString = @"Data Source=DA2004DA\SQLEXPRESS;Initial Catalog=Kniga_Receptov;Integrated Security=True";
        private int recipeId;
        public Recept(int id)
        {
            InitializeComponent();
            recipeId = id;
            LoadRecipeData();
        }
        private void LoadRecipeData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string recipeQuery = "SELECT Nazvanie, Opisanie, Ingredienti, Kategoria, Avtor_Recepta, Instrukcia FROM Recept WHERE Id = @Id";
                SqlCommand command = new SqlCommand(recipeQuery, connection);
                command.Parameters.AddWithValue("@Id", recipeId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        NazvanieTextBlock.Text = reader["Nazvanie"].ToString();
                        OpisanieTextBlock.Text = reader["Opisanie"].ToString();
                        IngredientiTextBlock.Text = reader["Ingredienti"].ToString();
                        KategoriaTextBlock.Text = reader["Kategoria"].ToString();
                        AvtorReceptaTextBlock.Text = reader["Avtor_Recepta"].ToString();
                        InstrukciaTextBlock.Text = reader["Instrukcia"].ToString();
                    }
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Glavnoe Glavnoe = new Glavnoe();
            Glavnoe.Show();
            this.Close();
        }
        private void dgOtzivi_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {}
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Comment commentWindow = new Comment();
            commentWindow.ShowDialog();
            this.Close();
        }
    }
}