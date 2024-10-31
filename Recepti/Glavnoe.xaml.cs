using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
namespace Recepti
{
    public partial class Glavnoe : Window
    {
        public Glavnoe()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=DA2004DA\SQLEXPRESS;Initial Catalog=Kniga_Receptov;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string recipeQuery = "SELECT Id, Nazvanie, Avtor_Recepta FROM Recept";
                SqlDataAdapter recipeAdapter = new SqlDataAdapter(recipeQuery, connection);

                DataTable recipesTable = new DataTable();
                recipeAdapter.Fill(recipesTable);
                dgRecipes.ItemsSource = recipesTable.DefaultView;
            }
        }
        private void dgRecipes_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Sozdanie Sozdanie = new Sozdanie();
            Sozdanie.Show();
            this.Close();
        }
        private void ActionButton_Click(object sender, RoutedEventArgs e)
        {
            var recipeDataRowView = ((Button)sender).DataContext as DataRowView;
            if (recipeDataRowView != null)
            {
                int recipeId = Convert.ToInt32(recipeDataRowView["Id"]); 
                Recept receptWindow = new Recept(recipeId); 
                receptWindow.Show(); 
                this.Close(); 
            }
        }
    }
}