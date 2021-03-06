﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;
using System.Data.SqlClient;

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
                    + entidad.Estado + "','"
                    + entidad.Direccion + "','"
                    + entidad.Email + "');";

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
                String query = "update Profesores set "
                    + "Nombre = '" + entidad.Nombre
                    + "', Apellido = '" + entidad.Apellido
                    + "', Dni ='" + entidad.Dni 
                    + "', Telefono = '" + entidad.Telefono
                    + "', Contraseña = '" + entidad.Contraseña
                    + "', Estado = '" + entidad.Estado
                    + "', Direccion = '" + entidad.Direccion
                    + "', Email= '" + entidad.Email
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
            bool id = false, nombre = false, apellido = false, dni = false, telefono = false, contraseña = false, estado = false, direccion = false;
            string query = string.Empty;

            if (entidad.Id != -1 || entidad.Nombre != null || entidad.Apellido != null || entidad.Dni != null || entidad.Telefono != null || entidad.Contraseña != null || entidad.Estado != -1 || entidad.Direccion != null || entidad.Email != null)
            {
                query = "select * from Profesores where";


                if (entidad.Id != -1)
                {
                    query += " IdProfesor = '" + entidad.Id + "'";
                    id = true;
                }

                if (entidad.Nombre != null)
                {
                    if (id)
                    {
                        query += " and";
                    }
                    query += " Nombre LIKE '" + entidad.Nombre + "%'";
                    nombre = true;
                }
                if (entidad.Apellido != null)
                {
                    if (id | nombre)
                    {
                        query += " and";
                    }

                    query += " Apellido LIKE '" + entidad.Apellido + "%'";
                    apellido = true;
                }
                if (entidad.Dni != null)
                {
                    if (id | nombre | apellido)
                    {
                        query += " and";
                    }

                    query += " Dni LIKE '" + entidad.Dni + "%'";
                    dni = true;
                }
                if (entidad.Telefono != null)
                {
                    if (id | nombre | apellido | dni)
                    {
                        query += " and";
                    }

                    query += " Telefono LIKE '" + entidad.Telefono + "%'";
                    telefono = true;
                }
                if (entidad.Contraseña != null)
                {
                    if (id | nombre | apellido | dni | telefono)
                    {
                        query += " and";
                    }

                    query += " Contraseña = '" + entidad.Contraseña + "'";
                    contraseña = true;
                }
                if (entidad.Estado != -1)
                {
                    if (id | nombre | apellido | dni | telefono | contraseña)
                    {
                        query += " and";
                    }

                    query += " Estado = " + entidad.Estado;
                    estado = true;
                }
                if (entidad.Direccion != null)
                {
                    if (id | nombre | apellido | dni | telefono | contraseña | estado)
                    {
                        query += " and";
                    }
                    query += " Direccion LIKE '" + entidad.Direccion + "%'";
                    direccion = true;
                }
                if (entidad.Email != null)
                {
                    if (id | nombre | apellido | dni | telefono | contraseña | estado | direccion)
                    {
                        query += " and";
                    }
                    query += " Email LIKE '" + entidad.Email + "%'";
                }
            }
            else
            {
                query = "select * from Profesores";
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
                p.Direccion = Convert.ToString(item["Direccion"]);
                p.Email = Convert.ToString(item["Email"]);

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
                p.Direccion = Convert.ToString(item["Direccion"]);
                p.Email = Convert.ToString(item["Email"]);

                res.Add(p);
            }

            return res;
        }

        public int AgregarDictaCurso(int IdProfesor, int IdCurso)
        {
            int filas;

            //string query = "insert Dicta values ('" + IdProfesor + "','" + IdCurso + "');";

            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[1] = new SqlParameter("@idCurso", IdCurso);
                param[0] = new SqlParameter("@idProfesor", IdProfesor);

                filas = dbmanager.Ejecutar("asignarProfesorCurso", param, Tipo.INSERTAR);
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

                string consulta = "SELECT COUNT(*) as Cantidad FROM Dicta WHERE IdCurso = " + IdCursoNew + " AND IdProfesor = " + IdProfesorNew + ";";
                DataTable dt = dbmanager.Consultar(consulta);
                int cant = Convert.ToInt32(dt.Rows[0]["Cantidad"]);
                if (cant > 1)
                {
                    throw new Exception("El profesor ya ha sido asignado a este curso");
                }
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

        public DataTable ProfesorDicta(int IdProfesor, int IdCurso)
        {
            DataTable dt;
            string query = string.Empty;
            bool profesor = false, curso = false;

            if (IdProfesor != -1 && IdCurso != -1)
            {
                query = "select * from Dicta where";

                if (IdProfesor != -1)
                {
                    query += " IdProfesor= '" + IdProfesor + "'";
                    profesor = true;
                }
                if (IdCurso != -1)
                {
                    if (profesor)
                    {
                        query += " and";
                    }

                    query += " IdCurso = '" + IdCurso + "'";
                    curso = true;
                }
            }
            else
            {
                query = "select * from Dicta";
            }

            query += ";";

            try
            {

                dt = dbmanager.Consultar(query);
            }
            catch (Exception e)
            {   
                
                throw e;
            }

            return dt;
        }

        public int CantidadProfesores(int IdCurso)
        {
            DataTable dt = new DataTable();
            int ret = 0;

            try
            {
                dt = dbmanager.Consultar("SELECT COUNT(*) as Cantidad FROM Dicta d, Cursos c, Profesores p WHERE d.IdCurso = c.IdCurso and d.IdProfesor = p.IdProfesor and c.Estado = 1 and p.Estado = 1 and c.IdCurso = " + IdCurso + ";");
                ret = Convert.ToInt32(dt.Rows[0]["Cantidad"]);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        public int CantidadCursos(int IdProfesor)
        {
            DataTable dt = new DataTable();
            int ret = 0;

            try
            {
                dt = dbmanager.Consultar("SELECT COUNT(*) as Cantidad FROM Dicta, Cursos WHERE Dicta.IdCurso = Cursos.IdCurso and Estado = 1 and Dicta.IdProfesor =" + IdProfesor + ";");
                ret = Convert.ToInt32(dt.Rows[0]["Cantidad"]);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        public DataTable ListaProfesores(int IdCurso)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = dbmanager.Consultar("SELECT A1.IdProfesor,Dni,Nombre,Apellido,Direccion,Telefono,Email,Estado " +
                                            "FROM Profesores as A1, (SELECT IdProfesor " +
                                             "FROM Dicta " +
                                             "WHERE IdCurso = " + IdCurso + " ) as A2 " +
                                         "WHERE A1.IdProfesor = A2.IdProfesor");

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;

        }

        public DataTable ListaCursos(int IdProfesor)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = dbmanager.Consultar("SELECT A1.IdCurso, Nombre, FechaInicio, FechaFin, Descripcion, Estado " +
                                            "FROM Cursos as A1,(SELECT IdCurso " +
                                             "FROM Dicta " +
                                             "WHERE IdProfesor = " + IdProfesor + ") as A2 " +
                                         "WHERE A1.IdCurso = A2.IdCurso");

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable CursosQueNoDicta(int idProfesor)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = dbmanager.Consultar("select * from Cursos where IdCurso not in(select c.IdCurso from Dicta d, cursos c where d.IdCurso = c.IdCurso and IdProfesor = "+ idProfesor + ");");
            }
            catch(Exception e)
            {
                throw e;
            }

            return dt;
        }

        public DataTable CursosQueDicta(int idProfesor)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = dbmanager.Consultar("select * from Dicta, Cursos where Dicta.IdCurso = Cursos.IdCurso and IdProfesor = " + idProfesor + ";");
            }
            catch (Exception e)
            {
                throw e;
            }

            return dt;
        }
    }
}
