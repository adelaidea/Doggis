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
            {
                "data": "codigo",
                className: "codigo"
            },
            { "data": "preco" },
            {
                data: null,
                className: "center",
                defaultContent: '<a title="Editar" href="#" class="editar-produto"><i class="cil-pencil"></i></a> &nbsp;&nbsp;&nbsp;'
                    + '<a title="Remover" href="" class="remover-produto"><i class="cil-trash"></i></a> &nbsp;&nbsp;&nbsp;'
                    + '<a title="Alterar Quantidade" href="#" class="editar-quantidade-produto"><i class="cil-plus"></i></a> &nbsp;&nbsp;&nbsp;'
                    + '<a title="Alterar Valor" href="#" class="editar-preco-produto"><i class="cil-dollar"></i></a>'
            }
        ]
    });

    $('#produto-lista').on("click", '.editar-produto', function (e) {
        e.preventDefault();

        var codigo = $(this).parent().parent().children('.codigo').html();

        window.location = '/Produto/Edit?codigo=' + codigo;
    });

    $('#produto-lista').on("click", ".remover-produto", function (e) {
        e.preventDefault();

        if (confirm("Confirma exclusão do produto?")) {
            var codigo = $(this).parent().parent().children('.codigo').html();

            $.ajax({
                url: url + 'Produto/Remover/' + codigo,
                type: 'DELETE',
                success: function () {
                    alert("Produto excluído com sucesso.");
                    location.reload();
                },
                error: function (error) {
                    alert(error);
                }
            });
        }
    });

    $('#produto-lista').on("click", '.editar-quantidade-produto', function (e) {
        e.preventDefault();

        var codigo = $(this).parent().parent().children('.codigo').html();

        $('input[name ="alterar-quantidade-codigo"]').val(codigo);

        $("#modal-alterar-quantidade").modal();
    });

    $('#produto-lista').on("click", '.editar-preco-produto', function (e) {
        e.preventDefault();

        var codigo = $(this).parent().parent().children('.codigo').html();

        $('input[name ="alterar-preco-codigo"]').val(codigo);

        $("#modal-alterar-preco").modal();
    });

    $('#btn-salvar-alteracao-quantidade').click(function () {
        var parameter = {
            codigo: parseInt($('input[name ="alterar-quantidade-codigo"]').val()),
            quantidade: parseInt($('input[name ="alterar-quantidade-quantidade"]').val()),
        };

        $.ajax({
            url: url + 'Produto/EditarQuantidade',
            data: JSON.stringify(parameter),
            type: 'Patch',
            contentType: "application/json; charset=utf8",
            success: function () {
                alert("Quantidade alterada com sucesso.");
                location.reload();
            },
            error: function (error) {
                alert(error);
            }
        });
    });

    $('#btn-salvar-alteracao-preco').click(function () {
        var parameter = {
            codigo: parseInt($('input[name ="alterar-preco-codigo"]').val()),
            preco: parseFloat($('input[name ="alterar-preco-preco"]').val())
        };

        $.ajax({
            url: url + 'Produto/EditarPreco',
            data: JSON.stringify(parameter),
            type: 'Patch',
            contentType: "application/json; charset=utf8",
            success: function () {
                alert("Preço alterado com sucesso.");
                location.reload();
            },
            error: function (error) {
                alert(error);
            }
        });
    });
});