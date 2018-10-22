<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProgramHandin2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBoxCustomers" runat="server" Height="221px" Width="536px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="ButtonAll" runat="server" OnClick="ButtonAll_Click" Text="List all customers" Width="360px" />
&nbsp;
            <br />
            <asp:Button ID="ButtonJutland" runat="server" OnClick="ButtonJutland_Click" Text="List customers from Jutland" Width="360px" />
            &nbsp;
            <br />
            <asp:Button ID="ButtonFunen" runat="server" OnClick="ButtonFunen_Click" Text="List customers from Funen" Width="361px" />
&nbsp;&nbsp;
            <br />
            <asp:Button ID="ButtonZealand" runat="server" OnClick="ButtonZealand_Click" Text="List customers from Zealand" Width="360px" />
            <br />
            <br />
            <br />
            <asp:Label ID="AddCustomer" runat="server" Font-Bold="True" Text="Add customer to list here:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxZip" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Zip"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxRegion" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Region"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add customer" />
        </div>
    </form>
</body>
</html>
