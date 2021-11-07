window.onload = function () {
    listartipomedicamento();
}

function listartipomedicamento() {

     fetchGet("TipoMedicamento/ListarTipoMedicamento", "json", function (res) {
        var nregistros = res.length;
        alert(nregistros);

        var contenido = "";
        contenido += "<table class='table'>";
        contenido += "<thead>";
        contenido += "<tr>";
        contenido += "<td> Tipo medicamento </td>";
        contenido += "<td> Nombre </td>";
        contenido += "<td> Descripción </td>";
        contenido += "<td> Precio </td>";
        contenido += "</tr>";
        contenido += "</thead>";
               
        contenido += "<tbody>";
        for (var i = 0; i < nregistros; i++) {
            obj = res[i]
            contenido += "<tr>";
            contenido += "<td>" + obj.id + "</td>";
            contenido += "<td>" + obj.nombre + "</td>";
            contenido += "<td>" + obj.descripcion + "</td>";
            contenido += "<td>" + obj.price + "</td>";
            contenido += "</tr>";
        }

        contenido += "</tbody>";
        contenido += "</table>";
        document.getElementById("divTabla").innerHTML = contenido;

     })

}