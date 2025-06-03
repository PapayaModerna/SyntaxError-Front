function openModal(titulo, autor, ubicacion, disponibilidad, descripcion) {
    scrollPosition = window.scrollY;

    document.body.style.setProperty('--scroll-y', `${scrollPosition}px`);
    document.body.style.position = 'fixed';
    document.body.style.top = `-${scrollPosition}px`;

    document.getElementById("modal-title").textContent = titulo;
    document.getElementById("modal-author").textContent = autor;
    document.getElementById("modal-location").textContent = ubicacion;
    document.getElementById("modal-copies").textContent = disponibilidad;
    document.getElementById("modal-description").textContent = descripcion;

    const btnSolicitar = document.getElementById('<%= btnSolicitarPrestamo.ClientID %>');
    if (btnSolicitar) {
        btnSolicitar.name = btnSolicitar.name.replace(/(\$)?CommandArgument$/, "") + "$CommandArgument";
        const hiddenInput = document.createElement("input");
        hiddenInput.type = "hidden";
        hiddenInput.name = btnSolicitar.name;
        hiddenInput.value = idPrestamo;
        btnSolicitar.parentNode.appendChild(hiddenInput);
    }
    document.getElementById("modal").style.display = "block";
}

function closeModal() {
    const scrollY = document.body.style.getPropertyValue('--scroll-y');
    document.getElementById("modal").style.display = "none";
    document.body.style.position = '';
    document.body.style.top = '';
    window.scrollTo(0, parseInt(scrollY || '0') * -1);
}

// Toggle filter sections con jQuery
function initToggleButtons() {
    const toggleButtons = $('.toggle-btn');

    toggleButtons.off('click').on('click', function () {
        const btn = $(this);
        const content = btn.next('.filter-options');
        const isExpanded = btn.toggleClass('expanded').hasClass('expanded');

        btn.attr('aria-expanded', isExpanded);
        content.attr('aria-hidden', !isExpanded);

        if (isExpanded) {
            // Para abrir: max-height al scrollHeight
            content.css('max-height', content.prop('scrollHeight') + "px");
        } else {
            // Para cerrar: primero max-height al scrollHeight para iniciar la transición
            content.css('max-height', content.prop('scrollHeight') - "px");

        }
    });
}


// Ejecutar al cargar la página y también tras postbacks parciales en ASP.NET
$(document).ready(function () {
    initToggleButtons();
});

if (typeof Sys !== "undefined" && Sys.Application) {
    Sys.Application.add_load(initToggleButtons);
}
function toggleFiltros() {
    const panel = document.getElementById("panelFiltros");
    panel.classList.toggle("oculto");
}