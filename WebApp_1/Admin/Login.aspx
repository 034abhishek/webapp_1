<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp_1.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:200px;">
        <table align="center" class="style1" style="border:5px ridge #00ff21; width: 450px;">

            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Names="Aharoni" ForeColor="YellowGreen" Text="First trial" Style="font-weight:700"></asp:Label>
                    <hr/>
                </td>
            </tr>
    
            <tr>
                <td align="center" Style="width: 50%">
                    Login ID:
                </td>
                <td  align="center" Style="width: 50%">
                    <asp:TextBox ID="txtLoginId" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td align="center" Style="width: 50%">
                    Password:
                </td>
                <td  align="center" Style="width: 50%">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td align="center" Style="width: 50%">
                    &nbsp;
                </td>
                <td  align="center" Style="width: 50%">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"></asp:Button>
                </td>
            </tr>

            <tr> 
                <td align="center" colspan="2">
                    <hr/>
                    <asp:Label ID="lblAlert" runat="server" Font-Names="Aharoni" ForeColor="Red"></asp:Label>

                </td>
            </tr>
            </table>
    </div>
    </form>
</body>
</html>
