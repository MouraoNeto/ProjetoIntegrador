$(document).ready(function () {
    $("#btnSave").click(function () {

        var url = '/Home/Teste'

        var x = $("#ProjectForm").serialize();

        $.ajax({
            method: "POST",
            url: url,
            data: $("#ProjectForm").serialize()
        })

    })
});