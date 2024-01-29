export class Post{
    private titulo:string;

    private descripcion:string;

    private enlace:string;

    constructor(titulo:string,descripcion:string){
        this.titulo=titulo;
        this.descripcion=descripcion;
        this.enlace="https://picsum.photos/200/200/?random=";
    }
    getPost(){
        this.enlace=this.enlace+ Math.floor(Math.random()*4);
        return  this.enlace
    }
}