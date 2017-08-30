using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class Default : System.Web.UI.Page
    {
       static int player = 1;
        Button button;
        int hasWinner = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            button = (Button)sender;
            if (player == 1 && button.Text.Equals("."))
            {
                button.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(button.Text);
            }
            if (player == 2 && button.Text.Equals("."))
            {
                button.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(button.Text);
            }
            DrawCondition();
        }
        
        protected void WinningCondition(string text)
        {
            if ((Button1.Text.Equals(text) && Button2.Text.Equals(text) && Button3.Text.Equals(text)) ||
                     (Button4.Text.Equals(text) && Button5.Text.Equals(text) && Button6.Text.Equals(text)) ||
                     (Button7.Text.Equals(text) && Button8.Text.Equals(text) && Button9.Text.Equals(text)) ||
                     (Button1.Text.Equals(text) && Button4.Text.Equals(text) && Button7.Text.Equals(text)) ||
                     (Button2.Text.Equals(text) && Button5.Text.Equals(text) && Button8.Text.Equals(text)) ||
                     (Button3.Text.Equals(text) && Button6.Text.Equals(text) && Button9.Text.Equals(text)) ||
                     (Button1.Text.Equals(text) && Button5.Text.Equals(text) && Button9.Text.Equals(text)) ||
                     (Button3.Text.Equals(text) && Button5.Text.Equals(text) && Button7.Text.Equals(text)))
            {
                if (player == 1)
                {
                    Label2.Text = "Match's Status";
                    Label1.Text = "Player 2 wins";
                    hasWinner = 1;
                    ResetGame();
                }
                else
                {
                    Label2.Text = "Match's Status";
                    Label1.Text = "Player1 wins";
                    hasWinner = 1;
                    ResetGame();
                }
            }
        }

        protected void DrawCondition()
        {
            if(Button1.Text!="." && Button2.Text != "." && Button3.Text != "." && Button4.Text != "." &&
                Button5.Text != "." && Button6.Text != "." && Button7.Text != "." && Button8.Text != "." &&
                Button9.Text != "." && hasWinner==0 )
            {
                Label2.Text = "Match's Status";
                Label1.Text = "Match Draw";
            }
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        protected void ResetGame()
        {
            Button1.Text = ".";
            Button2.Text = ".";
            Button3.Text = ".";
            Button4.Text = ".";
            Button5.Text = ".";
            Button6.Text = ".";
            Button7.Text = ".";
            Button8.Text = ".";
            Button9.Text = ".";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}