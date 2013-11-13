<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SIQUI._Default" %>

<asp:Content runat="server" ID="Navegacion" ContentPlaceHolderID="MenuNavegacion">
    <asp:Menu ID="Menu1" runat="server" orientation="horizontal" OnMenuItemClick="Menu1_MenuItemClick"></asp:Menu>
    
      </asp:Content>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">

</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
      <h1>Bienvenido al sitio &quot;Deportes Chapines&quot;</h1>
    <p>Con ocasión de la copa del mundo estaremos ofreciendo el sistema de quinielas, con el cual puedes probar tu pasión por el futbol y ganar premios a la vez. Lo primero que debes hacer es registrarte en nuestro sitio web y con ello podrás iniciar una divertida aventura en tu deporte favorito. Para ver las reglas del juego visita<a href="#">Reglas de Quinielas</a></p>
    <div class="news"><strong>Noticias Más Recientes</strong>
      <p> <a href="http://www.free-css.com/">Nunc commodo metus et lorem. Phasellus vel libero.</a></p>
      <p> <a href="http://www.free-css.com/">Vestibulum eu enim. Mauris pharetra. Vestibulum ligula libero, vestibulum quis, commodo non, sagittis eget, elit.</a></p>
      <p> <a href="http://www.free-css.com/">Ut nec tellus. Nunc ligula quam, vulputate ut, imperdiet nec, luctus at, magna. Nunc posuere nulla ac tortor.</a></p>
    </div>
    <h2>Headline! (h2, h3)</h2>
    <p>Quisque vulputate. Aliquam condimentum, odio vel ultrices sodales, augue lorem vehicula mi, vel nonummy nisl eros et tortor. Duis laoreet pellentesque lorem. Nam sagittis condimentum libero. Nullam a ante vel massa accumsan elementum. Sed mauris metus, tincidunt quis, blandit at, viverra a, ligula. Pellentesque neque metus, mattis non, tincidunt vitae, euismod scelerisque, nulla. Fusce justo. Donec nec nibh. Sed suscipit bibendum leo. Nulla erat ligula, egestas consequat, sagittis ut, fermentum a, diam. Sed turpis est, aliquam nec, lacinia sed, aliquam non, libero. Ut turpis. Pellentesque viverra pharetra quam.</p>
    <p> <a href="http://www.free-css.com/">This is a link</a></p>
    <h4>Headline (h4, h5, h6)</h4>
    <p>Aenean dapibus, leo vitae eleifend porta, sem ipsum nonummy est, eu fermentum arcu lectus in lacus. Vestibulum tristique metus eu lorem. Pellentesque sed erat. Morbi pharetra condimentum massa. Vestibulum vel nulla at eros porta tempus. Fusce at lorem. Nulla facilisis. Phasellus nisl. Integer id massa nec tellus rutrum pellentesque. Mauris orci mauris, dictum vitae, varius eget, vestibulum quis, risus. Pellentesque dictum, magna vitae pulvinar interdum, orci lacus posuere neque, et lacinia dui eros ut erat. Ut purus. Nullam ac tellus et eros condimentum interdum.</p>
    <div class="clear"></div>
</asp:Content>
