window.onload = function () {
    listarlaboratorio();
}

function listarlaboratorio() {
    mostrar({
        url: "Laboratorio/ListarLaboratorio",
        cabeceras: ["Id", "Nombre", "Dirección", "Contacto"],
        propiedades: ["iidlaboratorio", "nombre", "direccion", "personacontacto"]
    }
    )
}