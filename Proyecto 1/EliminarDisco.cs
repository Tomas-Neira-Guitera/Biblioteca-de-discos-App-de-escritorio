using conexionBDD;
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

namespace Proyecto_1
{
    public partial class EliminarDisco : Form
    {
        public EliminarDisco()
        {
            InitializeComponent();
        }

        private void EliminarDisco_Load(object sender, EventArgs e)
        {
            pictureBoxFondo.Load("https://static.vecteezy.com/system/resources/previews/002/909/714/non_2x/carbon-fiber-vertical-texture-background-free-vector.jpg");
            DiscoConexion discoConexion = new DiscoConexion();
            pictureBoxImagenTapa.Load(discoConexion.listar()[0].UrlTapa);

            try
            {
                comboBoxDiscoAEliminar.DataSource = discoConexion.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DiscoConexion discoConexion = new DiscoConexion();

            try
            {
                Disco discoAEliminar = (Disco)comboBoxDiscoAEliminar.SelectedItem;
                discoConexion.eliminar(discoAEliminar);

                MessageBox.Show("Eliminacion exitosa");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxDiscoAEliminar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Disco discoSeleccionado = new Disco();
            discoSeleccionado = (Disco)comboBoxDiscoAEliminar.SelectedItem;
            cargarImagen(discoSeleccionado.UrlTapa);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagenTapa.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxImagenTapa.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg");

            }
        }
    }
}
