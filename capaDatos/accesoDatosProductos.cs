using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosProductos
    {
        SqlConnection cnx;
        Productos pro = new Productos();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Productos> listaProductos = null;

        public int insertarProductos(Productos prod)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarproductos", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codproducto", "");
                cm.Parameters.AddWithValue("@producto", prod.producto);
                cm.Parameters.AddWithValue("@precio", prod.precio);
                cm.Parameters.AddWithValue("@existencia", prod.existencia);
                cm.Parameters.AddWithValue("@codcategoria", prod.codcategoria);
                cm.Parameters.AddWithValue("@codproveedor", prod.codproveedor);
                
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

        public List<Productos> listarProductos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproductos", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@codproducto", "");
                cm.Parameters.AddWithValue("@producto", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@existencia", "");
                cm.Parameters.AddWithValue("@codcategoria", "");
                cm.Parameters.AddWithValue("@codproveedor", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProductos = new List<Productos>();
                while (dr.Read())
                {
                    Productos pr = new Productos();
                    pr.codproducto = Convert.ToInt32(dr["codigo producto"].ToString());
                    pr.producto = dr["Producto"].ToString();
                    pr.precio = Convert.ToInt32(dr["Precio producto"].ToString());
                    pr.existencia = Convert.ToInt32(dr["Existencia Producto"].ToString());
                    pr.codcategoria = Convert.ToInt32(dr["Codigo Categoria"].ToString());
                    pr.codproveedor = Convert.ToInt32(dr["Codigo Proveedor"].ToString());
                    listaProductos.Add(pr);
                }
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProductos = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaProductos;

        }

        public int eliminarProductos(int codproducto)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproductos", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@codproducto", codproducto);
                cm.Parameters.AddWithValue("@producto", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@existencia", "");
                cm.Parameters.AddWithValue("@codcategoria", "");
                cm.Parameters.AddWithValue("@codproveedor", "");

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

        public int editarProductos(Productos produ)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproductos", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@codproducto", produ.codproducto);
                cm.Parameters.AddWithValue("@producto", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@existencia", "");
                cm.Parameters.AddWithValue("@codcategoria", produ.codcategoria);
                cm.Parameters.AddWithValue("@codproveedor", produ.codproveedor);

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

        public List<Productos> BuscarProductos(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproductos", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@codproducto", dato);
                cm.Parameters.AddWithValue("@producto", dato);
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@existencia", "");
                cm.Parameters.AddWithValue("@codcategoria", "");
                cm.Parameters.AddWithValue("@codproveedor", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProductos = new List<Productos>();
                while (dr.Read())
                {
                    Productos p = new Productos();
                    p.codproducto = Convert.ToInt32(dr["codigo producto"].ToString());
                    p.producto = dr["Producto"].ToString();
                    p.precio = Convert.ToInt32(dr["Precio producto"].ToString());
                    p.existencia = Convert.ToInt32(dr["Existencia Producto"].ToString());
                    p.codcategoria = Convert.ToInt32(dr["Codigo Categoria"].ToString());
                    p.codproveedor = Convert.ToInt32(dr["Codigo Proveedor"].ToString());
                    listaProductos.Add(p);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProductos = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return listaProductos;

        }
    }
}



