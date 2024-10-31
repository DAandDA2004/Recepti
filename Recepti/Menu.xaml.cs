using System;
using System.Windows;
namespace Recepti
{
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            WelcomeTextBlock.Text = $"Добро пожаловать, {CurrentUser.Name} {CurrentUser.Surname}!";
        }
        private void ViewRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            Glavnoe Glavnoe = new Glavnoe();
            Glavnoe.Show();
            this.Close();
        }
        private void ChangeProfileButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}