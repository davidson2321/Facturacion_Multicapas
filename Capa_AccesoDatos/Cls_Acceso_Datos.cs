using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Capa_AccesoDatos
{
    public class Cls_parametros
    {
        public String Nombre { get; set; }//propiedad para el nombre del parametro
        public Object Valor { get; set; }//propiedad para el valor del parametro
        public SqlDbType TipoDato { get; set; }//propiedad para el tipo de dato del parametro
        public Int32 Tamano { get; set; }//propiedad para el tamaño del parametro
        public ParameterDirection Direccionparametro { get; set; }//propiedad para la direccion del parametro

        //constructor para parametros de entrada
        public Cls_parametros(String objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccionparametro = ParameterDirection.Input;
        }

        //constructor para parametros de salida
        public Cls_parametros(String objNombre, Object objValor, SqlDbType objTipoDato, Int32 objTamano)
        {
            Nombre = objNombre;
            Valor = objValor;
            TipoDato = objTipoDato;
            Tamano = objTamano;
            Direccionparametro = ParameterDirection.Input;
        }
    }
    public class Cls_Acceso_Datos
    {
        SqlConnection conexion;//objeto de la clase SqlConnection
        SqlCommand cmd;//objeto de la clase SqlCommand
        SqlDataReader LectorDatos;//objeto de la clase SqlDataReader
        SqlDataAdapter da;//objeto de la clase SqlDataAdapter
        DataTable dt;//objeto de la clase DataTable

        public string AbrirBd()
        {
            string resultado = "";//variable para almacenar el resultado
            try//intenta abrir la base de datos permite captura de errores
            {
                //cadena de conexion a la base de datos
                conexion = new SqlConnection("Data Source=PLM\\SQLEXPRESS01;Initial Catalog=DBFACTURAS;Integrated Security=True");
                conexion.Open();//abre la conexion
                resultado = "Conexión exitosa";
            }
            catch (Exception ex)//si hay error retorna el mensaje de error

            {
                resultado = "Error al abrir la base de datos" + ex.Message;
            }
            return resultado;
        }


    

    public string CerrarB()
        {
            string resultado = "";//variable para almacenar el resultado
            try//intenta cerrar la base de datos permite captura de errores
            {
                conexion.Close();//cierra la conexion
                resultado = "Conexión cerrada";
            }
            catch (Exception ex)//si hay error retorna el mensaje de error
            {
                resultado = "Error al cerrar la base de datos" + ex.Message;
            }
            return resultado;
        }

        public string Ejecutar_procedimiento(string procedimiento, List<Cls_parametros> lst) {
            string salida = "";
            try
            {
                int retornado;//variable para almacenar el resultado de la ejecucion del procedimiento
                AbrirBd();//abre la base de datos
                SqlCommand comando = new SqlCommand(procedimiento, conexion);//crea un objeto de la clase SqlCommand
                comando.CommandType = CommandType.StoredProcedure;//    indica que es un procedimiento almacenado
                if (lst != null)//si la lista de parametros no es nula
                {
                    for (int i = 0; i < lst.Count; i++)//recorre la lista de parametros
                    {
                        if (lst[i].Direccionparametro == ParameterDirection.Input)//si el parametro es de entrada
                        {
                            comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);//agrega el parametro al comando
                        }
                        if (lst[i].Direccionparametro == ParameterDirection.Output)//si el parametro es de salida
                        {
                            comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamano).Direction = ParameterDirection.Output;//agrega el parametro al comando

                        }
                    }
                }
                retornado = comando.ExecuteNonQuery();//ejecuta el procedimiento almacenado
                CerrarB();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "No se pudo actualizar";

                }
            }
            catch (Exception ex)
            {
                salida = "Error al ejecutar el procedimiento almacenado: " + ex;
            }
            CerrarB();
            return salida;

        }

        public DataTable EjecutarConsulta(string cmd)//metodo para ejecutar una consulta
        {
            try//intenta ejecutar la consulta
            {
                AbrirBd();//abre la base de datos
                da = new SqlDataAdapter(cmd, conexion);//crea un objeto de la clase SqlDataAdapter
                dt = new DataTable();//crea un objeto de la clase DataTable
                da.Fill(dt);//llena el objeto DataTable con los datos de la consulta
                CerrarB();//cierra la base de datos
                return dt;//retorna el objeto DataTable
            }
            catch (Exception ex)//
            {
                return null;//si hay error retorna nulo
            }
        }
    }
}