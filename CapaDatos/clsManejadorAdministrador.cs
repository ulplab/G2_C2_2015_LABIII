using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;

namespace CapaDatos
{
    public class clsManejadorAdministrador
    {
        clsDBManager dbman = new clsDBManager();

        public int InsertAdministrador(clsAdministrador entidad)
        {
            int filas;
            try
            {
                //IdAdministrador,Usuario,Contraseña,Nombre,Apellido,Dni,Telefono,Estado
                string query = "INSERT INTO Administradores VALUES(" + "'" + entidad.Usuario + "','" + entidad.Contraseña + "','" + entidad.Nombre + "','" + entidad.Apellido + "','" + entidad.Dni + "','" + entidad.Telefono + "','" + entidad.Estado + "');";
                filas = dbman.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int UpdateAdministrador(clsAdministrador entidad)
        {
            int filas;
            try
            {
                string query = "UPDATE Administradores Set Usuario = '" + entidad.Usuario + "', Contraseña = '" + entidad.Contraseña + "', Nombre = '" + entidad.Nombre + "', Apellido = '" + entidad.Apellido + "', Dni = " + entidad.Dni + ", Telefono = '" + entidad.Telefono + "', Estado = '" + entidad.Estado + "' WHERE IdAdministrador =" + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int DeleteAdministrador(clsAdministrador entidad)
        {
            int filas;
            try
            {
                string query = "DELETE Administradores WHERE IdAdministrador = " + entidad.Id + ";";
                filas = dbman.Ejecutar(query, Tipo.ELIMINAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public List<clsAdministrador> SelectAdministrador(clsAdministrador entidad)
        {
            string query;
            bool id = false, dni = false, nombre = false, apellido = false, usuario = false, telefono = false, contraseña = false;

            if (entidad.Id != -1 || entidad.Dni != null || entidad.Apellido != null || entidad.Nombre != null || entidad.Usuario != null || entidad.Contraseña != null || entidad.Telefono != null || entidad.Estado != -1)
            {

                query = "SELECT * FROM Administradores WHERE";
                if (entidad.Id != -1)
                {
                    query += " IdAdministrador = '" + entidad.Id + "' ";
                    id = true;
                }
                if (entidad.Dni != null)
                {
                    if (id)
                    {
                        query += " AND";
                    }
                    query += " Dni LIKE '" + entidad.Dni + "%' ";
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
                if (entidad.Usuario != null)
                {
                    if (id || dni || apellido)
                    {
                        query += " AND";
                    }
                    query += " Usuario LIKE '" + entidad.Usuario + "%'";
                    usuario = true;
                }
                if (entidad.Contraseña != null)
                {
                    if (id || dni || apellido || usuario)
                    {
                        query += " AND";
                    }
                    query += " Contraseña = '" + entidad.Contraseña + "'";
                    contraseña = true;
                }
                if (entidad.Nombre != null)
                {
                    if (id || dni || apellido || usuario || contraseña)
                    {
                        query += " AND";
                    }
                    query += " Nombre LIKE '" + entidad.Nombre + "%'";
                    nombre = true;
                }
                if (entidad.Telefono != null)
                {
                    if (id || dni || apellido || usuario || contraseña || nombre)
                    {
                        query += " AND";
                    }
                    query += " Telefono = '" + entidad.Telefono + "'";
                    telefono = true;
                }
                if (entidad.Estado != -1)
                {
                    if (id || dni || apellido || usuario || contraseña || nombre || telefono)
                    {
                        query += " AND";
                    }
                    query += " Estado = '" + entidad.Estado + "'";
                }
            }
            else
            {
                query = "SELECT * FROM Administradores WHERE";
            }

            query += ";";

            List<clsAdministrador> list = new List<clsAdministrador>();
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
                clsAdministrador a = new clsAdministrador();

                a.Id = Convert.ToInt32(dr["IdAdministrador"]);
                a.Dni = Convert.ToString(dr["Dni"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.Apellido = Convert.ToString(dr["Apellido"]);
                a.Usuario = Convert.ToString(dr["Usuario"]);
                a.Telefono = Convert.ToString(dr["Telefono"]);
                a.Contraseña = Convert.ToString(dr["Contraseña"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }

        public List<clsAdministrador> ListarAdministradores()
        {
            List<clsAdministrador> list = new List<clsAdministrador>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar("SELECT * FROM Administradores;");
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsAdministrador a = new clsAdministrador();

                a.Id = Convert.ToInt32(dr["IdAdministrador"]);
                a.Dni = Convert.ToString(dr["Dni"]);
                a.Nombre = Convert.ToString(dr["Nombre"]);
                a.Apellido = Convert.ToString(dr["Apellido"]);
                a.Usuario = Convert.ToString(dr["Usuario"]);
                a.Telefono = Convert.ToString(dr["Telefono"]);
                a.Contraseña = Convert.ToString(dr["Contraseña"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }
    }
}
