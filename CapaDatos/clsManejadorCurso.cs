using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;
using System.Globalization;

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
                string query = "INSERT INTO Cursos VALUES('" + entidad.Nombre + "','" + String.Format("{0:s}",entidad.FechaInicio) + "','" + String.Format("{0:s}", entidad.FechaFin) + "','" + entidad.Descripcion + "','" + entidad.Estado + "'," + String.Format(CultureInfo.InvariantCulture, "{0:00.00}", entidad.Precio) + ");";
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
                string query = "UPDATE Cursos Set Nombre='" + entidad.Nombre + "', FechaInicio='" + String.Format("{0:s}", entidad.FechaInicio) + "', FechaFin='" + String.Format("{0:s}", entidad.FechaFin) + "', Descripcion='" + entidad.Descripcion + "', Estado='" + entidad.Estado + "', Precio = " + String.Format(CultureInfo.InvariantCulture, "{0:00.00}", entidad.Precio) + " WHERE IdCurso =" + entidad.Id + ";";
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

            string query = string.Empty;
            bool id = false,fechaI = false,fechaF = false,descripcion = false,nombre = false, precio = false;

            if (entidad.Id != -1 || entidad.Nombre != null || entidad.FechaInicio != DateTime.MinValue || entidad.FechaFin != DateTime.MinValue || entidad.Descripcion != null || entidad.Precio != -1 || entidad.Estado != -1)
            {

                query = "SELECT * FROM Cursos WHERE";
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
                    query += " Nombre LIKE '" + entidad.Nombre + "%'";
                    nombre = true;
                }
                if (entidad.FechaInicio != DateTime.MinValue)
                {
                    if (id || nombre)
                    {
                        query += " AND";
                    }
                    query += " FechaInicio >= " + "'" + String.Format("{0:s}", entidad.FechaInicio) + "'";
                    fechaI = true;
                }
                if (entidad.FechaFin != DateTime.MinValue)
                {
                    if (id || nombre || fechaI)
                    {
                        query += " AND";
                    }
                    query += " FechaFin <= " + "'" + String.Format("{0:s}", entidad.FechaFin) + "'";
                    fechaF = true;
                }
                if (entidad.Descripcion != null)
                {
                    if (id || nombre || fechaI || fechaF)
                    {
                        query += " AND";
                    }
                    query += " Descripcion LIKE '" + entidad.Descripcion + "%'";
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
            }
            else
            {
                query = "SELECT * FROM Cursos";
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

        public List<clsCursoFormateado> ListarCursosFormateados()
        {
            List<clsCursoFormateado> list = new List<clsCursoFormateado>();
            DataTable dt;
            string query = "Select distinct Cursos.IdCurso ,Cursos.Nombre ,Cursos.FechaInicio ,Cursos.FechaFin,Cursos.Estado ,(Cuotas.conteo * Cursos.Precio) as 'Recaudado' ,(inscriptos.cantidad * Cursos.Precio) as 'Esperado' ," +
                            "(Case when Cursos.Precio ='0' then '0' else(((Cuotas.[conteo ] * Cursos.Precio)*100)/(inscriptos.cantidad * Cursos.Precio)) End) as \"Pagado\" " +
                            "from Cursos ," +
                            "( " +
                            "select Cuota.IdCurso ,COUNT(Cuota.IdCurso) as \"conteo \" " +
                            "from  Cuota " +
                            "group by Cuota.IdCurso " +
                            ") as \"Cuotas\" , " +
                            "(" +
                            "Select Asiste.IdCurso,COUNT(Asiste.IdCurso) as \"cantidad\" " +
                            "from Asiste " +
                            "where Asiste.Estado = '1' " +
                            "group by Asiste.IdCurso " +
                            ") as \"inscriptos\" ,Cuota " +
                            "where Cursos.IdCurso = Cuotas.IdCurso " +
                            "and " +
                            "Cursos.IdCurso = inscriptos.IdCurso ";

            try
            {
                dt = dbman.Consultar(query);
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsCursoFormateado c = new clsCursoFormateado();

                c.Id = Convert.ToInt32(item["IdCurso"]);
                c.Nombre = Convert.ToString(item["Nombre"]);
                c.FechaInicio = Convert.ToDateTime(item["FechaInicio"]);
                c.FechaFin = Convert.ToDateTime(item["FechaFin"]);
                c.Estado = Convert.ToInt32(item["Estado"]);
                c.Recaudado = Convert.ToDouble(item["Recaudado"]);
                c.Esperado = Convert.ToDouble(item["Esperado"]);
                c.Porcentaje_pagado = Convert.ToDouble(item["Pagado"]);
                list.Add(c);
            }

            return list;

        }

        public List<clsCursoFormateado> ListarCursosFormateados(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            List<clsCursoFormateado> list = new List<clsCursoFormateado>();
            DataTable dt;
            string query = "Select distinct Cursos.IdCurso ,Cursos.Nombre ,Cursos.FechaInicio ,Cursos.FechaFin,Cursos.Estado ,(Cuotas.conteo * Cursos.Precio) as 'Recaudado' ,(inscriptos.cantidad * Cursos.Precio) as 'Esperado' ," +
                            "(((Cuotas.conteo * Cursos.Precio)*100)/(inscriptos.cantidad * Cursos.Precio)) as \"Pagado\" " +
                            "from Cursos ," +
                            "( " +
                            "select Cuota.IdCurso ,COUNT(Cuota.IdCurso) as \"conteo \" " +
                            "from  Cuota " +
                            "group by Cuota.IdCurso " +
                            ") as \"Cuotas\" , " +
                            "(" +
                            "Select Asiste.IdCurso,COUNT(Asiste.IdCurso) as \"cantidad\" " +
                            "from Asiste " +
                            "where Asiste.Estado = '1' " +
                            "group by Asiste.IdCurso " +
                            ") as \"inscriptos\" ,Cuota " +
                            "where Cursos.IdCurso = Cuotas.IdCurso " +
                            "and " +
                            "Cursos.IdCurso = inscriptos.IdCurso " +
                            "and " +
                            "Cuota.Fecha between '" + Fecha_Inicio.Date.ToString() + "' and '" + Fecha_Fin.Date.ToString() + "';";

            try
            {
                dt = dbman.Consultar(query);
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsCursoFormateado c = new clsCursoFormateado();
                c.Id = Convert.ToInt32(item["IdCurso"]);
                c.Nombre = Convert.ToString(item["Nombre"]);
                c.FechaInicio = Convert.ToDateTime(item["FechaInicio"]);
                c.FechaFin = Convert.ToDateTime(item["FechaFin"]);
                c.Estado = Convert.ToInt32(item["Estado"]);
                c.Recaudado = Convert.ToDouble(item["Recaudado"]);
                c.Esperado = Convert.ToDouble(item["Esperado"]);
                c.Porcentaje_pagado = Convert.ToDouble(item["Pagado"]);
                list.Add(c);
            }

            return list;
        }
    }
}
