<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 718px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 680px;height:30px; width:324px; font-family: Algerian" >
            Rock Paper Scissors Game</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 640px">
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="rb" Text="Rock" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="rb" Text="Paper" />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="rb" Text="Scissors" />
            
        </p>
        <p style="margin-left: 640px">
            &nbsp;</p>
        <p style="margin-left: 640px">
            <asp:Button ID="Button1" runat="server" Text="Start Game" OnClick="StartGame_Click" />
        </p>
        <p style="margin-left: 640px">
            &nbsp;</p>
        <p style="margin-left: 640px">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        </p>
        <p style="margin-left: 640px">
            &nbsp;</p>
         <p style="margin-left: 640px">
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="false"></asp:Label>
        </p>
        <p style="margin-left: 640px">
            &nbsp;</p>
        <div style="margin-left: 800px">
        </div>
        <div style="margin-left: 840px">
            <asp:Label ID="lblUserScoreTxt" runat="server" Text="User Score is:  " Visible="false"></asp:Label> <asp:Label ID="lblUserScore" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
        <div style="margin-left: 840px">
            <asp:Label ID="lblComScoreText" runat="server" Text="Computer Score is:" Visible="false"></asp:Label> <asp:Label ID="lblComputer" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
        <p style="margin-left: 640px">
            &nbsp;</p>
        <div style="margin-left: 1000px">
        </div>
            <div style="margin-left: 720px">
                <asp:Label ID="lblresult" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
