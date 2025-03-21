using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
   public class Validar_usuario//clase para validar el usuario
    {
        public string C_StrUsuario { get; set; }//propiedad para el nombre del usuario
        public string C_StrClave { get; set; }//propiedad para la clave del usuario
        public Int32 C_IdEmpleado { get; set; }//propiedad para el id del empleado

        public void ValidarUsuario()//metodo para validar el usuario
        {
            try
            {
                string sentencia = $"SELECT  IdEmpleado FROM TBLSEGURIDAD where StrUsuario = '{C_StrUsuario}' and StrClave = '{C_StrClave}'";//consulta para validar el usuario
                DataTable dt = new DataTable();//crea un objeto de la clase DataTable
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();//crea un objeto de la clase Cls_Acceso_Datos
                dt = Acceso.EjecutarConsulta(sentencia);//ejecuta la consulta

                foreach (DataRow row in dt.Rows)
                {
                    C_IdEmpleado = int.Parse(row[0].ToString());//
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario" + ex.Message);
            }
        }
    }
}
