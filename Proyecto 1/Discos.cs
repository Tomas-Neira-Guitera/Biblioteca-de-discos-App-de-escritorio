using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using conexionBDD;

namespace Proyecto_1
{
    public partial class FormDiscos : Form
    {
        public FormDiscos()
        {
            InitializeComponent();
        }

        private List<Disco> listaDiscos;
        
        private void FormDiscos_Load(object sender, EventArgs e)
        {

            cargarForm();


        }

        private void cargarForm() 
        {
            pictureBoxFondo.Load("https://e0.pxfuel.com/wallpapers/2/356/desktop-wallpaper-dark-space.jpg");
            DiscoConexion conexion = new DiscoConexion();
            listaDiscos = conexion.listar();
            dataGridViewDiscos.DataSource = listaDiscos;
            ocultarColumnas();
            cargarImagen(listaDiscos[0].UrlTapa);
        }

        private void ocultarColumnas()
        {
            dataGridViewDiscos.Columns[4].Visible = false;
            dataGridViewDiscos.Columns[0].Visible = false;
        }
        private void dataGridViewDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewDiscos.CurrentRow != null)
            {
                Disco discoActual = (Disco)dataGridViewDiscos.CurrentRow.DataBoundItem;
                cargarImagen(discoActual.UrlTapa);
            }
        }

        private void cargarImagen(string imagen) 
        {
            try
            {
                pictureBoxDisco.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxDisco.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg");
                
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Informacion info = new Informacion();
            info.ShowDialog();
        }


        private void buttoneAgregar_Click(object sender, EventArgs e)
        {
            AgregarDiscos agregarDiscoForm = new AgregarDiscos();
            agregarDiscoForm.ShowDialog();
            cargarForm();
        }

        private void buttonEliminarDisco_Click(object sender, EventArgs e)
        {
            EliminarDisco eliminarDisco = new EliminarDisco();
            eliminarDisco.ShowDialog();
            cargarForm();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Disco discoSeleccionado;
            if(dataGridViewDiscos.CurrentRow != null)
            {
                discoSeleccionado = (Disco)dataGridViewDiscos.CurrentRow.DataBoundItem;
                AgregarDiscos modificarDiscoForm = new AgregarDiscos(discoSeleccionado);
                modificarDiscoForm.ShowDialog();
                cargarForm();
            }
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            List<Disco> discosFiltrados;
            if(textBoxBuscador.Text == "")
            {
                discosFiltrados = listaDiscos;
            }
            else
            {
                discosFiltrados = listaDiscos.FindAll(unDisco => unDisco.Titulo.ToUpper().Contains(textBoxBuscador.Text.ToUpper()));
            }

            dataGridViewDiscos.DataSource = null;
            dataGridViewDiscos.DataSource = discosFiltrados;
            ocultarColumnas();
        }
    }
}
