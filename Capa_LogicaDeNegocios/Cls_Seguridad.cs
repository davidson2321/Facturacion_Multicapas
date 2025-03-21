using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Seguridad
    {
        public int C_IdEmpleado { get; set; }
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public string C_StrUsuarioModifico { get; set; }

       Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();
        public DataTable ConsultarEmpleados()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT IdEmpleado, strNombre  FROM TBLSEGURIDAD";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_SeguridadEmpleado(int IdEmpleado)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT StrUsuario, StrClave  FROM TBLSEGURIDAD WHERE  idEmpleado={IdEmpleado}";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string EliminarSeguridadEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                mensaje = AccesoDatos.Ejecutar_procedimiento("Eliminar_SeguridadEmpleado", lst);
            }
            catch (Exception ex)
            {
               mensaje =  "FALLÓ BORRADO EN EMPLEADO" + ex.Message;
            }
            return mensaje;
        }

        public string ActualizarSeguridadEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_parametros("@StrUsuario", C_StrUsuario));
                lst.Add(new Cls_parametros("@StrClave", C_StrClave));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));
                mensaje = AccesoDatos.Ejecutar_procedimiento("Actualizar_SeguridadEmpleado", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ ACTUALIZACIÓN EN EMPLEADO" + ex.Message;
            }
            return mensaje;
        }
    }
}
