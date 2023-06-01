function agingAlgorithm() {
    window.location.href = "/pages/aging.html";
}

function wsClockAlgorithm() {
    window.location.href = "/pages/wsclock.html";
}

function setTimeProgress(progress) {
    var timeProgress = document.getElementById("progress-time");
    timeProgress.style.width = progress + "%";
}

function repeatSetTimeProgress() {
    var progress = 0;

    var interval = setInterval(function () {
        // Atualiza o progresso
        progress += 10;

        // Verifica se o progresso atingiu 100%
        if (progress >= 100) {
            clearInterval(interval); // Limpa o intervalo quando o progresso atingir 100%
        }

        // Define o progresso na barra de tempo
        setTimeProgress(progress);
    }, 1000); // Intervalo de 1 segundo (1000 milissegundos)
}
// Chama a fun��o para repetir o setTimeProgress
repeatSetTimeProgress();
