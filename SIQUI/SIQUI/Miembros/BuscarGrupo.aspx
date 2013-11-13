<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarGrupo.aspx.cs" Inherits="SIQUI.Miembros.BuscarGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuNavegacion" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Listado de Grupos</h1>
    <p>Por favor elige un grupo para ver todas sus opciones.</p>
    <table>
        <tr>
            <td>
                <asp:DropDownList ID="muestrarioGrupos" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Ir a Grupo" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
