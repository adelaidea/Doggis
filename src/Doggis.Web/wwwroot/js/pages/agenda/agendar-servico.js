$(document).ready(function () {
    var url = vars.baseUrl;

    $.get(url + "Cliente/Listar/", function (data) {
        var clientes = data.clientes;

        var selectbox = $('select[name ="cliente"]');

        $.each(clientes, function (i, d) {
            $('<option>').val(d.id).text(d.nome).appendTo(selectbox);
        });
    });

    $.get(url + "Servico/Listar/", function (data) {
        var servicos = data.servicos;

        var selectbox = $('select[name ="servico"]');

        $.each(servicos, function (i, d) {
            $('<option>').val(d.id).text(d.nome).appendTo(selectbox);
        });
    });

    $('select[name ="cliente"]').change(function () {
        var selectbox = $('select[name ="pet"]');
        selectbox.find('option').remove();

        if ($(this).val() !== "") {
            $.get(url + "Pet/ListarPetsPorCliente?clienteId=" + $(this).val(), function (data) {
                var pets = data.pets;

                $.each(pets, function (i, d) {
                    $('<option>').val(d.id).attr("data-tipo-pet", d.tipoPetId).text(d.nome).appendTo(selectbox);
                });
            });
        }
    });

    $('select[name ="pet"]').change(function () {
        PreencherComboProfissional(url);
    });

    $('select[name ="servico"]').change(function () {
        PreencherComboProfissional(url);
    });
});

function PreencherComboProfissional(url) {
    var selectbox = $('select[name ="profissional"]');
    selectbox.find('option').remove();

    var tipoPet = $('select[name ="pet"]').find(':selected').data('tipo-pet');
    var servico = $('select[name ="servico"]').val();

    if (tipoPet !== "" && servico !== "") {
        $.get(url + "Funcionario/ListarFuncionarioPorTipoPetEServico?tipoPetId=" + tipoPet + "&servicoId=" + servico, function (data) {
            var funcionarios = data.funcionarios;

            $.each(funcionarios, function (i, d) {
                $('<option>').val(d.id).text(d.nome).appendTo(selectbox);
            });
        });
    }
};