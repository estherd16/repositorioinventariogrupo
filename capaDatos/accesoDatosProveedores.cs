using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosProveedores
    {
        SqlConnection cnx;
        Proveedores prov = new Proveedores();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Proveedores> listaProveedores = null;

        public int insertarProveedores(Proveedores p)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarproveedor", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codproveedor", "");
                cm.Parameters.AddWithValue("@ruc", p.ruc);
                cm.Parameters.AddWithValue("@nombreprov", p.nombreprov);
                cm.Parameters.AddWithValue("@telefono", p.telefono);
                cm.Parameters.AddWithValue("@direccion", p.direccion);
                cm.Parameters.AddWithValue("@correoprov", p.correoprov);

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

        public List<Proveedores> listarProveedores()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproveedor", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@codproveedor", "");
                cm.Parameters.AddWithValue("@ruc", "");
                cm.Parameters.AddWithValue("@nombreprov", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@correoprov", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProveedores = new List<Proveedores>();
                while (dr.Read())
                {
                    Proveedores p = new Proveedores();
                    p.codproveedor = Convert.ToInt32(dr["codproveedor"].ToString());
                    p.ruc = dr["ruc"].ToString();
                    p.nombreprov = dr["nombreprov"].ToString();
                    p.telefono = dr["telefono"].ToString();
                    p.direccion = dr["direccion"].ToString();
                    p.correoprov = dr["correoprov"].ToString();
                    listaProveedores.Add(p);
                 
                }
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProveedores = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaProveedores;

        }

        public int eliminarProveedor(int codproveedor)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproveedor", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@codproveedor", codproveedor);
                cm.Parameters.AddWithValue("@ruc", "");
                cm.Parameters.AddWithValue("@nombreprov", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@correoprov", "");

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

        public int editarProveedores(Proveedores prv)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproveedor", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@codproveedor", prv.codproveedor);
                cm.Parameters.AddWithValue("@ruc", prv.ruc);
                cm.Parameters.AddWithValue("@nombreprov", prv.nombreprov);
                cm.Parameters.AddWithValue("@telefono", prv.telefono);
                cm.Parameters.AddWithValue("@direccion", prv.direccion);
                cm.Parameters.AddWithValue("@correoprov", prv.correoprov);

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

        public List<Proveedores> BuscarProveedores(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproveedor", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@codproveedor","");
                cm.Parameters.AddWithValue("@ruc", "");
                cm.Parameters.AddWithValue("@nombreprov", dato);
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@correoprov", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProveedores = new List<Proveedores>();
                while (dr.Read())
                {
                    Proveedores p = new Proveedores();
                    p.codproveedor = Convert.ToInt32(dr["codproveedor"].ToString());
                    p.ruc = dr["ruc"].ToString();
                    p.nombreprov = dr["nombreprov"].ToString();
                    p.telefono = dr["telefono"].ToString();
                    p.direccion = dr["direccion"].ToString();
                    p.correoprov = dr["correoprov"].ToString();
                    listaProveedores.Add(p);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProveedores = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return listaProveedores;

        }
    }
}
