using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCsharBiblioteca
{
    class Database
    {
        private String pathAlumno = "alumno.txt";
        private String pathLibro = "libro.txt";
        private String pathPrestamos = "prestamo.txt";
        public Database()
        {

        }


        //********************************************
        // ALUMNOS
        //********************************************

        public int getNuevoRegAlumno()
        {
            int registro = 1;
            using (StreamReader sr = File.OpenText(pathAlumno))
            {   String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null)
                {
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++)
                {
                    temp = temp2[i].Split(',');
                }
                if (temp[0] == null)
                    temp[0] = "0";
                registro = int.Parse(temp[0].ToString()) + 1;
            }
            return registro;
        }
        public void RegistrarAlumno(alumno al)
        {
            if (File.Exists(pathAlumno))
            {
                using (StreamWriter sw = new StreamWriter(pathAlumno, true))
                {
                        sw.WriteLine(al.getCodigo() + ",");
                        sw.WriteLine(al.getNombre() + ",");
                        sw.WriteLine(al.getEmail() + ",");
                        sw.WriteLine(al.getCarrera());
                        sw.WriteLine("*");
                }
            }
        }

        public alumno Buscar(alumno al, String categoria)
        {


            alumno alx = null;
            using (StreamReader sr = File.OpenText(pathAlumno))
            {
                String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null)
                {
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++)
                {
                    temp = temp2[i].Split(',');
                    if (categoria.Equals("CODIGO"))
                    {
                        if (al.getCodigo() == int.Parse(temp[0].ToString()))
                        {
                            alx = new alumno();
                            alx.setCodigo(int.Parse(temp[0].ToString()));
                            alx.setNombre(temp[1].ToString());
                            alx.setCarrera(temp[3].ToString());
                            alx.setEmail(temp[2].ToString());
                        }
                    }
                }

            }
            return alx;
        }
            


        //********************************************
        // LIBROS
        //********************************************

        public int getNuevoRegLibro()
        {
            int registro = 1;
            using (StreamReader sr = File.OpenText(pathLibro))
            {
                String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null)
                {
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++)
                {
                    temp = temp2[i].Split(',');
                }
                if (temp[0] == null)
                    temp[0] = "0";
                registro = int.Parse(temp[0].ToString()) + 1;
            }
            return registro;
        }
        public void RegistrarLibro(libro lb)
        {
            if (File.Exists(pathLibro))
            {
                using (StreamWriter sw = new StreamWriter(pathLibro, true))
                {
                    sw.WriteLine(lb.getRegistro() + ",");
                    sw.WriteLine(lb.getTitulo() + ",");
                    sw.WriteLine(lb.getAutor() + ",");
                    sw.WriteLine(lb.getClasificacion());
                    sw.WriteLine("*");
                }
            }
        }
        public libro BuscarLibro(libro  lb, String categoria)
        {
            libro lbx = null;
            using (StreamReader sr = File.OpenText(pathLibro))
            {
                String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null)
                {
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++)
                {
                    temp = temp2[i].Split(',');
                    if (categoria.Equals("REGISTRO"))
                    {
                        if (lb.getRegistro() == int.Parse(temp[0].ToString()))
                        {
                            lbx = new libro();
                            lbx.setRegistro(int.Parse(temp[0].ToString()));
                            lbx.setTitulo(temp[1].ToString());
                            lbx.setAutor(temp[2].ToString());
                            lbx.setClasificacion(temp[3].ToString());
                        }
                    }
                }

            }
            return lbx;
        }
        //********************************************
        // PRESTAMOS
        //********************************************

        public int getNuevoRegPrestamo()
        {
            int registro = 1;
            using (StreamReader sr = File.OpenText(pathPrestamos))
            {
                String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null)
                {
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++)
                {
                    temp = temp2[i].Split(',');
                }
                if (temp[0] == null)
                    temp[0] = "0";
                registro = int.Parse(temp[0].ToString()) + 1;
            }
            return registro;
        }

        public void RegistrarPrestamo(Prestamos pm)
        {
            if (File.Exists(pathPrestamos))
            {
                using (StreamWriter sw = new StreamWriter(pathPrestamos, true))
                {
                    sw.WriteLine(pm.getRegistro() + ",");
                    sw.WriteLine(pm.getCodigoAlumno() + ",");
                    sw.WriteLine(pm.getRegistroLibro() + ",");
                    sw.WriteLine(pm.getFecha_Prestamo() + ",");
                    sw.WriteLine(pm.getTituloLibro() + ",");
                    sw.WriteLine(pm.getEstadoLibro());
                    sw.WriteLine("*");
                }
            }
        }
        public List<alumno> getAlumnos()
        {   alumno al;
            List<alumno> lst = new List<alumno>();
            using (StreamReader sr = File.OpenText(pathAlumno))
            {   String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null){
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++){
                    temp = temp2[i].Split(',');
                    al = new alumno();
                    al.setCodigo(int.Parse(temp[0].ToString()));
                    al.setNombre(temp[1].ToString());
                    lst.Add(al);
                }
            }
            return lst;
        }

        public List<libro> getLibro()
        {   libro lb;
            List<libro> lst = new List<libro>();
            using (StreamReader sr = File.OpenText(pathLibro))
            {  String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null){
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++){
                    temp = temp2[i].Split(',');
                    lb = new libro();
                    lb.setRegistro(int.Parse(temp[0].ToString()));
                    lb.setTitulo(temp[1].ToString());
                    lst.Add(lb);
                }
            }
            return lst;
        }

        public Boolean getLibroPrestado(libro lb)
        {   Boolean ban = false;
            using (StreamReader sr = File.OpenText(pathPrestamos))
            {
                String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null){
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++){
                    temp = temp2[i].Split(',');
                    if (lb.getRegistro()==int.Parse(temp[1].ToString()))
                    { if (temp[5].ToString().Equals("PRESTADO")){
                            ban = true;
                        }
                    }
                }
            }
            return ban;
        }

        public Prestamos buscarPrestamo(Prestamos pm)
        {
            Prestamos pmx = null;
            using (StreamReader sr = File.OpenText(pathPrestamos))
            {
                String s, aux = "";
                String[] temp = new String[100];
                String[] temp2 = new String[100];
                while ((s = sr.ReadLine()) != null)
                {
                    aux = aux + s;
                }
                temp2 = aux.Split('*');
                for (int i = 0; i < temp2.Length - 1; i++)
                {
                    temp = temp2[i].Split(',');
                    
                        if (pm.getRegistro() == int.Parse(temp[0].ToString()))
                        {
                            pmx = new Prestamos();
                            pmx.setRegistro(int.Parse(temp[0].ToString()));
                            pmx.setCodigoAlumno(int.Parse(temp[1]));
                            pmx.setRegistroLibro(int.Parse(temp[2]));
                            pmx.setFecha_Prestamo(temp[3].ToString());
                            pmx.setEstadoLibro(temp[5].ToString());
                            pmx.setTituloLibro(temp[4].ToString());
                        }
                    
                }

            }
            return pmx;
        }

    }
}
