import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioService } from "../../services/usuario/usuario.service";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

  public usuario = new Usuario();
  public returnUrl: string;

  constructor(
    private router: Router,
    private activatedRouter: ActivatedRoute,
    private usuarioService: UsuarioService) {

  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  entrar(): void {

    this.usuarioService.verificarUsuario(this.usuario)
      .subscribe(
        data => {
        },
        err => {
        }
      );

    if (this.usuario.email == "teste@teste.com" && this.usuario.senha == "123") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    } else {

    }
  }
}
