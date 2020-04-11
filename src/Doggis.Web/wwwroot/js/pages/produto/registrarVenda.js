$(document).ready(function () {
    var url = vars.baseUrl;

    $('#btn-add-produto').click(function () {
        var codigo = $('input[name= "codigo-produto"]').val();
        $.get(url + "Produto/Obter/" + codigo, function (data) {
            var produto = data.produto;

            if (data.produto !== null) {
                var quantidade = $('input[name = "quantidade-produto-venda"]').val();

                if (!(parseInt(quantidade) > produto.quantidade)) {

                    var tbody = $('#tabela-produto-venda tbody');

                    var tr = $('<tr>');
                    $('<td>').addClass('d-none').addClass('codigo').text(produto.codigo).appendTo(tr);
                    $('<td>').text(produto.nome).appendTo(tr);
                    $('<td>').text(quantidade).addClass('quantidade').appendTo(tr);

                    var inputPreco = $('<input>').addClass('form-control').addClass('preco').attr('type', 'text').val(produto.preco);
                    var tdPreco = $('<td>').append(inputPreco);
                    $(tdPreco).appendTo(tr);

                    $('<td>').addClass('preco-produtos').text(getPrecoTotalProdutos(produto.preco, quantidade)).appendTo(tr);

                    tbody.prepend(tr);

                    $('#tabela-produto-venda tbody td.valor-total').text(getPrecoTotalVenda());
                }
                else {
                    alert("Quantidade de produtos disponíveis é inferior ao desejado.");
                }
            }
            else
                alert("O produto informado não existe.");
        });
    });

    $('#tabela-produto-venda tbody').on('change', 'input.preco', function () {
        var tr = $(this).parent().parent();

        var quantidade = $(tr).find('td.quantidade').text();

        $(tr).find('td.preco-produtos').text(getPrecoTotalProdutos($(this).val(), quantidade));
        $('#tabela-produto-venda tbody td.valor-total').text(getPrecoTotalVenda());
    });

    $("form").submit(function (e) {
        e.preventDefault();

        var itens = [];

        var linhas = $('#tabela-produto-venda tbody tr');
        for (var i = 0; i < linhas.length - 1; i++) {
            var linha = linhas[i];

            var item = {
                codigoProduto: parseInt($(linha).find('td.codigo').text()),
                valorItem: parseFloat($(linha).find('input.preco').val()),
                quantidade: parseInt($(linha).find('td.quantidade').text())
            };

            itens.push(item);
        }

        var parameter = {
            IdFuncionario: '57ADB312-34FA-4483-B119-86B1082060D8',
            itens: itens
        };

        $.ajax({
            url: url + 'Produto/RegistrarVenda',
            data: JSON.stringify(parameter),
            type: 'Post',
            contentType: "application/json; charset=utf8",
            success: function () {
                alert("Venda registrada com sucesso.");
                location.reload();
            },
            error: function (error) {
                console.log(error);
            }
        });
    });
});

function getPrecoTotalProdutos(precoUnitario, quantidade) {

    return (precoUnitario * quantidade).toFixed(2);
};

function getPrecoTotalVenda() {
    var result = 0;
    $('#tabela-produto-venda tbody td.preco-produtos').each(function (i, e) {
        result += parseFloat($(e).text());
    });

    return result.toFixed(2);
};