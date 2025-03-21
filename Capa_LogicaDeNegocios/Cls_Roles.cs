using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
   public  class Cls_Roles
    {
        public int C_IdRolEmpleado { get; set; }
        public string C_StrNombreRol { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

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

        public DataTable Consultar_Rol(int IdRolEmpleado)//metodo para consultar un rol
        {
            string sentencia = "";//variable para almacenar la sentencia
            try//intenta ejecutar el codigo
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE  IdRolEmpleado={IdRolEmpleado}";//consulta para consultar un rol
                DataTable dt = new DataTable();//crea un objeto de la clase DataTable
                dt = AccesoDatos.EjecutarConsulta(sentencia);//ejecuta la consulta
                return dt;//retorna el objeto
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error
            {
                return null;
            }
        }

        public DataTable Filtrar_Rol(string filtro)
        {
            string sentencia;//variable para almacenar la sentencia
            try//intenta ejecutar el codigo
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE  StrNombreRol LIKE '%{filtro}%'";//consulta para filtrar roles
                DataTable dt = new DataTable();//crea un objeto de la clase DataTable
                dt = AccesoDatos.EjecutarConsulta(sentencia);//ejecuta la consulta
                return dt;//retorna el objeto
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error
            {
                return null;
            }
        }

        public string Eliminar_Rol(int IdRolEmpleado)//metodo para eliminar un rol
        {
            string mensaje = "";//variable para almacenar el mensaje
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();//crea una lista de la clase Cls_parametros
                lst.Add(new Cls_parametros("@IdRolEmpleado", IdRolEmpleado));//agrega un parametro a la lista
                mensaje = AccesoDatos.Ejecutar_procedimiento("Eliminar_Rol", lst);//ejecuta el procedimiento almacenado
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error
            {
                mensaje = "Error al eliminar el empleado" + ex.Message;
            }
            return mensaje;//retorna el mensaje
        }

        public string ActualizarRol()//metodo para actualizar un rol
        {
            string mensaje = "";//variable para almacenar el mensaje
            try//intenta ejecutar el codigo
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();//crea una lista de la clase Cls_parametros
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));//agrega un parametro a la lista
                lst.Add(new Cls_parametros("@StrNombreRol", C_StrNombreRol));//agrega un parametro a la lista
                mensaje = AccesoDatos.Ejecutar_procedimiento("Actualizar_Rol", lst);//ejecuta el procedimiento almacenado
            }
            catch (Exception ex)//  si hay error retorna el mensaje de error
            {
                mensaje = "Error al actualizar el rol" + ex.Message;
            }
            return mensaje;//retorna el mensaje
        }
    }
}
