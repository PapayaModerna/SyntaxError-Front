<%@ Page Title="" Language="C#" MasterPageFile="~/MyHolyLib.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="SyntaxErrorWebApp.Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    MyHolyLib - Reservas
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="<%= ResolveUrl("~/Content/reservas.css") %>" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="Cabecera">
        Mis Reservas
    </div>
    <div class="tarjetas">
  <asp:Repeater ID="rptReservas" runat="server">
    <ItemTemplate>
      <div class="card">
        <h4><%# Eval("Titulo") %></h4>
        <p><strong>Autor:</strong> <%# Eval("Autor") %></p>
        <p><strong>Fecha de préstamo:</strong> <%# Eval("FechaPrestamo", "{0:dd/MM/yyyy}") %></p>
        <p><strong>Fecha de devolución:</strong> <%# Eval("FechaDevolucion", "{0:dd/MM/yyyy}") %></p>
        
        <div class="boton-container doble-boton">
          <!-- Botón de renovar -->
          <asp:Button runat="server" CssClass="btnCancelarSolicitud" Text="Cancelar"
                      CommandName="Cancelar"
                      CommandArgument='' 
                      OnCommand="btnCancelarSolicitud" />
          
          <!-- Botón de ver detalle (abre modal) -->
          <asp:Button runat="server" CssClass="btnDetalle" Text="Ver detalle"
                      OnClientClick='<%# string.Format("openModal(\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\"); return false;",
                          Eval("Titulo"),
                          Eval("Autor"),
                          Eval("Ubicacion"),
                          Eval("Disponibilidad"),
                          Eval("Descripcion")) %>' />
        </div>
      </div>
    </ItemTemplate>
  </asp:Repeater>
  <!-- Modal reutilizado -->
<div class="modal" id="modal" role="dialog" aria-modal="true" aria-labelledby="modal-title">
  <div class="modal-content">
    <button class="close-icon" onclick="closeModal()" aria-label="Cerrar modal">✖</button>
    <h3 id="modal-title"></h3>
    <p><strong>Autor:</strong> <span id="modal-author"></span></p>
    <p><strong>Ubicación:</strong> <span id="modal-location"></span></p>
    <p><strong>Disponibilidad:</strong> <span id="modal-copies"></span></p>
    <p><strong>Descripción:</strong> <span id="modal-description"></span></p>
    <asp:Button ID="btnRenovarModal" runat="server" CssClass="btnRenovar"
      Text="Renovar"
      OnCommand="btnRenovar_Command"
      CommandName="Renovar"
      CommandArgument=""
      UseSubmitBehavior="false" />
  </div>
</div>
</div>
    <asp:Label ID="lblSinReservas" runat="server" Text="No tienes reservas registradas." Visible="false" CssClass="alert alert-info" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphScripts" runat="server">
</asp:Content>
