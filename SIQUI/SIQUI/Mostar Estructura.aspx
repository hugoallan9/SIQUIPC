<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Mostar Estructura.aspx.cs" Inherits="SIQUI.Mostar_Estructura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wrapper">
        <div id="header1">
            <h1>Estructura del mundial</h1>
            <h2>Fase de Grupos</h2>
        </div>

        <!-- Comienzo de las tablas ---->
        <div id="wrapper">
            <div id="grupoIzquierdo">
                <asp:GridView ID="grida" runat="server" Caption=" Grupo A" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  
            </div>


            <div id="grupoDerecho">
                		  

                <asp:GridView ID="gridb" runat="server" Caption=" Grupo B" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  
                		  

            </div>

            <div id="grupoIzquierdo">

                <asp:GridView ID="gridc" runat="server" Caption=" Grupo C" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  

            </div>

            <div id="grupoDerecho">

                <asp:GridView ID="gridd" runat="server" Caption=" Grupo D" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  

            </div>
            
            <div id="grupoIzquierdo">

                <asp:GridView ID="gride" runat="server" Caption=" Grupo E" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  

            </div>

            <div id="grupoDerecho">

                <asp:GridView ID="gridf" runat="server" Caption=" Grupo F" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  

            </div>

            <div id="grupoIzquierdo">

                <asp:GridView ID="gridg" runat="server" Caption=" Grupo G" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  

            </div>

            <div id="grupoDerecho">

                <asp:GridView ID="gridh" runat="server" Caption=" Grupo H" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>  

            </div>
            <div id="grupoIzquierdo">
                <asp:GridView ID="gridO1" runat="server" Caption="Octavos de Final" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>
            </div>


                    <div id="grupoDerecho">
                        <asp:GridView ID="gridO2" runat="server" Caption="Equipos Octavos" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                            <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                        </asp:GridView>
                    </div>


                    
            <div id="grupoIzquierdo">
                <asp:GridView ID="gridO3" runat="server" Caption="Cuartos de final" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>

            </div>


            <div id="grupoDerecho">
                <asp:GridView ID="gridO4" runat="server" Caption="Equipos Cuartos" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>
            </div>

            <div id="grupoIzquierdo">
                <asp:GridView ID="gridO5" runat="server" Caption="SemiFinales" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>

            </div>
            <div id="grupoDerecho">
                <asp:GridView ID="gridO6" runat="server" Caption="Equipos SemiFinalistas" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>
            </div>

            <div id="grupoIzquierdo">


                <asp:GridView ID="gridO7" runat="server" Caption="Final" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>


            </div>

            <div id="grupoDerecho">

                <asp:GridView ID="gridO8" runat="server" Caption="Equipos Finalistas" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="#003300" GridLines="Vertical" HorizontalAlign="Justify" Width="30px">
                    <RowStyle BorderColor="Lime" BorderStyle="Dashed" BorderWidth="1px" ForeColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" Wrap="True" />
                </asp:GridView>

            </div>


    </div>


</asp:Content>
