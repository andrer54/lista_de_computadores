import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './computadores.component.html'
})
export class ComputadoresComponent {
  public computadores: Computadores[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Computadores[]>(baseUrl + 'api/computador').subscribe(result => {
      this.computadores = result;
    }, error => console.error(error));
  }
}

interface Computadores {
    id : number,
  marca : string,
  modelo : string,
  placa_mae : string,
  ram : string,
  hdEMarca : string,
  velocidadeDoProcessador : string,
  imagem : string,
}
