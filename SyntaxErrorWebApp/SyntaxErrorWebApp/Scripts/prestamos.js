function openModal(titulo, autor, ubicacion, disponibilidad, descripcion) {
    scrollPosition = window.scrollY;

    // Guarda scroll en CSS variable y bloquea scroll con overflow hidden
    document.body.style.setProperty('--scroll-y', `${scrollPosition}px`);
    document.body.style.position = 'fixed';
    document.body.style.top = `-${scrollPosition}px`;

    // Resto de tu código
    document.getElementById("modal-title").textContent = titulo;
    document.getElementById("modal-author").textContent = autor;
    document.getElementById("modal-location").textContent = ubicacion;
    document.getElementById("modal-copies").textContent = disponibilidad;
    document.getElementById("modal-description").textContent = descripcion;

    const btn = document.getElementById('<%= btnRenovarModal.ClientID %>');
    if (btn) {
        btn.setAttribute("value", "Renovar");
        btn.setAttribute("commandargument", idPrestamo); // por compatibilidad futura
        btn.name = btn.name.replace(/(\$)?CommandArgument$/, "") + "$CommandArgument"; // hack ASP.NET
        const hiddenInput = document.createElement("input");
        hiddenInput.type = "hidden";
        hiddenInput.name = btn.name;
        hiddenInput.value = idPrestamo;
        btn.parentNode.appendChild(hiddenInput);
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
