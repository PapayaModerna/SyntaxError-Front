<%@ Page Title="" Language="C#" MasterPageFile="~/MyHolyLib.Master" AutoEventWireup="true" CodeBehind="Recursos.aspx.cs" Inherits="SyntaxErrorWebApp.Recursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    MyHolyLib - Recursos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="<%= ResolveUrl("~/Content/recursos.css") %>" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="barra-superior">
        <asp:DropDownList ID="ddlCampana" runat="server" CssClass="form-select">
        <asp:ListItem Text="Título" Value="TITULO" />
        <asp:ListItem Text="Autor" Value="AUTOR" />
    </asp:DropDownList>
    <asp:TextBox ID="txtBusqueda" runat="server" CssClass="search-input" Placeholder="Buscar por título o autor..." />
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btnBuscar" />
    <button type="button" class="btnFiltros" onclick="toggleFiltros()">Filtros</button>
    </div>

  <!-- Repeater de libros -->
  <div class="tarjetas">
    <asp:Repeater ID="rptRecursos" runat="server">
      <ItemTemplate>
        <div class="card">
          <h4><%# Eval("Codigo") %></h4>
          <h4><%# Eval("Titulo") %></h4>
          <p><%# Eval("Autor") %></p>
          <div class="boton-container">
            <asp:Button runat="server" CssClass="btnDetalle" Text="Ver detalle"
                        OnClientClick='<%# string.Format("openModal(\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\"); return false;",
                            Eval("Titulo"),
                            Eval("Autor"),
                            Eval("Ubicacion"),
                            Eval("Disponibilidad"),
                            Eval("Descripcion"))%>' />
          </div>
        </div>
      </ItemTemplate>
    </asp:Repeater>
  </div>

  <!-- Panel de Filtros (oculto inicialmente) -->
  <div id="panelFiltros" class="panel-filtros oculto">
    <h3>Filtros</h3>
    <div class="filter-section">
      <p><strong>Temática</strong></p>
      <asp:CheckBoxList ID="chkTematica" runat="server" RepeatDirection="Vertical">
        <asp:ListItem Text="Ciencia" Value="Ciencia" />
        <asp:ListItem Text="Arte" Value="Arte" />
        <asp:ListItem Text="Historia" Value="Historia" />
        <asp:ListItem Text="Literatura" Value="Literatura" />
        <asp:ListItem Text="Música" Value="Música" />
      </asp:CheckBoxList>
    </div>

    <div class="filter-section">
      <p><strong>Nivel</strong></p>
      <asp:CheckBoxList ID="chkNivel" runat="server" RepeatDirection="Vertical">
        <asp:ListItem Text="Básico" Value="Básico" />
        <asp:ListItem Text="Intermedio" Value="Intermedio" />
        <asp:ListItem Text="Avanzado" Value="Avanzado" />
      </asp:CheckBoxList>
    </div>

    <asp:Button ID="btnFiltrar" runat="server" Text="Aplicar Filtros" OnClick="btnFiltrar_Click" CssClass="btn-aplicar-filtros" />
  </div>
  <div class="modal" id="modal" role="dialog" aria-modal="true" aria-labelledby="modal-title">
      <div class="modal-content">
        <button class="close-icon" onclick="closeModal()" aria-label="Cerrar modal">✖</button>
        <h3 id="modal-title"></h3>
        <p><strong>Autor:</strong> <span id="modal-author"></span></p>
        <p><strong>Ubicación:</strong> <span id="modal-location"></span></p>
        <p><strong>Disponibilidad:</strong> <span id="modal-copies"></span></p>
        <p><strong>Descripción:</strong> <span id="modal-description"></span></p>
        <asp:Button ID="btnSolicitarPrestamo" runat="server" CssClass="btn-solicitar"
        Text="Solicitar Préstamo"
        OnCommand="btnSolicitarPrestamo_Command"
        CommandName="Solicitar"
        CommandArgument=""
        UseSubmitBehavior="false" />
        
      </div>
    </div>  
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphScripts" runat="server">
    <script src="<%= ResolveUrl("~/Scripts/recursos.js") %>"></script>
</asp:Content>