using conexionBDD;
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

namespace Proyecto_1
{
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
        }

        List<Genero> listaDeGeneros = new List<Genero>();
        List<Edicion> listaDeEdiciones = new List<Edicion>();


        private void Informacion_Load(object sender, EventArgs e)
        {

            pictureBoxFondo.Load("https://e0.pxfuel.com/wallpapers/2/356/desktop-wallpaper-dark-space.jpg");

            GeneroConexion conexion = new GeneroConexion();
            listaDeGeneros = conexion.listarGeneros();
            dataGridViewGeneros.DataSource = listaDeGeneros;

            EdicionConexion conexion2 = new EdicionConexion();
            listaDeEdiciones = conexion2.listarEdiciones();
            dataGridViewEdiciones.DataSource = listaDeEdiciones;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
