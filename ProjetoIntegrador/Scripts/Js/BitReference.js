$(document).ready(function () {

    $("#saveBit").on('click', function(){
        var url = '/Home/CreateBitReference'

        $.ajax({
            method: "POST",
            url: url,
            data: $("#BitForm").serialize(),
            complete: function () {

            },
            error: function (xhr, ajaxOptions, thrownError) {
                bootstrapNotify('<i class="fa fa-exclamation-circle" aria-hidden="true"></i> Não foi possível carregar a listagem de tipos, tente novamente.', "danger", "top");
            },
            success: function (response) {
            }
        })
    })
});