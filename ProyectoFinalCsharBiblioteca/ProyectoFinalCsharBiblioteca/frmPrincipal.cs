using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalCsharBiblioteca
{
    public partial class frmPrincipal : Form
    {
        private Database db;
        private alumno al;
        private libro lb;
        private Prestamos pm;
        private Boolean btnBuscarRgClicked;


        List<alumno> lstalumno;
        List<libro> lstlibro;

        
        public frmPrincipal()
        {
            InitializeComponent();
            db = new Database();//creamos el objeto de base de datos
            lstalumno = db.getAlumnos();
            foreach (alumno x in lstalumno )
            {
                cbCodigoAlumnoRg.Items.Add(x.getCodigo());
            }
            lstlibro = db.getLibro();
            foreach (libro x in lstlibro)
            {
                cbRegistroLibroRg.Items.Add(x.getRegistro());
            }
        }

        public void limpiarCajasAl()
        {
            cbOpcionAl.SelectedIndex = -1;
            txtDatoAl.Text = null;
            txtCodigoAl.Text = null;
            txtNombreAl.Text = null;
            txtEmailAl.Text = null;
            cbCarreraAl.SelectedIndex = -1;
        }

        public void limpiarCajasLi()
        {
            cbOpcionLb.SelectedIndex = -1;
            txtDatoLb.Text = null;
            txtRegistroLb.Text = null;
            txtTitulo.Text = null;
            txtAutorLb.Text = null;
            cbClasificacionLb.SelectedIndex = -1;
        }

        public void limpiarCajasRg()
        {
            txtDatoRg.Text = null;
            txtRestroRg.Text = null;
            cbCodigoAlumnoRg.SelectedIndex = -1;
            txtTituloRg.Text = "";
            cbEstadoLibroRg.SelectedIndex = -1;
        }

        private void btnGuardarAl_Click(object sender, EventArgs e)
        {
            al = new alumno();//creamos el objeto alumno
            al.setCodigo(int.Parse(txtCodigoAl.Text));
            al.setNombre(txtNombreAl.Text);
            al.setCarrera(cbCarreraAl.Text);
            al.setEmail(txtEmailAl.Text);
            db.RegistrarAlumno(al);// enviamos el objeto a escribir
            MessageBox.Show("Registro creado");
            limpiarCajasAl();
        }

        private void btnNuevoAl_Click(object sender, EventArgs e)
        {
            limpiarCajasAl();
            txtCodigoAl.Text = db.getNuevoRegAlumno().ToString();
        }

        private void btnBuscarAl_Click(object sender, EventArgs e)
        {
            try
            {
                al = new alumno();// creamos el objeto
                al.setCodigo(int.Parse(txtDatoAl.Text));
                al = db.Buscar(al, cbOpcionAl.Text);
                txtCodigoAl.Text = al.getCodigo().ToString();
                txtNombreAl.Text = al.getNombre();
                txtEmailAl.Text = al.getEmail();
                cbCarreraAl.SelectedItem = al.getCarrera();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no existe");
            }
           
        }

        private void btnNuevoLb_Click(object sender, EventArgs e)
        {
            limpiarCajasLi();
            txtRegistroLb.Text = db.getNuevoRegLibro().ToString();
        }

        private void btnGuardarLb_Click(object sender, EventArgs e)
        {
            try
            {
                lb=new libro();
                lb.setRegistro(int.Parse(txtRegistroLb.Text));
                lb.setTitulo(txtTitulo.Text);
                lb.setAutor(txtAutorLb.Text);
                lb.setClasificacion(cbClasificacionLb.Text);
                db.RegistrarLibro(lb);
                MessageBox.Show("Registro creado");
                limpiarCajasLi();
            }catch(Exception ex)
            {
                MessageBox.Show("Error en el registro");
            }
            
        }

        private void btnBuscarLb_Click(object sender, EventArgs e)
        {
            try
            {
                lb = new libro();
                lb.setRegistro(int.Parse(txtDatoLb.Text));
                lb = db.BuscarLibro(lb, cbOpcionLb.Text);
                txtRegistroLb.Text = lb.getRegistro().ToString();
                txtTitulo.Text = lb.getTitulo();
                txtAutorLb.Text = lb.getAutor();
                cbClasificacionLb.SelectedItem = lb.getClasificacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no existe");
            }
          
        }

        private void cbCodigoAlumnoRg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRegistroLibroRg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                lb = new libro();
                lb.setRegistro(int.Parse(cbRegistroLibroRg.Text));
                Boolean ban = db.getLibroPrestado(lb);
                if (ban == false)
                {
                    txtTituloRg.Text = lstlibro[cbRegistroLibroRg.SelectedIndex].getTitulo();
                }
                else
                {
                    MessageBox.Show("Libro prestado");
                    txtTituloRg.Text = null;
                }
            
            
        }

        private void btnNuevoRg_Click(object sender, EventArgs e)
        {
            limpiarCajasRg();
            txtRestroRg.Text = db.getNuevoRegPrestamo().ToString();
        }

        private void btnGuardarRg_Click(object sender, EventArgs e)
        {
            try
            {
                pm = new Prestamos();
                pm.setRegistro(int.Parse(txtRestroRg.Text));
                pm.setCodigoAlumno(int.Parse(cbCodigoAlumnoRg.Text));
                pm.setRegistroLibro(int.Parse(cbRegistroLibroRg.Text));
                pm.setFecha_Prestamo(dtpFechaRg.Text);
                pm.setEstadoLibro(cbEstadoLibroRg.Text);
                pm.setTituloLibro(txtTituloRg.Text);
                db.RegistrarPrestamo(pm);
                MessageBox.Show("Registro creado");
                limpiarCajasRg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btnCancelarAl_Click(object sender, EventArgs e)
        {
            limpiarCajasAl();
        }

        private void btnCancelarLb_Click(object sender, EventArgs e)
        {
            limpiarCajasLi();
        }

        private void btnCancelarRg_Click(object sender, EventArgs e)
        {
            limpiarCajasRg(); 
        }

        private void btnBuscarRg_Click(object sender, EventArgs e)
        {
            try
            {
                pm = new Prestamos();
                pm.setRegistro(int.Parse(txtDatoRg.Text));
                pm= db.buscarPrestamo(pm);
                cbRegistroLibroRg.Text= pm.getRegistroLibro().ToString();
                cbCodigoAlumnoRg.Text = pm.getCodigoAlumno().ToString();
                txtTituloRg.Text=pm.getTituloLibro();
                cbEstadoLibroRg.Text=pm.getEstadoLibro();
                btnBuscarRgClicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no existe");
            }

        }
    }
}
