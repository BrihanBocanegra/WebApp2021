async function fetchGet(url, tiporespuesta, callback) {
    try {
        var raiz = document.getElementById("hdfOculto").value;
        //http://...
        var urlCompleta = window.location.protocol + "//" +
            window.location.host + "/" + raiz + url

        var res = await fetch(urlCompleta)
        if (tiporespuesta == "json")
            res = await res.json();
        else if (tiporespuesta == "text")
            res = await res.text();

        // JSON (Object)
        callback(res)

    } catch (e) {
        alert("Ocurrio un error");
    }
}

var objConfiguracionGlobal;

// {url:"", columnas:[], propiedades:[]}
function pintar(objConfiguracion) {
    objConfiguracionGlobal = objConfiguracion;
    fetchGet("TipoMedicamento/ListarTipoMedicamento", "json", function (res) {

        var contenido = "";
        contendido += generarTabla(res)
        document.getElementById("divTabla").innerHTML = contenido;

    })
}
