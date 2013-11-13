<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisQuinielas.aspx.cs" Inherits="SIQUI.Miembros.MisQuinielas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mis Quinielas</h1>
    <asp:gridview id="quinielasGrid" 
       autogeneratecolumns="true"
       autogenerateselectbutton="true"
       allowpaging="true" 
       selectedindex="0"
       onselectedindexchanged="quinielasGrid_SelectedIndexChanged"
       onselectedindexchanging="quinielasGrid_SelectedIndexChanging"   
       runat="server">
                
       <selectedrowstyle backcolor="LightCyan"
         forecolor="DarkBlue"
         font-bold="true"/>  
                
     </asp:gridview>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
