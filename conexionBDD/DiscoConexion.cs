using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using dominio;

namespace conexionBDD
{
    public class DiscoConexion
    {
    
        public List<Disco> listar() 
        { 
            List<Disco> listaDeDiscos = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server = DESKTOP-IPKDK0D\\SQLEXPRESS; database=DISCOS_DB; integrated security = true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select D.Id IdDisco, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, E.Id GeneroId, T.Descripcion Edicion, T.Id EdicionId\r\nfrom DISCOS D join ESTILOS E on D.IdEstilo = E.Id join TIPOSEDICION T on D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                { 
                    Disco unDisco = new Disco();
                    unDisco.Id = (int)lector["IdDisco"];
                    unDisco.Titulo = (string)lector["Titulo"];
                    unDisco.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    unDisco.CantidadDeCanciones = (int)lector["CantidadCanciones"];
                    unDisco.UrlTapa = (string)lector["UrlImagenTapa"];
                    unDisco.Genero = new Genero();
                    unDisco.Edicion = new Edicion();
                    unDisco.Genero.Id = (int)lector["GeneroId"];
                    unDisco.Genero.Descripcion = (string)lector["Genero"];
                    unDisco.Edicion.Id = (int)lector["EdicionId"];
                    unDisco.Edicion.Descripcion = (string)lector["Edicion"];

                    listaDeDiscos.Add(unDisco);
                }
                
                return listaDeDiscos;
            }
            catch (Exception)
            {

                throw;
            }

            finally 
            {
                conexion.Close();
            }

            
        }

        public void agregar(Disco unDisco) 
        {
            AccesoADatos accesoADatos = new AccesoADatos();
            
            try
            {
                accesoADatos.setearConsulta("insert into DISCOS values('"+ unDisco.Titulo +"','"+ unDisco.FechaLanzamiento +"' ,"+ unDisco.CantidadDeCanciones +" , '"+ unDisco.UrlTapa +"', "+ unDisco.Genero.Id +" ,"+ unDisco.Edicion.Id +" )");
                accesoADatos.ejecutarAccion();
                
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

        public void eliminar(Disco unDisco)
        {
            AccesoADatos accesoADatos = new AccesoADatos();

            try
            {
                accesoADatos.setearConsulta("delete from DISCOS where Id = '" + unDisco.Id + "'");
                accesoADatos.ejecutarAccion();

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
        public void modificar(Disco unDisco)
        {
            AccesoADatos accesoADatos = new AccesoADatos();

            try
            {
                accesoADatos.setearConsulta("update Discos set Titulo = '" + unDisco.Titulo + "', FechaLanzamiento = '" + unDisco.FechaLanzamiento + "', CantidadCanciones = " + unDisco.CantidadDeCanciones + ", UrlImagenTapa = '" + unDisco.UrlTapa + "', IdEstilo = " + unDisco.Genero.Id + ", IdTipoEdicion = " + unDisco.Edicion.Id + " where Id = " + unDisco.Id + "");
                accesoADatos.ejecutarAccion();

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
