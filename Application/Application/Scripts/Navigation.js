var insertNewPage = false;

$(document).ready(function () {
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

                if ((response + "").indexOf("simulation") != -1) {
                    $(".wsclock-btn").on('click', function () {
                        LoadWsClockPage()
                    })
                    $(".aging-btn").on('click', function () {
                        LoadAgingPage()
                    })
                }
            }
        })
    })    
    CallHomeScreem();
});

function LoadWsClockPage() {
    var url = '/Home/WsClock';

    var pagesToAdd = [];

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

            repeatSetTimeProgress();            

            $(".btnPage").on('click', function (e) {

                if (pagesToAdd.indexOf(parseInt(e.target.dataset.index)) == -1)
                    pagesToAdd.push(parseInt(e.target.dataset.index))
            })

            $(".btnInsert").on('click', function (e) {
                insertNewPage = true;
            })

            setTimeout(function () {
                UpdateWsClockList(pagesToAdd)
            }, 11000);
        }
    })
}

function LoadAgingPage() {
    var url = '/Home/Aging';

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

            $(".btnInsertAging").on('click', function (e) {
                insertNewPage = true;
            })

            $(".btnPageAging").on('click', function (e) {
                updateAging(e);                
            })
        }
    })
}

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

function setTimeProgress(progress) {
    var timeProgress = document.getElementById("progress-time");
    timeProgress.style.width = progress + "%";
}

function repeatSetTimeProgress() {
    var progress = 0;

    var interval = setInterval(function () {
        progress += 10;

        if (progress >= 100) {
            clearInterval(interval); 
        }

        setTimeProgress(progress);
    }, 1000); 
}

function UpdateWsClockList(idsToUpdate) {
    var url = '/Home/UpdateWsClockList';

    var data = {
        IdsToUpdate: idsToUpdate,
        InsertNewPage: insertNewPage
    }

    $.ajax({
        method: "POST",
        url: url,
        data: data,
        complete: function () {

        },
        error: function (xhr, ajaxOptions, thrownError) {
            //bootstrapNotify('<i class="fa fa-exclamation-circle" aria-hidden="true"></i> Deu erro!', "danger", "top");
        },
        success: function (response) {
            $("#Content").html(response);

            repeatSetTimeProgress();

            idsToUpdate = [];
            insertNewPage = false;

            $(".btnPage").on('click', function (e) {

                if (idsToUpdate.indexOf(parseInt(e.target.dataset.index)) == -1)
                    idsToUpdate.push(parseInt(e.target.dataset.index))
            })
            $(".btnInsert").on('click', function (e) {

                insertNewPage = true;
            })

            setTimeout(function () {
                UpdateWsClockList(idsToUpdate)
            }, 11000);
        }
    })
}

function updateAging(e) {
    var pagesToAdd = [];

    var PageSusceptible = $("#PageSusceptible").val();

    pagesToAdd.push(parseInt(e.target.dataset.index))

    url = '/Home/UpdateAgingList';

    var data = {
        IdsToUpdate: pagesToAdd,
        InsertNewPage: insertNewPage
    }

    $.ajax({
        method: "POST",
        url: url,
        data: data,
        complete: function () {

        },
        error: function (xhr, ajaxOptions, thrownError) {
            //bootstrapNotify('<i class="fa fa-exclamation-circle" aria-hidden="true"></i> Deu erro!', "danger", "top");
        },
        success: function (response) {
            $("#Content").html(response);

            if (insertNewPage) {
                alert("Pagina " + PageSusceptible + " subistituida!");
            }

            insertNewPage = false;

            $(".btnInsertAging").on('click', function (e) {
                insertNewPage = true;
            })

            $(".btnPageAging").on('click', function (e) {
                updateAging(e);
            })
        }
    })
}