using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosEmpleados
    {
        SqlConnection cnx;
        Empleados e = new Empleados();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;

        SqlDataReader dr = null;
        List<Empleados> listaEmpleados = null;

        public int insertarEmpleados(Empleados emple)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("agregarempleados", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codempleado", "");
                cm.Parameters.AddWithValue("@cedulaempleado", emple.cedulaempleado);
                cm.Parameters.AddWithValue("@nombre_emple", emple.nombre_emple);
                cm.Parameters.AddWithValue("@apellidoemple", emple.apellidoemple);
                cm.Parameters.AddWithValue("@telefonoempl", emple.telefonoempl);
                cm.Parameters.AddWithValue("@direccionempl", emple.direccionempl);
                cm.Parameters.AddWithValue("@correoemple", emple.correoemple);

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

        public List<Empleados> listarEmpleados()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarempleados", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@codempleado", "");
                cm.Parameters.AddWithValue("@cedulaempleado", "");
                cm.Parameters.AddWithValue("@nombre_emple", "");
                cm.Parameters.AddWithValue("@apellidoemple", "");
                cm.Parameters.AddWithValue("@telefonoempl", "");
                cm.Parameters.AddWithValue("@direccionempl", "");
                cm.Parameters.AddWithValue("@correoemple", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEmpleados = new List<Empleados>();
                while (dr.Read())
                {
                    Empleados emp = new Empleados();
                    emp.codempleado = Convert.ToInt32(dr["codempleado"].ToString());
                    emp.cedulaempleado = dr["cedula empleado"].ToString();
                    emp.nombre_emple = dr["nombres empleado"].ToString();
                    emp.apellidoemple = dr["apellidos empleado"].ToString();
                    emp.telefonoempl = dr["telefono empleado"].ToString();
                    emp.direccionempl = dr["direccion empleado"].ToString();
                    emp.correoemple = dr["correo empleado"].ToString();
                    listaEmpleados.Add(emp);
                }
                
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaEmpleados = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaEmpleados;

        }

        public int eliminarEmpleados(int codempleado)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarempleados", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@codempleado", codempleado);
                cm.Parameters.AddWithValue("@cedulaempleado", "");
                cm.Parameters.AddWithValue("@nombre_emple", "");
                cm.Parameters.AddWithValue("@apellidoemple", "");
                cm.Parameters.AddWithValue("@telefonoempl", "");
                cm.Parameters.AddWithValue("@direccionempl", "");
                cm.Parameters.AddWithValue("@correoemple", "");

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

        public int editarEmpleados(Empleados em)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarempleados", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@codempleado", em.codempleado);
                cm.Parameters.AddWithValue("@cedulaempleado", "");
                cm.Parameters.AddWithValue("@nombre_emple", "");
                cm.Parameters.AddWithValue("@apellidoemple", "");
                cm.Parameters.AddWithValue("@telefonoempl", "");
                cm.Parameters.AddWithValue("@direccionempl", "");
                cm.Parameters.AddWithValue("@correoemple", em.correoemple);

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

        public List<Empleados> BuscarEmpleado(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("agregarempleados", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@codempleado", dato);
                cm.Parameters.AddWithValue("@cedulaempleado",dato);
                cm.Parameters.AddWithValue("@nombre_emple", dato);
                cm.Parameters.AddWithValue("@apellidoemple", dato);
                cm.Parameters.AddWithValue("@telefonoempl", "");
                cm.Parameters.AddWithValue("@direccionempl", "");
                cm.Parameters.AddWithValue("@correoemple","");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEmpleados = new List<Empleados>();
                while (dr.Read())
                {
                    Empleados ep = new Empleados();
                    ep.codempleado = Convert.ToInt32(dr["codempleado"].ToString());
                    ep.cedulaempleado = dr["cedula empleado"].ToString();
                    ep.nombre_emple = dr["nombres empleado"].ToString();
                    ep.apellidoemple = dr["apellidos empleado"].ToString();
                    ep.telefonoempl = dr["telefono empleado"].ToString();
                    ep.direccionempl = dr["direccion empleado"].ToString();
                    ep.correoemple = dr["correo empleado"].ToString();
                    listaEmpleados.Add(ep);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaEmpleados = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return listaEmpleados;

        }

    }

}
