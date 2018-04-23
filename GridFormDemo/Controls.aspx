<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="GridFormDemo.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="GridViewDemo" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Grid Edit Update Delete" OnClick="Button2_Click" />
        </div>
        <div>
            <asp:Button ID="Button3" runat="server" Text="Grid Button Template" OnClick="Button3_Click" />
            <br />
            <br />
            -------------------------------------------</div>
        <div>
            <asp:Button ID="Button4" runat="server" Text="Xml demo" OnClick="Button4_Click" />
        </div>
        <p>
            ----------------------------------------</p>
        <p>
            <asp:Button ID="Button6" runat="server" Text="Form View" OnClick="Button6_Click" />
        </p>
        <p>
            -----------------------------------</p>
        <p>
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="List View" />
        </p>
        <p>
            --------------------------------------</p>
        <p>
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="MsAccess Connection" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
