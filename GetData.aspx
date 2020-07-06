<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetData.aspx.cs" Inherits="GetData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 175px;
        }
    </style>
</head>
<body style="height: 188px">
    <form id="form1" runat="server">
    <div style="height: 192px">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">RID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="182px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="FIND" />
                    <asp:Label ID="Label1" runat="server" ForeColor="#CC0099"></asp:Label>
                </td>
            </tr>
            </table>
    
        <table class="auto-style1" id="t2" runat="server">
            <tr>
                <td class="auto-style2">NAME</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" MaxLength="20" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">GENDER</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>MALE</asp:ListItem>
                        <asp:ListItem>FEMALE</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">COURSE</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="131px">
                        <asp:ListItem>SELECT</asp:ListItem>
                        <asp:ListItem>BCA</asp:ListItem>
                        <asp:ListItem>MCA</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="MODIFY" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="DELETE" />
                </td>
            </tr>
        </table>
    
 
    
     </div>
    </form>
</body>
</html>
