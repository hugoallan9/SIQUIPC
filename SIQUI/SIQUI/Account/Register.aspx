<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SIQUI.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h3>Por completa el formulario.</h3>
    </hgroup>

    <asp:CreateUserWizard runat="server" ID="RegisterUser" ViewStateMode="Disabled" OnCreatedUser="RegisterUser_CreatedUser">
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="wizardStepPlaceholder" />
            <asp:PlaceHolder runat="server" ID="navigationPlaceholder" />
        </LayoutTemplate>
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" ID="RegisterUserWizardStep">
                <ContentTemplate>
                    <p class="message-info">
                        Las constraseñas tienen una longitud mínima de <%: Membership.MinRequiredPasswordLength %>  caracteres.
                    </p>

                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <fieldset>
                        <legend>Forma de Registro</legend>
                        <ol>
                            <li>
                                <asp:Label  runat="server" AssociatedControlID="FirstName" Text="Nombre"></asp:Label>
                                <asp:TextBox runat="server" ID="FirstName"/>
                                <asp:RequiredFieldValidator runat ="server" ControlToValidate="FirstName"
                                    CssClass="field-validation-error" ErrorMessage="Este campo es obligatorio." />
                                   
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="LastName" Text="Apellido"></asp:Label>
                                <asp:TextBox runat="server" ID="LastName" />
                                <asp:RequiredFieldValidator  runat ="server" ControlToValidate="LastName"
                                    CssClass="field-validation-error" ErrorMessage="Este campo es obligatorio." />
                            </li>
                            <li> 
                                <asp:Label runat="server" AssociatedControlID="Nacionalidad" Text="País de Origen"></asp:Label>
                                <asp:TextBox runat="server" ID="Nacionalidad"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Nacionalidad"
                                    CssClass="field-validation-error" ErrorMessage="Este campo es obligatorio" />
                            </li>

                            <li>
                                <asp:Label runat="server" AssociatedControlID="UserName">Nombre de Usuario</asp:Label>
                                <asp:TextBox runat="server" ID="UserName" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                    CssClass="field-validation-error" ErrorMessage="Este campo es obligatorio." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Email">Correo Electrónico</asp:Label>
                                <asp:TextBox runat="server" ID="Email" TextMode="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                    CssClass="field-validation-error" ErrorMessage="Este campo es obligatorio." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Password">Contraseña</asp:Label>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="Este campo es obligatorio" />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirma tu Constraseña</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Este campo es obligatorio" />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="No coinciden tus contraseñas" />
                            </li>
                            <p>
                                <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Pregunta de Seguridad:</asp:Label>
                                <asp:TextBox ID="Question" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question"
                                    CssClass="failureNotification" ErrorMessage="La pregunta de seguridad es requerida." ToolTip="La pregunta de seguridad es requerida."
                                    ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">Respuesta de Seguridad:</asp:Label>
                                <asp:TextBox ID="Answer" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer"
                                    CssClass="failureNotification" ErrorMessage="La respuesta de seguridad es requerida." ToolTip="La respuesta de seguridad es requerida."
                                    ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                        </ol>
                        <asp:Button runat="server" CommandName="MoveNext" Text="Regístrame" />
                    </fieldset>
                </ContentTemplate>
                <CustomNavigationTemplate />
            </asp:CreateUserWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
</asp:Content>