﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>crud Basico</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Registrate <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
&nbsp;<br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
&nbsp;<br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button_insert" runat="server" OnClick="Button_insert_Click" 
            Text="Insertar" />
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Eliminar" />
    
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar" />
    
    </div>
    </form>
</body>
</html>
