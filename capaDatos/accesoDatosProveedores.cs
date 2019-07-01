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

        public int insertarProveedores(Proveedores cli)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarproveedor", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codproveedores", "");
                cm.Parameters.AddWithValue("@ruc", prov.ruc);
                cm.Parameters.AddWithValue("@nombreprov", prov.nombreprov);
                cm.Parameters.AddWithValue("@telefono", prov.telefono);
                cm.Parameters.AddWithValue("@direccion", prov.direccion);
                cm.Parameters.AddWithValue("@correoprov", prov.correoprov);

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
                cm.Parameters.AddWithValue("@ruc", prov.ruc);
                cm.Parameters.AddWithValue("@nombreprov", prov.nombreprov);
                cm.Parameters.AddWithValue("@telefono", prov.telefono);
                cm.Parameters.AddWithValue("@direccion", prov.direccion);
                cm.Parameters.AddWithValue("@correoprov", prov.correoprov);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProveedores = new List<Proveedores>();
                while (dr.Read())
                {
                    Proveedores p = new Proveedores();
                    prov.codproveedor = Convert.ToInt32(dr["codProveedor"].ToString());
                    prov.ruc = dr["RUC"].ToString();
                    prov.nombreprov = dr["nombre"].ToString();
                    prov.telefono = dr["telefono"].ToString();
                    prov.direccion = dr["direccion"].ToString();
                    prov.correoprov = dr["correo"].ToString();
                 
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

        public int editarProveedores(Proveedores codproveedor)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarproveedor", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@codproveedor", prov.codproveedor);
                cm.Parameters.AddWithValue("@ruc", "");
                cm.Parameters.AddWithValue("@nombreprov", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@correoprov", prov.correoprov);

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
                cm.Parameters.AddWithValue("@codproveedor", dato);
                cm.Parameters.AddWithValue("@ruc", dato);
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
                    prov.codproveedor = Convert.ToInt32(dr["codProveedor"].ToString());
                    prov.ruc = dr["RUC"].ToString();
                    prov.nombreprov = dr["nombre"].ToString();
                    prov.telefono = dr["telefono"].ToString();
                    prov.direccion = dr["direccion"].ToString();
                    prov.correoprov = dr["correo"].ToString();
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
