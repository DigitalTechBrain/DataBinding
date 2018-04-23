<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewDemo.aspx.cs" Inherits="GridFormDemo.ListViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListView ID="ListView1" runat="server">
 <ItemTemplate>

<asp:Label ID="NameLabel" runat="server" Text='<%#Eval("Ename") %>' />
     
</ItemTemplate>
            </asp:ListView>

        </div>
    </form>
</body>
</html>
