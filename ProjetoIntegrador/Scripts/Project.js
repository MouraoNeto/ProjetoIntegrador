$(document).ready(function () {
    $("#btnSave").click(function () {

        var url = '/Home/CreateForm'

        var x = $("#ProjectForm").serialize();

        $.ajax({
            method: "POST",
            url: url,
            data: $("#ProjectForm").serialize()
        })

    })
});