﻿function get(idcontrol) {
    return document.getElementById(idcontrol).value;
}

function set(idcontrol, valor) {
    return document.getElementById(idcontrol).value = valor;
}

function setName(namecontrol, valor) {
    return document.getElementsByName(namecontrol)[0].value = "";
}

function getName(namecontrol, valor) {
    return document.getElementsByName(namecontrol)[0].value;
}

function LimpiarDatos(idformulario) {
    var elementosName = document.querySelectorAll("#" + idformulario + " [name]");
    var elementoActual;
    var elementoName;
    for (var i = 0; i < elementosName.length; i++) {
        elementoActual = elementosName[i]
        elementoName = elementoActual.name;
        setName(elementoName, "")
    }
}

async function fetchGet(url, tiporespuesta, callback) {
    try {
        var raiz = document.getElementById("hdfOculto").value;
        //http://...
        var urlCompleta = window.location.protocol + "//" + window.location.host + "/" + raiz + url
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
function mostrar(objConfiguracion) {
    objConfiguracionGlobal = objConfiguracion;
    if (objConfiguracion.divContenedorTabla == undefined)
        objConfiguracion.divContenedorTabla = "divContenedorTabla"
    fetchGet(objConfiguracion.url, "json", function (res) {
        var contenido = "";
        contenido += "<div id='" + objConfiguracion.divContenedorTabla + "'>";
        contenido += generarTabla(res)
        document.getElementById("divTabla").innerHTML = contenido;

    })
}


function generarTabla(res) {

    var contenido = "";
    var cabeceras = objConfiguracionGlobal.cabeceras;
    var propiedades = objConfiguracionGlobal.propiedades;

    contenido += "<table class='table'>";
    contenido += "<thead>";
    contenido += "<tr>";
    for (var i = 0; i < cabeceras.length; i++) {
        contenido += "<td>" + cabeceras[i] + "</td>";
    }
    contenido += "</tr>";
    contenido += "</thead>";

    var nregistros = res.length
    var obj;
    var propiedadActual;

    contenido += "<tbody>";
    for (var i = 0; i < nregistros; i++) {
        obj = res[i]
        contenido += "<tr>";
        for (var j = 0; j < propiedades.length; j++) {
            propiedadActual = propiedades[j]
            contenido += "<td>" + obj[propiedadActual] + "</td>";
        }
        contenido += "</tr>";
    }

    contenido += "</tbody>";

    contenido += "</table>";
    return contenido;
}

async function fetchPost(url, tiporespuesta, frm, callback) {
    try {
        var raiz = document.getElementById("hdfOculto").value;
        //http://...
        var urlCompleta = window.location.protocol + "//" + window.location.host + "/" + raiz + url
        var res = await fetch(urlCompleta, {
            method: "POST",
            body: frm
        });
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