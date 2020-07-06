<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JavaScript.aspx.cs" Inherits="JavaScript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function ujjwal()
        {

            var a = document.getElementById("TextBox1").value;
            var b = document.getElementById("TextBox2").value;
            var c =  parseInt(a) + parseInt(b);
            alert("sum="+c);
        }
        function leap()
        {
            var a = document.getElementById("TextBox1").value;
            if (a % 4 == 0) {
                alert("Leap year");
            }
            else
            {
                alert("not a leap year");
            }
        }
        function validate()
        {
            var a = document.getElementById("TextBox1").value;
            if (a.trim() == "") {
                alert("Phone no. can not be blank!!!");
                return false;
            }
            else
            {
                return true;
            }
        }
        function validate1()
        {
            var a = document.getElementById("TextBox1").value;
            if (a.length != 10)
            {
                alert("Please enter only 10 digits");
                alert(a.length);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="ujjwal();"/>
    
        <asp:Button ID="Button2" runat="server" Text="Leap year" OnClientClick="leap();"/>
    
        <asp:Button ID="Button3" runat="server" Text="Submit" OnClick="Button3_Click" OnClientClick="return validate();"/>
        <asp:Button ID="Button4" runat="server" Text="Submit" OnClientClick="validate1();"/>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
