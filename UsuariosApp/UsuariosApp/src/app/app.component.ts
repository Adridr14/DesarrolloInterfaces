import { Component,inject,OnInit} from '@angular/core';
import { GetServiceService } from './get-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'UsuariosApp';
  datos:any;
  constructor(private service:GetServiceService){}
  ngOnInit():void{
      this.obtenerListado();
  }
  obtenerListado(){
    this.service.obtenerListado().subscribe(
      (data)=>{
        this.datos=data;
      },
      (error)=>{
        console.error('Error al obtener datos:',error)
      }
    );
  }
  
 
}
