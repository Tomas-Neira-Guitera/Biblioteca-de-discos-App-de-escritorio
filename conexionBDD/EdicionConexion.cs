using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace conexionBDD
{
    public class EdicionConexion
    {
        public List<Edicion> listarEdiciones()
        {
            List<Edicion> listaDeEdiciones = new List<Edicion>();
            AccesoADatos accesoADatos = new AccesoADatos();

            try
            {
                accesoADatos.setearConsulta("select id, descripcion from TIPOSEDICION");
                accesoADatos.ejecutarLectura();

                while (accesoADatos.Lector.Read())
                {
                    Edicion unaEdicion = new Edicion();
                    unaEdicion.Id = (int)accesoADatos.Lector["id"];
                    unaEdicion.Descripcion = (string)accesoADatos.Lector["descripcion"];

                    listaDeEdiciones.Add(unaEdicion);
                }

                return listaDeEdiciones;
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
