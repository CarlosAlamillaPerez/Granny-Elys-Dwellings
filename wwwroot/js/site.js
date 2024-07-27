$(document).ready(function () {
    $('#showAlert').on('click', function (event) {
        event.preventDefault(); // Evita que el enlace siga su destino por defecto
        Swal.fire({
            html: $('#sweet-images').html(), // Usa el HTML del template
            showConfirmButton: false, // Opcional: oculta el botón de confirmación
            showCloseButton: true // Opcional: muestra el botón de cerrar
        });
    });
});
