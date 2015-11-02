﻿using System;
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
                string query = "INSERT INTO Alumnos VALUES('" + entidad.Contraseña + "','" + entidad.Nombre + "','" + entidad.Apellido + "','" + entidad.Dni + "','" + entidad.Telefono + "','" + entidad.Estado + "','" + entidad.Direccion + "','" + entidad.Email + "');";
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
                string query = "UPDATE Alumnos Set Dni='" + entidad.Dni 
                                + "', Nombre='" + entidad.Nombre 
                                + "', Apellido='" + entidad.Apellido 
                                + "', Direccion='" + entidad.Direccion 
                                + "', Telefono='" + entidad.Telefono 
                                + "', Email='" + entidad.Email 
                                + "', Estado='" + entidad.Estado 
                                + "', Contraseña = '" + entidad.Contraseña 
                                + "' WHERE IdAlumno =" + entidad.Id + ";";
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
            string query = string.Empty;
            bool id = false,dni = false,nombre = false,apellido = false,direccion = false,telefono = false,email = false, contraseña = false;

            if (entidad.Id != -1 || entidad.Nombre != null || entidad.Apellido != null || entidad.Dni != null || entidad.Telefono != null || entidad.Contraseña != null || entidad.Estado != -1 || entidad.Direccion != null || entidad.Email != null)
            {
                query = "SELECT * FROM Alumnos WHERE";

                if (entidad.Id != -1)
                {
                    query += " IdAlumno = '" + entidad.Id + "'";
                    id = true;
                }
                if (entidad.Dni != null)
                {
                    if (id)
                    {
                        query += " AND";
                    }
                    query += " Dni LIKE '" + entidad.Dni + "%'";
                    dni = true;
                }
                if (entidad.Apellido != null)
                {
                    if (id || dni)
                    {
                        query += " AND";
                    }
                    query += " Apellido LIKE '" + entidad.Apellido + "%'";
                    apellido = true;
                }
                if (entidad.Direccion != null)
                {
                    if (id || dni || apellido)
                    {
                        query += " AND";
                    }
                    query += " Direccion LIKE '" + entidad.Direccion + "%'";
                    direccion = true;
                }
                if (entidad.Email != null)
                {
                    if (id || dni || apellido || direccion)
                    {
                        query += " AND";
                    }
                    query += " Email LIKE '" + entidad.Email + "%'";
                    email = true;
                }
                if (entidad.Nombre != null)
                {
                    if (id || dni || apellido || direccion || email)
                    {
                        query += " AND";
                    }
                    query += " Nombre LIKE '" + entidad.Nombre + "%'";
                    nombre = true;
                }
                if (entidad.Telefono != null)
                {
                    if (id || dni || apellido || direccion || email || nombre)
                    {
                        query += " AND";
                    }
                    query += " Telefono LIKE '" + entidad.Telefono + "%'";
                    telefono = true;
                }
                if (entidad.Contraseña != null)
                {
                    if (id | dni | apellido | direccion | email | nombre | telefono)
                    {
                        query += " AND";
                    }

                    query += " Contraseña = '" + entidad.Contraseña + "'";
                    contraseña = true;
                }
                if (entidad.Estado != -1)
                {
                    if (id || dni || apellido || direccion || email || nombre || contraseña || telefono)
                    {
                        query += " AND";
                    }
                    query += " Estado = '" + entidad.Estado + "'";
                }
            }
            else
            {
                query = "SELECT * FROM Alumnos";
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
                a.Dni = Convert.ToString(dr["Dni"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.Apellido = Convert.ToString(dr["Apellido"]);
                a.Direccion = Convert.ToString(dr["Direccion"]);
                a.Telefono = Convert.ToString(dr["Telefono"]);
                a.Email = Convert.ToString(dr["Email"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);
                a.Contraseña = Convert.ToString(dr["Contraseña"]);

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
                a.Dni = Convert.ToString(dr["Dni"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.Apellido = Convert.ToString(dr["Apellido"]);
                a.Direccion = Convert.ToString(dr["Direccion"]);
                a.Telefono = Convert.ToString(dr["Telefono"]);
                a.Email = Convert.ToString(dr["Email"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);
                a.Contraseña = Convert.ToString(dr["Contraseña"]);

                list.Add(a);
            }

            return list;
        }
    }
}
