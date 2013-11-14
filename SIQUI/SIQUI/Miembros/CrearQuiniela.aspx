<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearQuiniela.aspx.cs" Inherits="SIQUI.Miembros.CrearQuiniela" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <table>
        <tr>
            <td>
                <span>El campeonato es: </span>
            </td>
            <td>
                <asp:Label ID="torneoLb" runat="server" Text=""></asp:Label>    
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="nombreQuiniela" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="ingresoQBt" runat="server" Text="Crear Quiniela" OnClick="ingresoQBt_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="mensaje" runat="server" Text="Elija el nombre de la quiniela"></asp:Label>
            </td>
            <td>
                <asp:Label ID="mensajeCampeonato" runat="server" Text="Elija el torneo"></asp:Label>
            </td>

        </tr>
        </table>
    <table>
        <tr>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Crear Quiniela con XML" OnClick="Button1_Click" />
            </td>
            <td>
                <asp:Label ID="xmlLb" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>

            </td>
        </tr>
        
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
