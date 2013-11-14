<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerResultados.aspx.cs" Inherits="SIQUI.Miembros.VerResultados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuNavegacion" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
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
<asp:Content ID="Content4" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
