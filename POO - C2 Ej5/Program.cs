using System;

namespace POO___C2_Ej5
{
    class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        
        public String Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public String Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public String Ubicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                ubicacion = value;
            }
        }
        static void Main(string[] args)
        {
            Libro milibro = new Libro();

            milibro.autor = "JK Rowling";
            milibro.titulo = "Harry Potter y la Camara Secreta";
            milibro.ubicacion = "F29";

            Console.WriteLine("Autor: {0} del Libro {1} está en {2}",milibro.autor,milibro.titulo,milibro.ubicacion);
        }
    }
}
