$(document).ready(function () {

    $("#ws").on('click', function () {
        var url = '/Home/CreateWsQueue'

        $.ajax({
            method: "POST",
            url: url,
            complete: function () {

            },
            error: function (xhr, ajaxOptions, thrownError) {
                bootstrapNotify('<i class="fa fa-exclamation-circle" aria-hidden="true"></i> Deu erro!', "danger", "top");
            },
            success: function (response) {
                
            }
        })
    })
});