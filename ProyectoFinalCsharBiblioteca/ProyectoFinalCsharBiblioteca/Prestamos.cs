using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharBiblioteca
{
    class Prestamos
    {
        private int registro;
        private int codigoAlumno;
        private int registrolibro;
        private String fecha_prestamo;
        private String titulo_libro;
        private String estadoLibro;

        public void setRegistro(int registro)
        {
            this.registro = registro;
        }
        public int getRegistro()
        {
            return this.registro;
        }
        public void setCodigoAlumno(int codigoAlumno)
        {
            this.codigoAlumno = codigoAlumno;
        }
        public int getCodigoAlumno()
        {
            return this.codigoAlumno;
        }
        public void setRegistroLibro(int registrolibro)
        {
            this.registrolibro = registrolibro;
        }
        public int getRegistroLibro()
        {
            return this.registrolibro;
        }
        public void setFecha_Prestamo(String fecha_prestamo)
        {
            this.fecha_prestamo = fecha_prestamo;
        }
        public String getFecha_Prestamo()
        {
            return this.fecha_prestamo;
        }
        public void setEstadoLibro(String estadoLibro)
        {
            this.estadoLibro = estadoLibro;
        }
        public String getEstadoLibro()
        {
            return this.estadoLibro;
        }
        
        public void setTituloLibro(String titulo_libro)
        {
            this.titulo_libro = titulo_libro;
        }
        public String getTituloLibro()
        {
            return this.titulo_libro;
        }

    }
}
