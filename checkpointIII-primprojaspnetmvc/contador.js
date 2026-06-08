let contador = 0;

let h1Numero = document.getElementById("numero");
let btnIncrementar = document.getElementById("btnIncrementar");
let btnDecrementar = document.getElementById("btnDecrementar");
let btnZerar = document.getElementById("btnZerar");

function atualizarContador() {
  
    h1Numero.textContent = contador;

    if (contador > 0) {
        h1Numero.style.color = "green";
    } else if (contador < 0) {
        h1Numero.style.color = "red";
    } else {
        h1Numero.style.color = "black";
    }
}

btnIncrementar.addEventListener("click", function() {
    contador = contador + 1;
    atualizarContador();
});

btnDecrementar.addEventListener("click", function() {
    contador = contador - 1;
    atualizarContador();
});

btnZerar.addEventListener("click", function() {
    contador = 0;
    atualizarContador();
});
