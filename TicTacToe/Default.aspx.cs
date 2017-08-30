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
        int hasWinner = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button1.Text.Equals("."))
            {
                Button1.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button1.Text);
            }
            if (player == 2 && Button1.Text.Equals("."))
            {
                Button1.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button1.Text);
            }
            DrawCondition();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button2.Text.Equals("."))
            {
                Button2.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button2.Text);
            }
            if (player == 2 && Button2.Text.Equals("."))
            {
                Button2.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button2.Text);
            }
            DrawCondition();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button3.Text.Equals("."))
            {
                Button3.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button3.Text);
            }
            if (player == 2 && Button3.Text.Equals("."))
            {
                Button3.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button3.Text);
            }
            DrawCondition();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button4.Text.Equals("."))
            {
                Button4.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button4.Text);
            }
            if (player == 2 && Button4.Text.Equals("."))
            {
                Button4.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button4.Text);
            }
            DrawCondition();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button5.Text.Equals("."))
            {
                Button5.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button5.Text);
            }
            if (player == 2 && Button5.Text.Equals("."))
            {
                Button5.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button5.Text);
            }
            DrawCondition();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button6.Text.Equals("."))
            {
                Button6.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button6.Text);
            }
            if (player == 2 && Button6.Text.Equals("."))
            {
                Button6.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button6.Text);
            }
            DrawCondition();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button7.Text.Equals("."))
            {
                Button7.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button7.Text);
            }
            if (player == 2 && Button7.Text.Equals("."))
            {
                Button7.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button7.Text);
            }
            DrawCondition();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button8.Text.Equals("."))
            {
                Button8.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button8.Text);
            }
            if (player == 2 && Button8.Text.Equals("."))
            {
                Button8.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button8.Text);
            }
            DrawCondition();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (player == 1 && Button9.Text.Equals("."))
            {
                Button9.Text = "X";
                player = 2;
                Label1.Text = "Player 2 ";
                WinningCondition(Button9.Text);
            }
            if (player == 2 && Button9.Text.Equals("."))
            {
                Button9.Text = "O";
                player = 1;
                Label1.Text = "Player 1 ";
                WinningCondition(Button9.Text);
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