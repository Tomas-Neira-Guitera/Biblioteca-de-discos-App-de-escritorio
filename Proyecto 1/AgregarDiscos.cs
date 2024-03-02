using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexionBDD;

namespace Proyecto_1
{
    public partial class AgregarDiscos : Form
    {

        private Disco discoAModificar = null;
        public AgregarDiscos()
        {
            InitializeComponent();
        }

        public AgregarDiscos(Disco unDisco)
        {
            InitializeComponent();
            discoAModificar = unDisco;
            Text = "Modificar Disco";
        }

        private void AgregarDiscos_Load(object sender, EventArgs e)
        {
            
            pictureBoxFondo.Load("https://static.vecteezy.com/system/resources/previews/002/909/714/non_2x/carbon-fiber-vertical-texture-background-free-vector.jpg");
            pictureBoxImagenTapa.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg");
            GeneroConexion generoConexion = new GeneroConexion();
            EdicionConexion edicionConexion = new EdicionConexion();

            try
            {
                comboBoxEstilo.DataSource = generoConexion.listarGeneros();
                comboBoxEstilo.ValueMember = "Id";
                comboBoxEstilo.DisplayMember = "Descripcion";
                
                comboBoxEdicion.DataSource = edicionConexion.listarEdiciones();
                comboBoxEdicion.ValueMember = "Id";
                comboBoxEdicion.DisplayMember = "Descripcion";


                if(discoAModificar != null) 
                {
                    textBoxTitulo.Text = discoAModificar.Titulo;
                    dateTimePickerFechaDeLanzamineto.Value = discoAModificar.FechaLanzamiento;
                    numericUpDownCantCanciones.Value = discoAModificar.CantidadDeCanciones;
                    textBoxUrlTapaImagen.Text = discoAModificar.UrlTapa;
                    cargarImagen(discoAModificar.UrlTapa);
                    comboBoxEstilo.SelectedValue = discoAModificar.Genero.Id;
                    comboBoxEdicion.SelectedValue = discoAModificar.Edicion.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        
        
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEnvian_Click(object sender, EventArgs e)
        { 
            DiscoConexion discoConexion = new DiscoConexion();
            
            try
            {
                if (discoAModificar == null)
                    discoAModificar = new Disco();
                
                discoAModificar.Titulo = textBoxTitulo.Text;
                discoAModificar.FechaLanzamiento = dateTimePickerFechaDeLanzamineto.Value;
                discoAModificar.CantidadDeCanciones = (int)numericUpDownCantCanciones.Value;
                discoAModificar.UrlTapa = textBoxUrlTapaImagen.Text;
                discoAModificar.Edicion = (Edicion)comboBoxEdicion.SelectedItem; 
                discoAModificar.Genero = (Genero)comboBoxEstilo.SelectedItem;

                
                if(discoAModificar.Id != 0)
                {
                    discoConexion.modificar(discoAModificar);
                    MessageBox.Show("Modificado exitosamente");
                } 
                else
                {
                   discoConexion.agregar(discoAModificar);
                   MessageBox.Show("Agregado exitosamente");
                }
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxUrlTapaImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlTapaImagen.Text);
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
