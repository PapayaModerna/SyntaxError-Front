<%@ Page Title="" Language="C#" MasterPageFile="~/MyHolyLib.Master" AutoEventWireup="true" CodeBehind="MaterialInv.aspx.cs" Inherits="SyntaxErrorWebApp.MaterialInv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="container-fluid">
        <div class="row" style="height: 100vh;">
            <!-- Columna izquierda: lista de materiales -->
            <div class="col-md-4 border-end p-3 overflow-auto" style="background-color: #f8f9fa;">
                <h5>Materiales</h5>
                <ul class="list-group" id="listaMateriales">
                    <!-- Rellenado por jQuery -->
                </ul>
            </div>

            <!-- Columna derecha: detalle -->
            <div class="col-md-8 p-4" id="detalleMaterial">
                <div class="text-center text-muted">Selecciona un material para ver detalles</div>
            </div>
        </div>
    </div>
</asp:Content>
