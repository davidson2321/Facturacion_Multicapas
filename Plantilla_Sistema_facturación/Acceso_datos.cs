using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Plantilla_Sistema_facturación
{
    class Acceso_datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;


        public void AbrirBd()
        {
            try
            {
                conexion = new SqlConnection("Data Source=PLM\\SQLEXPRESS01;Initial Catalog=DBFACTURAS;Integrated Security=True");

                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la base de datos" + ex);
            }
        }

        public void CerrarBd()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la base de datos" + ex);
            }
        }

        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = "";

                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
                AbrirBd();
                cmd = new SqlCommand();
                // utilizamos las propiedades de SqlCommand esta es una forma extendidas con mas parámetros decontrol
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text; // otros tipos son :CommandType.StoredProcedure CommandType.TableDirect
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader(); // ejecuta y retorna un conjunto de datos no actualizable
                while (LectorDatos.Read()) // recorremos los datos consultados
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null) // cerramos el lector de datos
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }
        }

        // ------- recibe una sentencia de para realizar acciones de actualizar, retirar y nuevo
        // solo retorna un valor numerico que indica cuantas filas fueron afectadas

        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE!";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }

            catch (Exception ex)
            {
                salida = "falló inserción: " + ex;
            }
            return salida;
        }

        // Método que permite consultar una tabla y recuperar un conjunto de datos permite filtrar la información requerida
        public DataTable cargartabla(string tabla, string strCondicion)
        {
            try
            {
                AbrirBd();
                string Sql = "Select * from " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(Sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString());
                return null;
            }
        }

        // Método que permite consultar con una sentencia (select) o invocar un procedimiento almacenado
        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
                return null;
            }
        }
    }
}
