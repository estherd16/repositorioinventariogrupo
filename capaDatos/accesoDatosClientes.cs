using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;


namespace capaDatos
{
    public class accesoDatosClientes
    {
        SqlConnection cnx;
        Clientes clie = new Clientes();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Clientes> listaClientes = null;

        public int insertarCliente(Clientes cli)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Agregarcliente", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codcliente", "");
                cm.Parameters.AddWithValue("@cedulacl", cli.cedulacl);
                cm.Parameters.AddWithValue("@nombrescli", cli.nombrescli);
                cm.Parameters.AddWithValue("@apellidos", cli.apellidos);
                cm.Parameters.AddWithValue("@direccion", cli.direccion);
                cm.Parameters.AddWithValue("@telefono", cli.telefono);
                cm.Parameters.AddWithValue("@correo_cli", cli.correo_cli);

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

        public List<Clientes> listarClientes()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Agregarcliente", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@codcliente", "");
                cm.Parameters.AddWithValue("@cedulacl", "");
                cm.Parameters.AddWithValue("@nombrescli", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@correo_cli", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClientes = new List<Clientes>();
                while (dr.Read())
                {
                    Clientes cl = new Clientes();
                    cl.codcliente = Convert.ToInt32(dr["codcliente"].ToString());
                    cl.cedulacl = dr["cedulacl"].ToString();
                    cl.nombrescli = dr["nombrescli"].ToString();
                    cl.apellidos = dr["apellidos"].ToString();
                    cl.direccion = dr["direccion"].ToString();
                    cl.telefono = dr["telefono"].ToString();
                    cl.correo_cli = dr["correo_cli"].ToString();
                    listaClientes.Add(cl);
                }
                
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClientes = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaClientes;

        }

        public int eliminarCliente(int codcliente)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Agregarcliente", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@codcliente", codcliente);
                cm.Parameters.AddWithValue("@cedulacl", "");
                cm.Parameters.AddWithValue("@nombrescli", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@correo_cli", "");

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

        public int editarClientes(Clientes clien)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Agregarcliente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@codcliente", clien.codcliente);
                cm.Parameters.AddWithValue("@cedulacl", clien.cedulacl);
                cm.Parameters.AddWithValue("@nombrescli", clien.nombrescli);
                cm.Parameters.AddWithValue("@apellidos", clien.apellidos);
                cm.Parameters.AddWithValue("@direccion", clien.direccion);
                cm.Parameters.AddWithValue("@telefono", clien.telefono);
                cm.Parameters.AddWithValue("@correo_cli", clien.correo_cli);

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

        public List<Clientes> BuscarClientes(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Agregarcliente", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@codcliente","");
                cm.Parameters.AddWithValue("@cedulacl", "");
                cm.Parameters.AddWithValue("@nombrescli",dato);
                cm.Parameters.AddWithValue("@apellidos",dato);
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@correo_cli", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClientes = new List<Clientes>();
                while (dr.Read())
                {
                    Clientes cl = new Clientes();
                    cl.codcliente = Convert.ToInt32(dr["codcliente"].ToString());
                    cl.cedulacl = dr["cedulacl"].ToString();
                    cl.nombrescli = dr["nombrescli"].ToString();
                    cl.apellidos = dr["apellidos"].ToString();
                    cl.direccion = dr["direccion"].ToString();
                    cl.telefono = dr["telefono"].ToString();
                    cl.correo_cli = dr["correo_cli"].ToString();
                    listaClientes.Add(cl);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClientes = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return listaClientes;

        }
    }
}
