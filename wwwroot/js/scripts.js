// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function setTimeProgress(progress) {
    var timeProgress = document.getElementById("progress-time");
    timeProgress.style.width = progress + "%";
}

function repeatSetTimeProgress() {
    var progress = 0;
    
    var interval = setInterval(function() {
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
  // Chama a função para repetir o setTimeProgress
repeatSetTimeProgress();
