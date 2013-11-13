<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarQuiniela.aspx.cs" Inherits="SIQUI.Miembros.EditarQuiniela" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Edición de quinielas</h1>
    En este espacio podrás editar libremente tus quinielas. Sólo debes seleccionar el pronóstico que deseas editar.
    <asp:gridview id="quinielasGrid" 
       autogeneratecolumns="true"
       autogenerateselectbutton="true"
       allowpaging="false" 
       selectedindex="0"
       onselectedindexchanged="quinielasGrid_SelectedIndexChanged"
       onselectedindexchanging="quinielasGrid_SelectedIndexChanging"   
       runat="server">
                
       <selectedrowstyle backcolor="LightCyan"
         forecolor="DarkBlue"
         font-bold="true"/>  
                
     </asp:gridview>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
