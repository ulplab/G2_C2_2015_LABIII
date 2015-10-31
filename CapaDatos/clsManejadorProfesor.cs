using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;

namespace CapaDatos
{
    public class clsManejadorProfesor
    {
        clsDBManager dbmanager = new clsDBManager();

        public int InsertarProfesor(clsProfesor entidad)
        {
            int filas;
            try
            {
                string query = "insert into Profesores values('"
                    + entidad.Nombre + "','"
                    + entidad.Apellido + "','"
                    + entidad.Dni + "','"
                    + entidad.Telefono + "','"
                    + entidad.Contraseña + "','"
                    + entidad.Estado + "');";

                filas = dbmanager.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int UpdateProfesor(clsProfesor entidad)
        {
            int filas;

            try
            {
                String query = "update Profesor set "
                    + "Nombre = '" + entidad.Nombre
                    + "' Apellido = '" + entidad.Apellido
                    + "' Dni ='" + entidad.Dni
                    + "' Telefono = '" + entidad.Telefono
                    + "' Contraseña = '" + entidad.Contraseña
                    + "' Estado = '" + entidad.Estado
                    + "' where IdProfesor = " + entidad.Id + ";";
               
                filas = dbmanager.Ejecutar(query, Tipo.ACTUALIZAR);

            }
            catch (Exception e)
            {
                throw e;
            }
            
            return filas;
        }

        public int DeleteProfesor(clsProfesor entidad)
        {
            int filas;

            try
            {
                String query = "delete Profesores where IdProfesor = " + entidad.Id + ";";

                filas = dbmanager.Ejecutar(query, Tipo.ELIMINAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }
        
    }
}
