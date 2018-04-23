<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormViewDemo.aspx.cs" Inherits="GridFormDemo.FormViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:FormView ID="FormView1" runat="server">
                <ItemTemplate>
                    <table style="width:100%;">
                        <tr>
                            <td>S.No</td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Sno") %>'></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Name</td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Ename") %>'></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Address</td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Eaddress") %>'></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:FormView>

        </div>
    </form>
</body>
</html>
