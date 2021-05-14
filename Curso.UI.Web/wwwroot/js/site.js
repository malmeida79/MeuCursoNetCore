function ShowLoading() {

    if ($('#dialog-ovelay-loading').length > 0)
        return;

    var content = "<div id='dialog-ovelay-loading' class='dialog-ovelay'>" +
        '<div class="dialog-loader" style="display:none"> ' +
        // '<img id="loader" src="/images/loader.gif" />' +
        '<div class="imgload">&nbsp;</div>' +
        '<span>Aguarde...</span>'
    "</div>" +
        "</div>";

    $('body').addClass('noscroll');
    $('body').prepend(content);
    $('.dialog-loader').fadeIn();
}

function HideLoading() {
    $('#dialog-ovelay-loading').fadeOut(500, function () {
        $('body').removeClass('noscroll');
        $('#dialog-ovelay-loading').remove();
    });
}

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}