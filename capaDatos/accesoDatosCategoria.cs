using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosCategoria
    {
        SqlConnection cnx; 
        Categoria cate = new Categoria();
        Conexion cn = new Conexion();
        SqlCommand cm = null; 
        int indicador = 0;

        SqlDataReader dr = null;
        List<Categoria> listaCategoria = null;

        public int insertarCategoria(Categoria cat)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarcategorias", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codcategoria", "");
                cm.Parameters.AddWithValue("@nombrecat", cat.nombrecat);
                cm.Parameters.AddWithValue("@descripcion", cat.descripcion);
     
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Categoria> listarCategoria()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarcategorias", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@codcategoria", ""); 
                cm.Parameters.AddWithValue("@nombrecat", "");
                cm.Parameters.AddWithValue("@descripcion", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCategoria = new List<Categoria>();
                while (dr.Read())
                {
                    Categoria c = new Categoria();
                    c.codcategoria = Convert.ToInt32(dr["codcategoria"].ToString());
                    c.nombrecat = dr["nombre"].ToString();
                    c.descripcion = dr["descripcion"].ToString();
                    listaCategoria.Add(c);
                    
                }
                
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCategoria = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaCategoria;

        }

        public int eliminarCategoria(int codcategoria)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarcategoria", cnx);

                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@codcategoria", codcategoria);
                cm.Parameters.AddWithValue("@nombrecat", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;

        }

        public int editarCategoria(Categoria cat)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarcategoria", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@codcategoria", cat.codcategoria);
                cm.Parameters.AddWithValue("@nombrecat", cat.nombrecat);
                cm.Parameters.AddWithValue("@descripcion", cat.descripcion);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }

            finally
            {
                cm.Connection.Close();
            }
            return indicador;

        }

        public List <Categoria> BuscarCategoria(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarcategoria", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@codcategoria", dato);
                cm.Parameters.AddWithValue("@nombrecat", dato);
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCategoria = new List<Categoria>();
                while (dr.Read())
                {
                    Categoria c = new Categoria();
                    c.codcategoria = Convert.ToInt32(dr["codcategoria"].ToString());
                    c.nombrecat = dr["nombre"].ToString();
                    c.descripcion = dr["nombre"].ToString();
                    listaCategoria.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCategoria = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return listaCategoria;

        }
    }
}
