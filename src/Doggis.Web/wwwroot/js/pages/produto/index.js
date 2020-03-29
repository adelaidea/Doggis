$(document).ready(function () {
    var url = vars.baseUrl;

    $('#produto-lista').DataTable({
        "ajax": {
            "url": url + "Produto/Listar",
            "dataSrc": ""
        },
        "autoWidth": false,
        "columns": [
            { "data": "nome" },
            { "data": "codigo" },
            { "data": "preco" }
        ]
    });
});