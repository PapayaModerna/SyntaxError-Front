<%@ Page Title="" Language="C#" MasterPageFile="~/MyHolyLib.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SyntaxErrorWebApp.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    MyHolyLib - Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="banner-container-grid">
        <img src="Images/ImagenFondo.jpg" class="banner-image" alt="Banner">
        <div class="banner-text">
            <h2>MyHolyLib</h2>
            <p>Este texto aparece encima de la imagen</p>
        </div>
    </div>
    <div class="section-split">
        <div class="split-left">
            <div class="clickable-box" onclick="window.location.href='Recursos.aspx'">
                <h3>RECURSOS</h3>
                <p>Explora nuestros recursos disponibles<p>
            </div>

        </div>
        <div class="split-right">
                <div id="carouselOfTops" class="carousel slide" data-bs-ride="carousel">
                     <div class="carousel-inner">
                         <div class="carousel-item active">
                             <img src="Images/Tp.jpg" class="d-block w-100" alt="Libros TPP" />
                             <div class="carousel-caption d-none d-md-block">
                                 <h5>Libros de la semana</h5>
                                 
                             </div>
                         </div>
                         <div class="carousel-item">
                             <img src="Images/NuevaColeccionAgatha.jpg" class="d-block w-100" alt="Imagen 2">
                             <div class="carousel-caption d-none d-md-block">
                                 <h5>Nueva Colección</h5>
                                 
                             </div>
                         </div>
                         <div class="carousel-item">
                             <img src="Images/MVG.jpg" class="d-block w-100" alt="Imagen 3">
                             <div class="carousel-caption d-none d-md-block">
                                 <h5>MEMORIAS</h5>
                                 
                             </div>
                         </div>
                     </div>

                     <button class="carousel-control-prev" type="button" data-bs-target="#carouselOfTops" data-bs-slide="prev">
                         <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                         <span class="visually-hidden">Previous</span>
                     </button>
                     <button class="carousel-control-next" type="button" data-bs-target="#carouselOfTops" data-bs-slide="next">
                         <span class="carousel-control-next-icon" aria-hidden="true"></span>
                         <span class="visually-hidden">Next</span>   
                     </button>
                    <div class="carousel-indicators position-absolute bottom-0 start-0  mb-3">
                        <button type ="button" data-bs-target="#carouselOfTops" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                        <button type ="button" data-bs-target="#carouselOfTops" data-bs-slide-to="1" arial-lavel="Slide 2"></button>
                        <button type ="button" data-bs-target="#carouselOfTops" data-bs-slide-to="2" arial-lavel="Slide 3"></button>
                    </div>
                 </div>
         
        </div>
    </div>
    
    <footer class="footer bg-dark text-white">
      <div class="container text-center">
        <div class="row">
          <div class="col-md-4 mb-3">
            <h5>Contacto</h5>
            <p>correo@ejemplo.com<br>+51 123 456 789</p>
          </div>
          <div class="col-md-4 mb-3">
            <h5>Enlaces útiles</h5>
            <ul class="list-unstyled">
              <li><a href="#" class="text-white">Inicio</a></li>
              <li><a href="#" class="text-white">Servicios</a></li>
              <li><a href="#" class="text-white">Reglamento</a></li>
            </ul>
          </div>
          <div class="col-md-4 mb-3">
            <h5>Redes Sociales</h5>
            <a href="#" class="text-white me-2"><i class="fab fa-facebook"></i></a>
            <a href="#" class="text-white me-2"><i class="fab fa-twitter"></i></a>
            <a href="#" class="text-white"><i class="fab fa-instagram"></i></a>
          </div>
        </div>
      </div>
    </footer>

</asp:Content>
