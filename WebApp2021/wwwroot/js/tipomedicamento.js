window.onload = function () {
    listartipomedicamento();
}

function listartipomedicamento() {

     fetchGet("TipoMedicamento/ListarTipoMedicamento", "json", function (res) {
        var nregistros = res.length;

         var contenido = "";
            contenido += "<table class='table table-hover'>";
            contenido += "<thead class='table-dark'>";
            contenido += "<tr>";
            contenido += "<td width='20%'> Tipo medicamento </td>";
            contenido += "<td width='25%'> Nombre </td>";
            contenido += "<td width='45%'> Descripción </td>";
            contenido += "<td width='10%'> Precio </td>";
            contenido += "</tr>";
            contenido += "</thead>";
               
            contenido += "<tbody>";
            for (var i = 0; i < nregistros; i++) {
                obj = res[i]
                contenido += "<tr>";
                contenido += "<td>" + obj.iidtipomedicamento + "</td>";
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