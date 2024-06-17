using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharBiblioteca
{
    class alumno
    {
        private int codigo;
        private String nombre;
        private String email;
        private String carrera;

 
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return this.email;
        }
        public void setCarrera(String carrera)
        {
            this.carrera = carrera;
        }
        public String getCarrera()
        {
            return this.carrera;
        }
    }
}
