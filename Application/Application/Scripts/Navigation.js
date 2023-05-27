$(document).ready(function () {

    console.log("aa")

    $(".navBtn").on('click', function (e) {
        var url = '/Home/' + e.target.dataset.name;

        $.ajax({
            method: "POST",
            url: url,
            complete: function () {

            },
            error: function (xhr, ajaxOptions, thrownError) {
                bootstrapNotify('<i class="fa fa-exclamation-circle" aria-hidden="true"></i> Deu erro!', "danger", "top");
            },
            success: function (response) {
                $("#Content").html(response);
            }
        })
    })

    CallHomeScreem();
});

function CallHomeScreem() {

    var url = '/Home/Home';

    $.ajax({
        method: "POST",
        url: url,
        complete: function () {

        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootstrapNotify('<i class="fa fa-exclamation-circle" aria-hidden="true"></i> Deu erro!', "danger", "top");
        },
        success: function (response) {
            $("#Content").html(response);
        }
    })
}