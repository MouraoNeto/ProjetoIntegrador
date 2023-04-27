$(document).ready(function () {

    $("#saveCycle").on('click', function(){
        var url = '/Home/CreateCycles'

        $.ajax({
            method: "POST",
            url: url,
            data: $("#CycleForm").serialize(),
            complete: function () {

            },
            error: function (xhr, ajaxOptions, thrownError) {
                bootstrapNotify('<i class="fa fa-exclamation-circle" aria-hidden="true"></i> Não foi possível carregar a listagem de tipos, tente novamente.', "danger", "top");
            },
            success: function (response) {
                $("#Form").html(response);
            }
        })
    })
});