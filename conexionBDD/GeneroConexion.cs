using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace conexionBDD
{
    public class GeneroConexion
    {
        public List<Genero> listarGeneros() 
        { 
            List<Genero> listaDeGeneros = new List<Genero>();
            AccesoADatos accesoADatos = new AccesoADatos();

            try
            {
                accesoADatos.setearConsulta("select id, descripcion from ESTILOS");
                accesoADatos.ejecutarLectura();

                while (accesoADatos.Lector.Read())
                {
                    Genero unGenero = new Genero();
                    unGenero.Id = (int)accesoADatos.Lector["id"];
                    unGenero.Descripcion = (string)accesoADatos.Lector["descripcion"];
                    
                    listaDeGeneros.Add(unGenero);
                }
                
                return listaDeGeneros;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally 
            {
                accesoADatos.cerrarConexion();
            }
            

        }

    }
}
