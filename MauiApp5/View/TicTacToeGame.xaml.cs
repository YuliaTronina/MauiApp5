using MauiApp5.VievModel;

namespace MauiApp5.View;

public partial class TicTacToeGame : ContentPage
{
    int count = 0;
    private Button[] buttons = new Button[9];
    private ViewModelGame game = new ViewModelGame();
    public TicTacToeGame()
	{
		InitializeComponent();
        
        buttons[0] = button1;
        buttons[1] = button2;
        buttons[2] = button3;
        buttons[3] = button4;
        buttons[4] = button5;
        buttons[5] = button6;
        buttons[6] = button7;
        buttons[7] = button8;
        buttons[8] = button9;


    }
    private void button_Clicked(object sender, EventArgs e)
    {

        game.SetButton((Button)sender);
        if (game.CheckWinner(buttons))
        {
            gameOverStackLayout.IsVisible = true;
        }
        count++;
    }
    private void ClicGameEnd(object sender, EventArgs e)
    {
        game.GoToGameCommand.Execute(null);
    }

    private void playagain_Clicked(Object sender, EventArgs e)
    {
        game.ResetGame(buttons);
        gameOverStackLayout.IsVisible = false;
    }

}
