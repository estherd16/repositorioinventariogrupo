using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosVentas
    {
        SqlConnection cnx;
        Ventas ven = new Ventas();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Ventas> listaVentas = null;

        public int insertarVenta(Ventas ve)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarventas", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codventa", "");
                cm.Parameters.AddWithValue("@cantidad", ve.cantidad);
                cm.Parameters.AddWithValue("@precio", ve.precio);
                cm.Parameters.AddWithValue("@codproducto", ve.codproducto);
                cm.Parameters.AddWithValue("@idFactura", ve.idFactura);

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

        public List<Ventas> listarVentas()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarventas", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@codventa", "");
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@codproducto", "");
                cm.Parameters.AddWithValue("@idFactura", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaVentas = new List<Ventas>();
                while (dr.Read())
                {
                    Ventas v = new Ventas();
                    v.codventa = Convert.ToInt32(dr["codventa"].ToString());
                    v.cantidad = Convert.ToInt32(dr["cantidad"].ToString());
                    v.precio = Convert.ToInt32(dr["precio"].ToString());
                    v.codproducto = Convert.ToInt32(dr["codproducto"].ToString());
                    v.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    listaVentas.Add(v);
                }
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaVentas= null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaVentas;

        }

        public List<Ventas> BuscarVentas(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarventas", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@codventa", dato);
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@codproducto","");
                cm.Parameters.AddWithValue("@idFactura", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaVentas = new List<Ventas>();
                while (dr.Read())
                {
                    Ventas vn = new Ventas();
                    vn.codventa = Convert.ToInt32(dr["codventa"].ToString());
                    vn.cantidad = Convert.ToInt32(dr["cantidad"].ToString());
                    vn.precio = Convert.ToInt32(dr["precio"].ToString());
                    vn.codproducto = Convert.ToInt32(dr["codproducto"].ToString());
                    vn.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    listaVentas.Add(vn);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaVentas = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return listaVentas;

        }
    }
}
