<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Getdb.aspx.cs" Inherits="Getdb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {}
        .auto-style4 {
            width: 247px;
        }
        .auto-style5 {
            width: 134px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">ENTER ID</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="FIND" />
                    <asp:Label ID="Label1" runat="server" ForeColor="#990033"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1" id="t2" runat="server">
            <tr>
                <td class="auto-style3" colspan="2" style="text-align: center">
                    <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">FIRST NAME&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">LAST NAME</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">GENDER</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>MALE</asp:ListItem>
                        <asp:ListItem>FEMALE</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">QUALIFICATION</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>BCA</asp:ListItem>
                        <asp:ListItem>MCA</asp:ListItem>
                        <asp:ListItem>MBA</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">DEPARTMENT</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>IT</asp:ListItem>
                        <asp:ListItem>HR</asp:ListItem>
                        <asp:ListItem>ADMIN</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">ID PROOF</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>PAN</asp:ListItem>
                        <asp:ListItem>ADHAAR</asp:ListItem>
                        <asp:ListItem>VOTER ID</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">UPLOAD ID</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="UPDATE" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button1_Click" Text="DELETE" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
