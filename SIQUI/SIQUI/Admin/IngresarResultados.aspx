<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresarResultados.aspx.cs" Inherits="SIQUI.Admin.IngresarResultados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuNavegacion" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="tableleft">
        <table>
            <tr>
                <td>
                    <strong>Primero Grupo A</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGA1" runat="server" OnSelectedIndexChanged="DropDownListGA1_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo A</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGA2" runat="server" OnSelectedIndexChanged="DropDownListGA2_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
                        <tr>
                <td>
                    <strong>Primero Grupo B</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGB1" runat="server" OnSelectedIndexChanged="DropDownListGB1_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo B</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGB2" runat="server" OnSelectedIndexChanged="DropDownListGB2_SelectedIndexChanged" style="height: 20px"></asp:DropDownList>
                </td>
            </tr>
                        <tr>
                <td>
                    <strong>Primero Grupo C</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGC1" runat="server" OnSelectedIndexChanged="DropDownListGC1_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo C</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGC2" runat="server" OnSelectedIndexChanged="DropDownListGC2_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
                        
            <tr>
                <td>
                    <strong>Primero Grupo D</strong>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListGD1" runat="server" OnSelectedIndexChanged="DropDownListGD1_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo D</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGD2" runat="server" OnSelectedIndexChanged="DropDownListGD2_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>
                    <strong>Primero Grupo E</strong>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListGE1" runat="server" OnSelectedIndexChanged="DropDownListGE1_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo E</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGE2" runat="server" OnSelectedIndexChanged="DropDownListGE2_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>

                        <tr>
                <td>
                    <strong>Primero Grupo F</strong>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListGF1" runat="server" OnSelectedIndexChanged="DropDownListGF1_SelectedIndexChanged" style="height: 20px"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo F</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGF2" runat="server" OnSelectedIndexChanged="DropDownListGF2_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>

                        <tr>
                <td>
                    <strong>Primero Grupo G</strong>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListGG1" runat="server" OnSelectedIndexChanged="DropDownListGG1_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo G</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGG2" runat="server" OnSelectedIndexChanged="DropDownListGG2_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>

                        <tr>
                <td>
                    <strong>Primero Grupo H</strong>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListGH1" runat="server" OnSelectedIndexChanged="DropDownListGH1_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Segundo Grupo H</strong>
                 </td>
                <td>
                   <asp:DropDownList ID="DropDownListGH2" runat="server" OnSelectedIndexChanged="DropDownListGH2_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>

        </table>
    </div>
    
        <table>
            <tr>
                <td></td>
                <td>
                    <strong>Octavos </strong>
                </td>
            </tr>
            <tr>
                    <th rowspan="2">Octavo1</th>
                <td>
                    <asp:DropDownList ID="DropDownListO11" runat="server" OnSelectedIndexChanged="DropDownListO11_SelectedIndexChanged" style="height: 20px"></asp:DropDownList>
                </td>
                <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO1" runat="server" OnSelectedIndexChanged="DropDownListWO1_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO12" runat="server" OnSelectedIndexChanged="DropDownListO12_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>
                        <tr>
                    <th rowspan="2">Octavo2</th>
                <td>
                    <asp:DropDownList ID="DropDownListO21" runat="server" OnSelectedIndexChanged="DropDownListO21_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO2" runat="server" OnSelectedIndexChanged="DropDownListWO2_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO22" runat="server" OnSelectedIndexChanged="DropDownListO22_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>


                        <tr>
                    <th rowspan="2">Octavo3</th>
                <td>
                    <asp:DropDownList ID="DropDownListO31" runat="server" OnSelectedIndexChanged="DropDownListO31_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO3" runat="server" OnSelectedIndexChanged="DropDownListWO3_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>

            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO32" runat="server" OnSelectedIndexChanged="DropDownListO32_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>
                        <tr>
                    <th rowspan="2">Octavo4</th>
                <td>
                    <asp:DropDownList ID="DropDownListO41" runat="server" OnSelectedIndexChanged="DropDownListO41_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO4" runat="server" OnSelectedIndexChanged="DropDownListWO4_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO42" runat="server" OnSelectedIndexChanged="DropDownListO42_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                        <tr>
                    <th rowspan="2">Octavo5</th>
                <td>
                    <asp:DropDownList ID="DropDownListO51" runat="server" OnSelectedIndexChanged="DropDownListO51_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO5" runat="server" OnSelectedIndexChanged="DropDownListWO5_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO52" runat="server" OnSelectedIndexChanged="DropDownListO52_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                        <tr>
                    <th rowspan="2">Octavo6</th>
                <td>
                    <asp:DropDownList ID="DropDownListO61" runat="server" OnSelectedIndexChanged="DropDownListO61_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO6" runat="server" OnSelectedIndexChanged="DropDownListWO6_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO62" runat="server" OnSelectedIndexChanged="DropDownListO62_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                        <tr>
                    <th rowspan="2">Octavo7</th>
                <td>
                    <asp:DropDownList ID="DropDownListO71" runat="server" OnSelectedIndexChanged="DropDownListO71_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO7" runat="server" OnSelectedIndexChanged="DropDownListWO7_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO72" runat="server" OnSelectedIndexChanged="DropDownListO72_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                        <tr>
                    <th rowspan="2">Octavo8</th>
                <td>
                    <asp:DropDownList ID="DropDownListO81" runat="server" OnSelectedIndexChanged="DropDownListO81_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWO8" runat="server" OnSelectedIndexChanged="DropDownListWO8_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListO82" runat="server" OnSelectedIndexChanged="DropDownListO82_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>
        </table>
            
    <table>
         <tr>
                <td></td>
                <td>
                    <strong> Cuartos </strong>
                </td>
            </tr>

        
                        <tr>
                    <th rowspan="2">Cuartos1</th>
                <td>
                    <asp:DropDownList ID="DropDownListC11" runat="server" OnSelectedIndexChanged="DropDownListC11_SelectedIndexChanged"></asp:DropDownList>
                </td>
                            <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWC1" runat="server" OnSelectedIndexChanged="DropDownListWC1_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListC12" runat="server" OnSelectedIndexChanged="DropDownListC12_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                <tr>
                    <th rowspan="2">Cuartos2</th>
                <td>
                    <asp:DropDownList ID="DropDownListC21" runat="server" OnSelectedIndexChanged="DropDownListC21_SelectedIndexChanged"></asp:DropDownList>
                </td>
                    <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWC2" runat="server" OnSelectedIndexChanged="DropDownListWC2_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListC22" runat="server" OnSelectedIndexChanged="DropDownListC22_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                <tr>
                    <th rowspan="2">Cuartos3</th>
                <td>
                    <asp:DropDownList ID="DropDownListC31" runat="server" OnSelectedIndexChanged="DropDownListC31_SelectedIndexChanged"></asp:DropDownList>
                </td>
                    <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWC3" runat="server" OnSelectedIndexChanged="DropDownListWC3_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListC32" runat="server" OnSelectedIndexChanged="DropDownListC32_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                <tr>
                    <th rowspan="2">Cuartos4</th>
                <td>
                    <asp:DropDownList ID="DropDownListC41" runat="server" OnSelectedIndexChanged="DropDownListC41_SelectedIndexChanged"></asp:DropDownList>
                </td>
                    <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWC4" runat="server" OnSelectedIndexChanged="DropDownListWC4_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListC42" runat="server" OnSelectedIndexChanged="DropDownListC42_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>
    </table>

    <table>
        <tr>
                <td></td>
                <td>
                    <strong> Semi Finales </strong>
                </td>
            </tr>

        
                <tr>
                    <th rowspan="2">SemiFinal1</th>
                <td>
                    <asp:DropDownList ID="DropDownListS11" runat="server" OnSelectedIndexChanged="DropDownListS11_SelectedIndexChanged"></asp:DropDownList>
                </td>
                    <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWS1" runat="server" OnSelectedIndexChanged="DropDownListWS1_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListS12" runat="server" OnSelectedIndexChanged="DropDownListS12_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                    <tr>
                    <th rowspan="2">SemiFinal2</th>
                <td>
                    <asp:DropDownList ID="DropDownListS21" runat="server" OnSelectedIndexChanged="DropDownListS21_SelectedIndexChanged"></asp:DropDownList>
                </td>
                        <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWS2" runat="server" OnSelectedIndexChanged="DropDownListWS2_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListS22" runat="server" OnSelectedIndexChanged="DropDownListS22_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>
    </table>

        <table>
        <tr>
                <td></td>
                <td>
                    <strong> Finales </strong>
                </td>
            </tr>

        
                <tr>
                    <th rowspan="2">Juego Final</th>
                <td>
                    <asp:DropDownList ID="DropDownListF11" runat="server" OnSelectedIndexChanged="DropDownListF11_SelectedIndexChanged"></asp:DropDownList>
                </td>
                    <th rowspan="2">
                                <asp:DropDownList ID="DropDownListWF1" runat="server" Height="16px" OnSelectedIndexChanged="DropDownListWF1_SelectedIndexChanged"></asp:DropDownList>
                            </th>
            </tr>
            <tr>
                <th>
                    <asp:DropDownList ID="DropDownListF12" runat="server" OnSelectedIndexChanged="DropDownListF12_SelectedIndexChanged"></asp:DropDownList></th>
            </tr>

                    
            </table>

    <div align="center">
        <asp:Button ID="grabarBt" runat="server" Text="Guardar Resultados" OnClick="grabarBt_Click" />
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
