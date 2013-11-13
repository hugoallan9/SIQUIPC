<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearGrupo.aspx.cs" Inherits="SIQUI.Miembros.CrearGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuNavegacion" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvenido al centro de creación de grupos.</h1>
    <p>Por favor elige el nombre del grupo que deseas crear. </p>
    <table>
        <tr>
            <td>
                <asp:TextBox ID="nombreGrupo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="crearGrupoBt" runat="server" Text="Crear Grupo" OnClick="crearGrupoBt_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="mensajeGrupo" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
