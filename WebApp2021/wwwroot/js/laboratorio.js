window.onload = function () {
    listarlaboratorio();
}

var objMostrar;

function listarlaboratorio() {
    mostrar({
        url: "Laboratorio/ListarLaboratorio",
        cabeceras: ["Id", "Nombre", "Dirección", "Contacto"],
        propiedades: ["iidlaboratorio", "nombre", "direccion", "personacontacto"],
        divContenedorTabla: "contenedor"

    })
}

function BuscarForms() {
    var form = document.getElementById("frmBusqueda");
    var frm = new FormData(form);

    fetchPost("Laboratorio/FiltrarLaboratorio", "json", frm, function (res) {
        document.getElementById("contenedor").innerHTML = generarTabla(res)
    })
}

function LimpiarForms() {
    LimpiarDatos("frmBusqueda");
    listarlaboratorio()
}