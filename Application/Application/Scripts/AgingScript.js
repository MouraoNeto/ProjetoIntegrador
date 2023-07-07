$(document).ready(function () {

    var pagesToAdd = [];

    $(".btnPageAging").on('click', function (e) {

        if (pagesToAdd.indexOf(parseInt(e.target.dataset.index)) == -1)
            pagesToAdd.push(parseInt(e.target.dataset.index))
    })
});