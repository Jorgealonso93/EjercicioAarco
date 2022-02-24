<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Cotizaciones.aspx.vb" Inherits="AarcoEjercicioCotizacionAutos.Cotizaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <H2>Vehiculos</H2>
    <hr style="width:75%;">
    <div class="form-group">
        <label for="lblMarca" class="control-label col-md-2">Marca :</label>
        <div>
            <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <label for="lblSubMarca" class="control-label col-md-2">SubMarca :</label>
        <div>
            <asp:DropDownList ID="ddlSubMarca" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <label for="lblModelo" class="control-label col-md-2">Modelo :</label>
        <div>
            <asp:DropDownList ID="ddlModelo" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <label for="lblDescripcion" class="control-label col-md-2">Descripcion :</label>
        <div>
            <asp:DropDownList ID="ddlDescripcion" runat="server"></asp:DropDownList>
        </div>
    </div>
    <h2>domicilio</h2>
    <hr style="width:75%;">
    <div class="form-group">
        <label for="lblCodigoP" class="control-label col-md-2">CODIGO postal :</label>
        <div>
            <asp:TextBox ID="txtCP" runat="server" placeholder="Codico Postal"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="lblEstado" class="control-label col-md-2">Estado :</label>
        <div>
            <asp:TextBox ID="txtEstado" runat="server" placeholder="Estado"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="lblMunicipio" class="control-label col-md-2">MUNICIPIO :</label>
        <div>
            <asp:TextBox ID="txtMunicipio" runat="server" placeholder="Municipio"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="lblColonia" class="control-label col-md-2">COLONIA :</label>
        <div>
            <asp:TextBox ID="txtColonia" runat="server" placeholder="Colonia"></asp:TextBox>
        </div>
    </div>
    <h2>Persona</h2>
    <hr />
    <div class="form-group">
        <label for="lblFNAc" class="control-label col-md-2">FECHA NACIMIENTO :</label>
        <div>
            <asp:TextBox ID="txtFNac" runat="server" placeholder="" TextMode="DateTime"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="lblGenero" class="control-label col-md-2">GENERO :</label>
        <div>
            <asp:DropDownList ID="ddlGenero" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <div>
            <asp:Button ID="btnCotizar" runat="server" Text="COTIZAR" />
        </div>
    </div>
</asp:Content>
