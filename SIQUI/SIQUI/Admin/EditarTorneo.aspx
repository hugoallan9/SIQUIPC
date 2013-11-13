<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarTorneo.aspx.cs" Inherits="SIQUI.Admin.EditarTorneo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cambia el torneo acá</h1>
    <table>
        <tr>
            <td>
                
            Estado:
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        

    </table>
    <asp:Button ID="Button1" runat="server" Text="Cambiar" OnClick="Button1_Click" />
    <h3>Seleccione la fecha de Cierre</h3>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
