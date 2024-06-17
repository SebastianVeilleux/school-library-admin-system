using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharBiblioteca
{
    class libro
    {
        private int registro;
        private String titulo;
        private String autor;
        private String clasificacion;

        public void setRegistro(int registro)
        {
            this.registro = registro;
        }
        public int getRegistro()
        {
            return this.registro;
        }
        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }
        public String getTitulo()
        {
            return this.titulo;
        } 
        public void setAutor(String autor)
        {
            this.autor = autor;
        }
        public String getAutor()
        {
            return this.autor;
        }
        public void setClasificacion(String clasificacion)
        {
            this.clasificacion = clasificacion;
        }
        public String getClasificacion()
        {
            return this.clasificacion;
        }

    }
}
