let formulario = document.getElementById("meuFormulario");


formulario.addEventListener("submit", function(event) {
    

    let campoNome = document.getElementById("nome");
    let campoEmail = document.getElementById("email");
    let campoIdade = document.getElementById("idade");
    
   
    let paragrafoErro = document.getElementById("erro");
    
   
    let nomeValue = campoNome.value;
    let emailValue = campoEmail.value;
    let idadeValue = campoIdade.value;
    
   
    let erroEncontrado = false;
    let mensagemDeErro = "";

   
    if (nomeValue === "") {
        mensagemDeErro = "O campo Nome não pode estar vazio!";
        erroEncontrado = true;
    }

    else if (emailValue.indexOf("@") === -1) {
        mensagemDeErro = "O e-mail digitado precisa conter o caractere '@'.";
        erroEncontrado = true;
    }

    else if (idadeValue === "" || Number(idadeValue) <= 0) {
        mensagemDeErro = "A idade digitada precisa ser maior do que 0!";
        erroEncontrado = true;
    }

  
    if (erroEncontrado === true) {

        event.preventDefault();
        
     
        paragrafoErro.textContent = mensagemDeErro;
        paragrafoErro.style.color = "red";
    } else {
       
        event.preventDefault();
        
        paragrafoErro.textContent = "Cadastro concluído e enviado com sucesso!";
        paragrafoErro.style.color = "green";
        
        campoNome.value = "";
        campoEmail.value = "";
        campoIdade.value = "";
    }
});
