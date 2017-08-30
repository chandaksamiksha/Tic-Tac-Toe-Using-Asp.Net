<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TicTacToe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tic Tac Toe Game</title>
    <link rel="stylesheet" type="text/css" />
    <style type="text/css">
        #winnerMessage {
            width: 77px;
        }
        .auto-style1 {
            width: 45px;
        }
        .auto-style2 {
            width: 194px;
            height: 40px;
        }
    </style>
</head>
<body>
<form id="index" runat="server">
<header>
<h3 style="width: 152px">Tic Tac Toe</h3>
</header>
<section>
<article id="mainGame">
 <table id="board">
<tr>
<td><asp:Button ID="Button1" runat="server" Height="45px" Width="45px" OnClick="Button1_Click" Text="." /></td>
 <td><asp:Button ID="Button2" runat="server" Height="45px" Width="45px" OnClick="Button2_Click" Text="." /></td>
<td class="auto-style1"><asp:Button ID="Button3" runat="server" Height="45px" Width="45px" OnClick="Button3_Click" Text="." /></td>
</tr>
<tr>
<td><asp:Button ID="Button4" runat="server" Height="45px" Width="45px" OnClick="Button4_Click" Text="." /> </td>
<td><asp:Button ID="Button5" runat="server" Style="width: 45px; height: 45px;" OnClick="Button5_Click" Text="." /></td>
<td class="auto-style1"><asp:Button ID="Button6" runat="server" Style="width: 45px; height: 45px;" OnClick="Button6_Click" Text="." /></td>
</tr>
<tr>
<td><asp:Button ID="Button7" runat="server" Height="45px" Width="45px" OnClick="Button7_Click" Text="." /></td>
<td><asp:Button ID="Button8" runat="server"  Style="width: 45px; height: 45px;" OnClick="Button8_Click" Text="." /></td>
<td class="auto-style1"><asp:Button ID="Button9" runat="server"  Style="width: 45px; height: 45px;" OnClick="Button9_Click" Text="." /></td>
</tr>
</table>
</article>

<article id="TurnLabel" runat="server">
    <br />
    <asp:Label ID="Label2" runat="server" Text="Turn"></asp:Label>
    <br />
</article>

<article id="currentTurn" runat="server">
<div class="auto-style2">
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    </div>
</article>
</section>
<br />
<br />

    <asp:Button ID="Reset" runat="server" Text="Reset" Width="139px" OnClick="Reset_Click" />
&nbsp;
    <asp:Button ID="Button12" runat="server" Text="Play Again" Width="139px" OnClick="Button12_Click" />
</form>
</body>
</html>