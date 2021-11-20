window.onload = function () {
    listarsucursal();
}

function listarsucursal() {
    mostrar({
        url: "Sucursal/ListarSucursal",
        cabeceras: ["Id Sucursal", "Nombre", "Dirección"],
        propiedades: ["iidsucursal", "nombre", "direccion"]
    }
    )
}