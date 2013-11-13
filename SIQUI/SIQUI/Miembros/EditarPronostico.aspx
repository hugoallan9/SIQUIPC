<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPronostico.aspx.cs" Inherits="SIQUI.Miembros.EditarPronostico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Edición de Pronosticos</h1>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <table>
        <tr>
            <td>Primer Puesto</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Segundo Puesto
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Ganador
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>

    <div alig="center">
        <asp:Button ID="Button1" runat="server" Text="Guardar Cambios" OnClick="Button1_Click" /></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
