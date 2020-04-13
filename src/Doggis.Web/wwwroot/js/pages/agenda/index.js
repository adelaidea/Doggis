$(document).ready(function () {
    var url = vars.baseUrl;

    $('#servicos-agendados').DataTable({
        "ajax": {
            "url": url + "Servico/ListarServicosAgendados",
            "dataSrc": ""
        },
        "autoWidth": false,
        "columns": [
            { "data": "ClienteNome" },
            { "data": "ServicoNome" },
            { "data": "FuncionarioNome" },
            { "data": "DataRealizacao" }
        ]
    });
});