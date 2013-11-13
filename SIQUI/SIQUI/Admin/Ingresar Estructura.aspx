<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingresar Estructura.aspx.cs" Inherits="SIQUI.Admin.Ingresar_Estructura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <p>Elija el archivo que desea cargar.</p>
    <table>
        <tr>
            <td>

               <asp:FileUpload ID="archivoXml" runat="server" />
            </td>
            <td>
   
    
               <asp:Button ID="cargaBt" runat="server" Text="Cargar" OnClick="cargaBt_Click" />
            </td>
            <tr>
                <td>
               <asp:Label ID="rutaLb" runat="server" Text=""></asp:Label>
             </td>

            </tr>

    </table>
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
