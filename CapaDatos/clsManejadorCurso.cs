using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;

namespace CapaDatos
{
    public class clsManejadorCurso
    {
        clsDBManager dbman = new clsDBManager();

        public int InsertCurso(clsCurso entidad)
        {
            int filas;
            try
            {
                //idCurso,Nombre,FechaInicio,FechaFin,Descripcion,Estado,Precio
                string query = "INSERT INTO Cursos VALUES('" + entidad.Nombre + "','" + String.Format("{0:s}",entidad.FechaInicio) + "','" + String.Format("{0:s}", entidad.FechaFin) + "','" + entidad.Descripcion + "','" + entidad.Estado + "','" + entidad.Precio + "');";
                filas = dbman.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int UpdateCurso(clsCurso entidad)
        {
            int filas;
            try
            {
                string query = "UPDATE Cursos Set Nombre='" + entidad.Nombre + "', FechaInicio='" + String.Format("{0:s}", entidad.FechaInicio) + "', FechaFin='" + String.Format("{0:s}", entidad.FechaFin) + "', Descripcion='" + entidad.Descripcion + "', Estado='" + entidad.Estado + "', Precio = "+ entidad.Precio + "' WHERE IdCurso =" + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int DeleteCurso(clsCurso entidad)
        {
            int filas;
            try
            {
                string query = "DELETE Cursos WHERE IdCurso = " + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ELIMINAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public List<clsCurso> SelectCurso(clsCurso entidad)
        {
            bool id = false,fechaI = false,fechaF = false,descripcion = false,nombre = false, precio = false;

            string query = "SELECT * FROM Alumnos WHERE";
            if (entidad.Id != -1)
            {
                query += " IdCurso = " + entidad.Id;
                id = true;
            }
            if (entidad.Nombre != null)
            {
                if (id)
                {
                    query += " AND";
                }
                query += " Nombre LIKE " + entidad.Nombre + "%";
                nombre = true;
            }
            if (entidad.FechaInicio != null)
            {
                if (id || nombre)
                {
                    query += " AND";
                }
                query += " FechaInicio >= " + String.Format("{0:s}", entidad.FechaInicio);
                fechaI = true;
            }
            if (entidad.FechaFin != null)
            {
                if (id || nombre || fechaI)
                {
                    query += " AND";
                }
                query += " FechaFin <= " + String.Format("{0:s}", entidad.FechaFin);
                fechaF = true;
            }
            if (entidad.Descripcion != null)
            {
                if (id || nombre || fechaI || fechaF)
                {
                    query += " AND";
                }
                query += " Descripcion LIKE " + entidad.Descripcion + "%";
                descripcion = true;
            }
            if (entidad.Precio != -1)
            {
                if (id | nombre | fechaI | fechaF | descripcion)
                {
                    query += " AND";
                }

                query += " Precio = " + entidad.Precio;
                precio = true;
            }
            if (entidad.Estado != -1)
            {
                if (id || nombre || fechaI || fechaF || descripcion | precio)
                {
                    query += " AND";
                }
                query += " Estado = " + entidad.Estado;
            }

            query += ";";

            List<clsCurso> list = new List<clsCurso>();
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
                clsCurso a = new clsCurso();

                a.Id = Convert.ToInt32(dr["IdCurso"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                a.FechaFin = Convert.ToDateTime(dr["FechaFin"]);
                a.Descripcion = Convert.ToString(dr["Descripcion"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);
                a.Precio = Convert.ToDouble(dr["Precio"]);

                list.Add(a);
            }

            return list;
        }

        public List<clsCurso> ListarCursos()
        {
            List<clsCurso> list = new List<clsCurso>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar("SELECT * FROM Cursos;");
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsCurso a = new clsCurso();

                a.Id = Convert.ToInt32(dr["IdCurso"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                a.FechaFin = Convert.ToDateTime(dr["FechaFin"]);
                a.Descripcion = Convert.ToString(dr["Descripcion"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);
                a.Precio = Convert.ToDouble(dr["Precio"]);

                list.Add(a);
            }

            return list;
        }
    }
}
