﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;

namespace CapaDatos
{
    public class clsManejadorCuota
    {
        clsDBManager dbManager = new clsDBManager();

        public int InsertarCuota(clsCuota entidad)
        {
            //idCuota, IdAlumno, IdCurso, Fecha
            String query = "insert Cuota values('" + entidad.IdAlumno + "','" + entidad.IdCurso + "','" + String.Format("{0:s}", entidad.Fecha) + "');";
            int filas;

            try
            {
                filas = dbManager.Ejecutar(query, Interfaces.Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                
                throw e;
            }

            return filas;
        }

        public int UpdateCuota(clsCuota entidad)
        {
            int filas;

            string query = "update Cuota set IdCurso= " + entidad.IdCurso
                        + " IdAlumno = " + entidad.IdAlumno
                        + " Fecha = " + entidad.Fecha 
                        + " where IdCuota = " + entidad.Id + ";";

            try
            {
                filas = dbManager.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {

                throw e;
            }

            return filas;
        }

        public int DeleteCuota(clsCuota entidad)
        {
            int filas = 0;

            string query = "delete Cuota where IdCuota = " + entidad.Id + ";";

            try
            {
                filas = dbManager.Ejecutar(query, Tipo.ELIMINAR);
            }
            catch (Exception e)
            {

                throw e;
            }

            return filas;
        }

        public List<clsCuota> SelectCuota(clsCuota entidad)
        {
            List<clsCuota> list = new List<clsCuota>();
            bool cuota = false, alumno = false, curso = false;
            DataTable dt;

            string query = "select * from Cuota where";
            if (entidad.Id != -1)
            {
                query += " IdCuota= '" + entidad.Id + "'";
                cuota = true;
            }
            if (entidad.IdAlumno != -1)
            {
                if (cuota)
                {
                    query += " and";
                }
                query += " IdAlumno= '" + entidad.IdAlumno + "'";
                alumno = true;
            }
            if (entidad.IdCurso != -1)
            {
                if (cuota | alumno)
                {
                    query += " and";
                }
                query += " IdCurso= '" + entidad.IdCurso + "'";
                curso = true;
            }
            if (DateTime.Compare(entidad.Fecha , Convert.ToDateTime("01/01/0001 0:00:00")) != 0)
            {
                if (cuota | alumno | curso)
                {
                    query += " and";
                }
                query += " Fecha = " + String.Format("{0:s}", entidad.Fecha);
            }

            query += ";";

            try
            {
                dt = dbManager.Consultar(query);
            }
            catch (Exception e)
            {
                
                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsCuota c = new clsCuota();

                c.Id = Convert.ToInt32(item["IdCuota"]);
                c.IdAlumno = Convert.ToInt32(item["IdAlumno"]);
                c.IdCurso = Convert.ToInt32(item["IdCurso"]);
                c.Fecha = Convert.ToDateTime(item["Fecha"]);

                list.Add(c);
            }

            return list;
        }

        public List<clsCuota> ListarCuota()
        {
            List<clsCuota> list = new List<clsCuota>();
            DataTable dt;
            string query = "select * from Cuota";

            try
            {
                dt = dbManager.Consultar(query);
            }
            catch (Exception e)
            {
                
                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsCuota c = new clsCuota();

                c.Id = Convert.ToInt32(item["IdCuota"]);
                c.IdAlumno = Convert.ToInt32(item["IdAlumno"]);
                c.IdCurso = Convert.ToInt32(item["IdCurso"]);
                c.Fecha = Convert.ToDateTime(item["Fecha"]);

                list.Add(c);
            }

            return list;
        }

        public List<clsCuotaFormateada> ListarCuotaFormateada()
        {
            List<clsCuotaFormateada> list = new List<clsCuotaFormateada>();
            DataTable dt;
            string query = "Select Cuota.IdCuota as 'IdCuota', Cursos.Nombre as 'Curso' , Alumnos.Nombre  as 'Alumno', Cursos.Precio as 'Monto', Cuota.Fecha " + 
            "from Cursos,Alumnos,Cuota "+
            "where Cursos.IdCurso = Cuota.IdCurso "+
	        "and " +
	        "Alumnos.IdAlumno = Cuota.IdAlumno; ";

            try
            {
                dt = dbManager.Consultar(query);
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsCuotaFormateada c = new clsCuotaFormateada();

                c.Id = Convert.ToInt32(item["IdCuota"]);
                c.IdAlumno = Convert.ToString(item["Alumno"]);
                c.IdCurso = Convert.ToString(item["Curso"]);
                c.Fecha = Convert.ToDateTime(item["Fecha"]);
                c.Precio = Convert.ToDouble(item["Monto"]);
                list.Add(c);
            }

            return list;
        }

        public List<clsCuotaFormateada> ListarCuotaFormateada(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            List<clsCuotaFormateada> list = new List<clsCuotaFormateada>();
            DataTable dt;
            string query = "Select Cuota.IdCuota as 'IdCuota', Cursos.Nombre as 'Curso' , Alumnos.Nombre  as 'Alumno', Cursos.Precio as 'Monto', Cuota.Fecha as 'Fecha'" +
            "from Cursos,Alumnos,Cuota " +
            "where Cursos.IdCurso = Cuota.IdCurso " +
            "and " +
            "Alumnos.IdAlumno = Cuota.IdAlumno " +
            "and " +
            "( Cuota.fecha between '" + Fecha_Inicio.Date.ToString() + "' and '" + Fecha_Fin.Date.ToString() + "');"; 
            
            try
            {
                dt = dbManager.Consultar(query);
            }
            catch (Exception e)
            {

                throw e;
            }

            foreach (DataRow item in dt.Rows)
            {
                clsCuotaFormateada c = new clsCuotaFormateada();

                c.Id = Convert.ToInt32(item["IdCuota"]);
                c.IdAlumno = Convert.ToString(item["Alumno"]);
                c.IdCurso = Convert.ToString(item["Curso"]);
                c.Fecha = Convert.ToDateTime(item["Fecha"]);
                c.Precio = Convert.ToDouble(item["Monto"]);

                list.Add(c);
            }

            return list;
        }

    }
}
