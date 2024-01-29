import { Component } from '@angular/core';
import { PostComponent } from './post/post.component';
import { Post } from './post/post';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent {
  titulo:string="Ejemplo Post"
  descripcion:string="Descripcion"
    public posts:Post[]=[
      new Post(this.titulo,this.descripcion),
      new Post(this.titulo,this.descripcion),
      new Post(this.titulo,this.descripcion),
      new Post(this.titulo,this.descripcion)
    ];
}
