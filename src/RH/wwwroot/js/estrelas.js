function carregaEstrelas() {
    //document.title = Date();

    rows = $('#tableConhecimentos > tbody > tr');
    //alert(rows.length);
    for (i = 0; i < rows.length; i++) {
        b1 = $(rows[i]).find("#b1");
        //$(b1).css("background-color", "red");
        $(b1).click();
    }
}

function acendeapaga(span, numero) {
    //alert(estrela.title);  o numero da estrela selecionada vem do title do span
    numero = parseInt(numero);  //  alert(numero + 1 -1);
    old = $(span).children().next('input').first().val();

    if (!isNaN(old) & !isNaN(numero) & old != numero) {
        //alert(old + " " + numero);
        $(span).children().next('input').first().val(numero).change();
    }

    zero = "&#9988;";
    estrelaapagada = "&star;";
    estrelaacesa = "&starf;";

    estrelas = $(span).children();
    // limpa as estrelas
    for (var i = 0; i < estrelas.length; i++) {
        $(estrelas[i + 1]).html('&star;');
        $(estrelas[i + 1]).css('color', 'dimgray');
    }

    // acende as estrelas ate o numero i
    for (var i = 0; i < numero; i++) {
        $(estrelas[i + 1]).html('&starf;');
        $(estrelas[i + 1]).css('color', 'darkorange');
    }
}