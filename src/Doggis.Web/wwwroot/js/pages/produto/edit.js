$(document).ready(function () {
    var url = vars.baseUrl;

    var urlParams = new URLSearchParams(window.location.search);
    var codigo = urlParams.get('codigo');

    $.get(url + "Fabricante/Listar/", function (data) {
        var fabricantes = data.fabricantes;

        var selectbox = $('select[name ="fabricante"]');
        selectbox.find('option').remove();

        $.each(fabricantes, function (i, d) {
            $('<option>').val(d.id).text(d.nome).appendTo(selectbox);
        });
    });

    $.get(url + "Produto/Obter/" + codigo, function (data) {
        var produto = data.produto;
        $('input[name ="codigo"]').val(produto.codigo);
        $('input[name ="nome"]').val(produto.nome);
        $('select[name ="fabricante"]').val(produto.fabricanteId);
        $('input[name ="preco"]').val(produto.preco);
        $('input[name ="quantidade"]').val(produto.quantidade);
        $('textarea[name ="especificacoes"]').val(produto.especificacoes);
    });

    $("form").submit(function (e) {
        e.preventDefault();

        var produto = {
            codigo: parseInt($('input[name ="codigo"]').val()),
            nome: $('input[name ="nome"]').val(),
            fabricanteId: $('select[name ="fabricante"]').val(),
            preco: parseFloat($('input[name ="preco"]').val()),
            quantidade: parseInt($('input[name ="quantidade"]').val()),
            especificacoes: $('textarea[name ="especificacoes"]').val()
        };

        $.ajax({
            url: url + 'Produto/Editar',
            data: JSON.stringify(produto),
            type: 'Put',
            contentType: "application/json; charset=utf8",
            success: function () {
                alert("Produto excluído com sucesso.");
                window.location = '/produto'
            },
            error: function (error) {
                alert(error);
            }
        });
    });
});