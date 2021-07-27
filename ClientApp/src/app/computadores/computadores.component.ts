import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ComputadoresService } from './computadores.service';

@Component({
  selector: 'computadores',
  templateUrl: './computadores.component.html'
})
export class ComputadoresComponent {
  public computadores: Computadores[];

  public computadorForm: FormGroup;
  public computadorSelecionado: Computadores;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Computadores[]>(baseUrl + 'api/computador').subscribe(result => {
      this.computadores = result;
    }, error => console.error(error));
  }


  /*
  criarForm() {
     this.computadorForm = this.fb.group({
      id: [0],
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      telefone: ['', Validators.required]
    });
  }
  */
    alunoSelect(computador: Computadores) {
    //this.modeSave = 'put';
    this.computadorSelecionado = computador;
    this.computadorForm.patchValue(computador);
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
