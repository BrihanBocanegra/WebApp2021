window.onload = function () {
    listarlaboratorio();
}

function listarlaboratorio() {
    mostrar({
        url: "Laboratorio/ListarLaboratorio",
        cabeceras: ["Id", "Nombre", "Descripción", "Contacto"],
        propiedades: ["iidlaboratorio", "nombre", "descripcion", "personacontacto"]
    }
    )
}