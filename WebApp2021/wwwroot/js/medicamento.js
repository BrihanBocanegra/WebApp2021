window.onload = function () {
    listarmedicamentos();
}


function listarmedicamentos() {
    fetchGet("Medicamento/saludos", "text", function (res) {
        alert(res);

    })
    fetchGet("Medicamento/numero", "text", function (res) {
        alert(res);

    })
}

