<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ElegirTorneo.aspx.cs" Inherits="SIQUI.Admin.ElegirTorneo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuNavegacion" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                Elige el campeonato que deseas editar
            </td>
            <td>
                <asp:DropDownList ID="listadoCampeonatos" runat="server"></asp:DropDownList>
            </td>
        </tr>
    </table>
    <p align="center">
        <asp:Button ID="elegirBt" runat="server" Text="Elegir Campeonato" OnClick="elegirBt_Click" />
    </p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
