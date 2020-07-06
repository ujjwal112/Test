﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HiddenField.aspx.cs" Inherits="HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HiddenField ID="P" runat="server" />
                </td>
                <td>
                    <asp:HiddenField ID="R" runat="server" />
                </td>
                <td>
                    <asp:HiddenField ID="T" runat="server" />
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
