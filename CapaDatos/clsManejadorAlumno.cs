using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;

namespace CapaDatos
{
    public class clsManejadorAlumno
    {
        clsDBManager dbman = new clsDBManager();

        public int InsertAlumno(clsAlumno entidad)
        {
            int filas;
            try
            {
                string query = "INSERT INTO Alumnos VALUES('" + entidad.Dni + "','" + entidad.Nombre + "','" + entidad.Apellido + "','" + entidad.Direccion + "','" + entidad.Telefono + "','" + entidad.Email + "','" + entidad.Estado + "');";
                filas = dbman.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int UpdateAlumno(clsAlumno entidad)
        {
            int filas;
            try
            {
                string query = "UPDATE Alumnos Set Dni=" + entidad.Dni + ", Nombre='" + entidad.Nombre + "', Apellido='" + entidad.Apellido + "', Direccion='" + entidad.Direccion + "', Telefono='" + entidad.Telefono + "', Email='" + entidad.Email + "', Estado='" + entidad.Estado + "' WHERE IdAlumno =" + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int DeleteAlumno(clsAlumno entidad)
        {
            int filas;
            try
            {
                string query = "DELETE Alumnos WHERE IdAlumno = " + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ELIMINAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public List<clsAlumno> SelectAlumno(clsAlumno entidad)
        {
            bool id = false,dni = false,nombre = false,apellido = false,direccion = false,telefono = false,email = false,estado = false;

            string query = "SELECT * FROM Alumnos WHERE";
            if (entidad.Id != null)
            {
                query += " IdAlumno = " + entidad.Id;
                id = true;
            }
            if (entidad.Dni != null)
            {
                if (id)
                {
                    query += " AND";
                }
                query += " Dni = " + entidad.Dni;
                dni = true;
            }
            if (entidad.Apellido != "")
            {
                if (id || dni)
                {
                    query += " AND";
                }
                query += " Apellido = " + entidad.Apellido;
                apellido = true;
            }
            if (entidad.Direccion != "")
            {
                if (id || dni || apellido)
                {
                    query += " AND";
                }
                query += " Direccion = " + entidad.Direccion;
                direccion = true;
            }
            if (entidad.Email != "")
            {
                if (id || dni || apellido || direccion)
                {
                    query += " AND";
                }
                query += " Email = " + entidad.Email;
                email = true;
            }
            if (entidad.Nombre != "")
            {
                if (id || dni || apellido || direccion || email)
                {
                    query += " AND";
                }
                query += " Nombre = " + entidad.Nombre;
                nombre = true;
            }
            if (entidad.Telefono != "")
            {
                if (id || dni || apellido || direccion || email || nombre)
                {
                    query += " AND";
                }
                query += " Nombre = " + entidad.Nombre;
                telefono = true;
            }
            if (entidad.Estado != null)
            {
                if (id || dni || apellido || direccion || email || nombre || telefono)
                {
                    query += " AND";
                }
                query += " Estado = " + entidad.Estado;
            }

            query += ";";

            List<clsAlumno> list = new List<clsAlumno>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar(query);
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsAlumno a = new clsAlumno();

                a.Id = Convert.ToInt32(dr["IdAlumno"]);
                a.Dni = Convert.ToInt32(dr["Dni"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.Apellido = Convert.ToString(dr["Apellido"]);
                a.Direccion = Convert.ToString(dr["Direccion"]);
                a.Telefono = Convert.ToString(dr["Telefono"]);
                a.Email = Convert.ToString(dr["Email"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }

        public List<clsAlumno> ListarAlumnos()
        {
            List<clsAlumno> list = new List<clsAlumno>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar("SELECT * FROM Alumnos;");
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsAlumno a = new clsAlumno();

                a.Id = Convert.ToInt32(dr["IdAlumno"]);
                a.Dni = Convert.ToInt32(dr["Dni"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.Apellido = Convert.ToString(dr["Apellido"]);
                a.Direccion = Convert.ToString(dr["Direccion"]);
                a.Telefono = Convert.ToString(dr["Telefono"]);
                a.Email = Convert.ToString(dr["Email"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }
    }
}
