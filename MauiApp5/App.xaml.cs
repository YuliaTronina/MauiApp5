using MauiApp5.View;
namespace MauiApp5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Routing.RegisterRoute(nameof(TicTacToeGame), typeof(TicTacToeGame));
        }
    }
}
