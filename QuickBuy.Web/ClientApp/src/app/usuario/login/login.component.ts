import { Component } from "@angular/core"
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;
  
  constructor(private router: Router) {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "gustavo@teste.com" && this.usuario.senha == "1234") {
      localStorage.setItem("usuario-autenticado", "1")
      //this.router.navigate(['/']);
    }
  }
}
