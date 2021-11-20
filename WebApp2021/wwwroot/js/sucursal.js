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

function Buscar() {
    var nombre = document.getElementById("txtbuscarsucursal").value;
    mostrar({
        url: "Sucursal/FiltrarSucursal/?nombresucursal=" + nombre,
        cabeceras: ["Id Sucursal", "Nombre", "Dirección"],
        propiedades: ["iidsucursal", "nombre", "direccion"]
    })
}