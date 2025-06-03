<%@ Page Title="Agregar nuevo Material" Language="C#" MasterPageFile="~/BiblioMaster.Master" AutoEventWireup="true" CodeBehind="InsertarMaterial.aspx.cs" Inherits="WA_Prueba.InsertarMaterial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    Agregar nuevo Material
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <style>
        .form-container {
            width: 70%; /* Ancho más amplio */
            margin: 0 auto;
            padding: 30px; /* Aumentamos el padding para mayor espaciado */
            background-color: #f9f9f9;
            border-radius: 10px;
        }
        .form-group {
            margin-bottom: 25px; /* Aumentamos el espaciado entre los campos */
        }
        .form-control {
            width: 100%;
            padding: 12px; /* Aumentamos el padding de los controles */
            font-size: 16px; /* Aumentamos el tamaño de la fuente */
            margin-top: 8px; /* Más espacio encima de cada control */
            border-radius: 5px; /* Bordes redondeados */
        }
        .form-container .form-group .form-label {
            font-size: 20px !important;
            font-weight: bold !important;
            display: block;
            margin-bottom: 10px;
            color: #333;
        }
        button {
            margin-top: 20px;
            padding: 15px 30px; /* Aumentamos el tamaño del botón */
            font-size: 18px;
            border-radius: 5px; /* Bordes redondeados en los botones */
        }

        /* Inicialmente ocultamos las categorías, autores y sus etiquetas */
        #categorias, #autores, #categoriasLabel, #autoresLabel {
            display: none;
        }

        /* Estilo adicional para el botón Return to Detail */
        .btn-secondary {
            margin-top: 20px;
            padding: 12px 25px;
            font-size: 18px;
        }
    </style>

    <div class="form-container">
        <!-- Título y Edición -->
        <div class="form-group">
            <label for="titulo" class="form-label">Título:</label>
            <asp:TextBox ID="txtTitulo" runat="server" placeholder="Ingrese el título del material" class="form-control" />

            <label for="edicion" class="form-label">Edición:</label>
            <asp:TextBox ID="txtEdicion" runat="server" placeholder="Ingrese la edición" class="form-control" />
        </div>

        <!-- Año de publicación -->
        <div class="form-group">
            <label for="anioPublicacion" class="form-label">Año de Publicación:</label>
            <asp:DropDownList ID="ddlAnioPublicacion" runat="server" class="form-control">
            </asp:DropDownList>
        </div>

        <div class="form-group" id="nivelLabel">
            <label for="nivelIngles" class="form-label">Nivel de Inglés:</label>
            <asp:DropDownList ID="ddlNivelIngles" runat="server" class="form-control">
                <asp:ListItem Text="BASICO" Value="BASICO" />
                <asp:ListItem Text="INTERMEDIO" Value="INTERMEDIO" />
                <asp:ListItem Text="AVANZADO" Value="AVANZADO" />
            </asp:DropDownList>
        </div>

        <!-- Categorías (desplegable con múltiples opciones) -->
        <div class="form-group" id="categoriasLabel">
            <label for="categorias" class="form-label">Categorías:</label>
            <select id="categorias" class="form-control" multiple>
                <!-- Opciones de categorías aquí -->
            </select>
        </div>

        <!-- Descripción (cuadro de texto grande) -->
        <div class="form-group">
            <label for="descripcion" class="form-label">Descripción:</label>
            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" placeholder="Ingrese una descripción del material" class="form-control" />
        </div>

        <!-- Autores (desplegable con múltiples opciones) -->
        <div class="form-group" id="autoresLabel">
            <label for="autores" class="form-label">Autores:</label>
            <select id="autores" class="form-control" multiple>
                <!-- Opciones de autores aquí -->
            </select>
        </div>

        <!-- Editorial (desplegable único) -->
        <div class="form-group">
            <label for="editorial" class="form-label">Editorial:</label>
            <asp:DropDownList ID="ddlEditorial" runat="server" class="form-control">
            </asp:DropDownList>
        </div>

        <!-- Botones -->
        <div class="form-group">
            <button type="button" class="btn btn-secondary" onclick="location.href='librosPrincipal.aspx'">Return to Detail</button>
            <asp:Button ID="agregarMaterial" runat="server" CssClass="btn btn-primary" Text="Agregar" OnClick="btnAgregar_Click" />        </div>
        <div class="form-group">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Font-Bold="True" />
        </div>
    </div>

</asp:Content>

