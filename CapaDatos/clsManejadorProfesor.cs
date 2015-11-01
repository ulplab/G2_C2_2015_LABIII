using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;

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

        public List<clsProfesor> SelectProfesor(clsProfesor entidad)
        {
            bool id = false, nombre = false, apellido = false, dni = false, telefono = false, contraseña = false;
            string query = "select * from Profesores where";
            if (entidad.Id != -1)
            {
                query += " IdProfesor = " + entidad.Id;
                id = true;
            }

            if (entidad.Nombre != null)
	        {
		        if (id)
	            {
                    query += " and";	 
	            }
                query += " Nombre = " + entidad.Nombre;
                nombre = true;
	        }
            if (entidad.Apellido != null)
	        {
                if (id | nombre)
                {
                    query += " and";
                }
               
                query += " Apellido = " + entidad.Apellido;
                apellido = true;
	        }
            if (entidad.Dni != -1)
            {
                if (id | nombre | apellido)
                {
                    query += " and";
                }

                query += " Dni = " + entidad.Dni;
                dni = true;
            }
            if (entidad.Telefono != null)
	        {
                if (id | nombre | apellido | dni)
                {
                    query += " and";
                }

                query += " Telefono = " + entidad.Telefono;
                telefono = true;
	        }
            if (entidad.Contraseña != null)
	        {
                if (id | nombre | apellido | dni | telefono)
                {
                    query += " and";
                }

                query += " Contraseña = " + entidad.Contraseña;
                contraseña = true;
	        }
            if (entidad.Estado != -1)
            {
                if (id | nombre | apellido | dni | telefono | contraseña)
                {
                    query += " and";
                }
               
                query += " Estado = " + entidad.Estado;
            }

            query += ";";

            List<clsProfesor> res = new List<clsProfesor>();

            DataTable dt;

            try
            {
                dt = dbmanager.Consultar(query);
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsProfesor p = new clsProfesor();
                
                p.Id = Convert.ToInt32(item["IdProfesor"]);
                p.Nombre = Convert.ToString(item["Nombre"]);
                p.Apellido = Convert.ToString(item["Apellido"]);
                p.Dni = Convert.ToString(item["Dni"]);
                p.Telefono = Convert.ToString(item["Telefono"]);
                p.Contraseña = Convert.ToString(item["Contraseña"]);
                p.Estado = Convert.ToInt32(item["Estado"]);

                res.Add(p);
            }

            return res;
            
        }

        public List<clsProfesor> ListarProfesores()
        {
            List<clsProfesor> res = new List<clsProfesor>();

            DataTable dt;

            try
            {
                dt = dbmanager.Consultar("select * from Profesores;");
            }
            catch (Exception e)
            {
                
                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsProfesor p = new clsProfesor();

                p.Id = Convert.ToInt32(item["IdProfesor"]);
                p.Nombre = Convert.ToString(item["Nombre"]);
                p.Apellido = Convert.ToString(item["Apellido"]);
                p.Dni = Convert.ToString(item["Dni"]);
                p.Telefono = Convert.ToString(item["Telefono"]);
                p.Contraseña = Convert.ToString(item["Contraseña"]);
                p.Estado = Convert.ToInt32(item["Estado"]);

                res.Add(p);
            }

            return res;
        }

        public int AgregarDictaCurso(int IdProfesor, int IdCurso)
        {
            int filas;

            string query = "insert Dicta values ('" + IdProfesor + "','" + IdCurso + "');";

            try
            {
                filas = dbmanager.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {

                throw e;
            }
            return filas;
        }

        public int UpdateDictaCurso(int IdProfesorOld, int IdCursoOld, int IdProfesorNew, int IdCursoNew)
        {
            int filas;

            string query = "Update Dicta set IdProfesor = '" + IdProfesorNew + "', IdCurso = '" + IdCursoNew + "' where IdProfesor = " + IdProfesorOld + " and IdCurso = " + IdCursoOld + ";";

            try
            {
                filas = dbmanager.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {

                throw e;
            }

            return filas;
        }

        public int DeleteDictaCurso(int IdProfesor, int IdCurso)
        {
            int filas;

            string query = "delete Dicta where IdProfesor = " + IdProfesor + " and IdCurso = " + IdCurso + ";";

            try
            {
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
