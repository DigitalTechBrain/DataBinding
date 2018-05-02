<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageDispGridview.aspx.cs" Inherits="GridFormDemo.ImageDispGridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="EName" HeaderText="Name" />
                    <asp:BoundField DataField="EAddress" HeaderText="Address" />
                    <asp:TemplateField HeaderText="Screen Shot">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="400px" Width="400px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
