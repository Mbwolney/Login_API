function Login() {
    var usuario = document.getElementById('inputEmail').value;
    var senha = document.getElementById('inputPassword').value;

    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            alert("Usuário logado com sucesso");
        } else if (this.readyState == 4 && this.status == 404) {
            alert("Usuário não encontrado");
        } else if (this.readyState == 4 && this.status == 401) {
            alert("Senha incorreta");
        } else if (this.readyState == 4) {
            alert("Erro no servidor");
        }
    }

    xhttp.open("POST", "http://localhost:5000/api/auth");
    xhttp.setRequestHeader('content-type', 'application/json');
    xhttp.send(JSON.stringify({ username: usuario, password: senha }));
}