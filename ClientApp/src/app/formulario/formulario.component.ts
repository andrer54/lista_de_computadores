import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ComputadoresService } from '../computadores/computadores.service';



@Component({
  selector: 'formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent {
  items = this.computadoresService.getAll();
  checkoutForm = this.formBuilder.group({
    nome: '',
    marca: ''
  });
  constructor(
    private computadoresService: ComputadoresService,
    private formBuilder: FormBuilder,
    ) {}

  onSubmit(): void {
    // Process checkout data here
    //this.items = this.cartService.clearCart();

    console.warn('Your order has been submitted', this.checkoutForm.value);
    this.checkoutForm.reset();
  }
}