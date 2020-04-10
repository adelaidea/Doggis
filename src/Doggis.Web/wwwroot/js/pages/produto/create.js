$(document).ready(function () {
    var url = vars.baseUrl;

    $.get(url + "Fabricante/Listar/", function (data) {
        var fabricantes = data.fabricantes;

        var selectbox = $('select[name ="fabricante"]');
        selectbox.find('option').remove();

        $('<option>').val("").text("Selecione").appendTo(selectbox);

        $.each(fabricantes, function (i, d) {
            $('<option>').val(d.id).text(d.nome).appendTo(selectbox);
        });
    });

    $('#add-produto').click(function () {
        var tr = $('#table-novos-produtos tbody tr').first();
        var trClone = $(tr).clone();

        $(trClone).find('input[name ="nome"]').val("");
        $(trClone).find('select[name ="fabricante"]').val("");
        $(trClone).find('input[name ="preco"]').val("");
        $(trClone).find('input[name ="quantidade"]').val("");
        $(trClone).find('input[name ="especificacoes"]').val("");

        $('#table-novos-produtos tbody').append(trClone);
    });

    $('#table-novos-produtos tbody').on('click', '.remover-produto', function () {
        $(this).parent().parent().remove();
    });

    $("form").submit(function (e) {
        e.preventDefault();

        var produtos = [];

        $.each($('#table-novos-produtos tbody tr'), function (i, e) {
            var produto = {
                nome: $(e).find('input[name ="nome"]').val(),
                fabricanteId: $(e).find('select[name ="fabricante"]').val(),
                preco: parseFloat($(e).find('input[name ="preco"]').val()),
                quantidade: parseInt($(e).find('input[name ="quantidade"]').val()),
                especificacoes: $(e).find('input[name ="especificacoes"]').val()
            };

            produtos.push(produto);
        });

        $.ajax({
            url: url + 'Produto/Incluir',
            data: JSON.stringify(produtos),
            type: 'Post',
            contentType: "application/json; charset=utf8",
            success: function () {
                alert("Produto(s) incluídos com sucesso.");
                window.location = '/produto'
            },
            error: function (error) {
                console.log(error);
            }
        });
    });
});