using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        public int C_IdEmpleado { get; set; }
        public string C_StrNombre { get; set; }
        public string C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public string C_IdRolEmpleado { get; set; }
        public string C_DtmIngreso { get; set; }
        public string C_DtmRetiro { get; set; }
        public string C_strDatosAdicionales { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultaEmpleado()
        {
            string sentencia;//variable para almacenar la sentencia

            try//intenta ejecutar el codigo
            {
                sentencia = "SELECT * FROM TBLEMPLEADO";//consulta para consultar todos los empleados
                DataTable dt = new DataTable();//crea un objeto de la clase DataTable
                dt = AccesoDatos.EjecutarConsulta(sentencia);//ejecuta la consulta
                return dt;//    retorna el objeto
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_Empleado(int IdEmpleado)//metodo para consultar un empleado
        {
            string sentencia = "";//variable para almacenar la sentencia
            try//intenta ejecutar el codigo
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE  IdEmpleado={IdEmpleado}";//consulta para consultar un empleado
                DataTable dt = new DataTable();//crea un objeto de la clase DataTable
                dt = AccesoDatos.EjecutarConsulta(sentencia);//ejecuta la consulta
                return dt;//retorna el objeto
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error

            {
                return null;
            }
        }

        public DataTable Filtrar_Empleado(string filtro)
        {
            string sentencia;//variable para almacenar la sentencia
            try//intenta ejecutar el codigo
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE  StrNombre LIKE '%{filtro}%'";//consulta para filtrar empleados
                DataTable dt = new DataTable();//crea un objeto de la clase DataTable
                dt = AccesoDatos.EjecutarConsulta(sentencia);//ejecuta la consulta
                return dt;//retorna el objeto
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error

            {
                return null;
            }
        }

        public DataTable ConsultarRol()
        {
            string sentencia;//variable para almacenar la sentencia
            try//intenta ejecutar el codigo
            {
                sentencia = "SELECT * FROM TBLROLES";//consulta para consultar los roles
                DataTable dt = new DataTable();//crea un objeto de la clase DataTable
                dt = AccesoDatos.EjecutarConsulta(sentencia);//ejecuta la consulta
                return dt;//retorna el objeto
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error
            {
                return null;
            }
        }

        public string Eliminar_Empleado(int IdEmpleado)
        {
            string mensaje = "";//variable para almacenar el mensaje
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();//crea una lista de la clase Cls_parametros
                lst.Add(new Cls_parametros("@IdEmpleado", IdEmpleado));//agrega un parametro a la lista
                mensaje = AccesoDatos.Ejecutar_procedimiento("Eliminar_Empleado", lst);//ejecuta el procedimiento almacenado
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error
            {
                mensaje = "Error al eliminar el empleado" + ex.Message;
            }
            return mensaje;//retorna el mensaje
        }

        public string ActualizarEmpleado()
        {
            string mensaje = "";//variable para almacenar el mensaje
            try//intenta ejecutar el codigo
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();//crea una lista de la clase Cls_parametros
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@StrNombre", C_StrNombre));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@StrDireccion", C_StrDireccion));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@StrTelefono", C_StrTelefono));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@StrEmail", C_StrEmail));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@DtmIngreso", C_DtmIngreso));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@DtmRetiro", C_DtmRetiro));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@strDatosAdicionales", C_strDatosAdicionales));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));//agrega un parametro a la lista
                mensaje = AccesoDatos.Ejecutar_procedimiento("Actualizar_Empleado", lst);//ejecuta el procedimiento almacenado
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error
            {
                mensaje = "Error al actualizar el empleado" + ex.Message;
            }
            return mensaje;//retorna el mensaje
        }
    }
}