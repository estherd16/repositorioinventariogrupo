using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosFacturas
    {
        SqlConnection cnx;
        Factura fac = new Factura();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Factura> listaFactura = null;

        public int insertarFacturas(Factura fa)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarfacturas", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@fechaFactura", fa.fechaFactura);
                cm.Parameters.AddWithValue("@codcliente", fa.codcliente);
                cm.Parameters.AddWithValue("@codempleado", fa.codempleado);

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

        public List<Factura> listarFactura()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarfacturas", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idFactura", "");
                cm.Parameters.AddWithValue("@fechaFactura", "");
                cm.Parameters.AddWithValue("@codcliente", "");
                cm.Parameters.AddWithValue("@codempleado", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaFactura = new List<Factura>();
                while (dr.Read())
                {
                    Factura fact = new Factura();
                    fact.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    fact.fechaFactura = Convert.ToDateTime(dr["fechaFactura"].ToString());
                    fact.codcliente = Convert.ToInt32(dr["codcliente"].ToString());
                    fact.codempleado = Convert.ToInt32(dr["codempleado"].ToString());
                    listaFactura.Add(fact);
                }
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaFactura = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaFactura;
        }

        public List<Factura> BuscarFacturas(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarfacturas", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idFactura", dato);
                cm.Parameters.AddWithValue("@fechaFactura", "");
                cm.Parameters.AddWithValue("@codcliente", "");
                cm.Parameters.AddWithValue("@codempleado", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaFactura = new List<Factura>();
                while (dr.Read())
                {
                    Factura f = new Factura();
                    f.idFactura = Convert.ToInt32(dr["idFactura"].ToString());
                    f.fechaFactura = Convert.ToDateTime(dr["fechaFactura"].ToString());
                    f.codcliente = Convert.ToInt32(dr["codcliente"].ToString());
                    f.codempleado = Convert.ToInt32(dr["codempleado"].ToString());
                    listaFactura.Add(f);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaFactura = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return listaFactura;

        }

   }
}
