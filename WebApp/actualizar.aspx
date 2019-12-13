<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="actualizar.aspx.cs" Inherits="WebApp.actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table border="1" id="tabla_participante">
        <tr>
            <td>Codigo</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" MaxLength="12"></asp:TextBox>
                <asp:Button ID="cmdBuscar" runat="server" Text="Buscar" OnClick="cmdBuscar_Click" />
            </td>
        </tr>
        <asp:Panel ID="pnDatos" runat="server" Visible="false">
            <tr>
            <td>Nombre</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" MaxLength="70"></asp:TextBox>
                <asp:RequiredFieldValidator class="error" ID="nombre_required" runat="server" ErrorMessage="Debe ingresar su nombre" ControlToValidate="txtNombre" EnableClientScript="False" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Fecha Inscripcion</td>
            <td>
                <asp:TextBox ID="txtFecha_inscripcion" runat="server" MaxLength="10"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Pga</td>
            <td>
                <asp:DropDownList ID="cboPga" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboPga_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Codigo de carrera</td>
            <td>
                <asp:DropDownList ID="cboCodCarrera" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboPga_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Codigo de seminario</td>
            <td>
                <asp:DropDownList ID="cboCodSeminario" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboPga_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr> 	
            <tr>
                <td><asp:Button ID="cmdModificar" runat="server" Text="Modificar" /></td>
                <td><asp:Button ID="cmdEliminar" OnClick="cmdEliminar_Click" runat="server" Text="Eliminar" /></td>
            </tr>
        </asp:Panel>
    </table>
</asp:Content>

