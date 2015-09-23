using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Clases;
using System.Data;
using CapaDatos;


namespace CapaLogica
{
    public class clsRepositorioAdministrador : IRepositorio
    {
        IDBManager DBManager = new clsDBManager();

        private clsAdministrador getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsAdministrador)))
                return (clsAdministrador)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            DataTable dt = new DataTable();

            try
            {
                entidad = getCast(entidad);
                dt = DBManager.Consultar("SELECT * FROM Administradores;");

                foreach (DataRow r in dt.Rows)
                {
                    if (r["Usuario"].ToString() == ((clsAdministrador)entidad).Usuario)
                    {
                        throw new ArgumentException("El usuario ya existe");
                    }
                }

                DBManager.Ejecutar("INSERT INTO Administradores VALUES(" + "'" +((clsAdministrador)entidad).Usuario + "','" + ((clsAdministrador)entidad).Contraseña + "','" + ((clsAdministrador)entidad).Nombre + "','" + ((clsAdministrador)entidad).Apellido + "','" + ((clsAdministrador)entidad).Dni + "','" + ((clsAdministrador)entidad).Telefono + "','" + ((clsAdministrador)entidad).Estado + "');", Tipo.INSERTAR);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            

        }

        public void Actualizar(IEntidad entidad)
        {

            try
            {
                entidad = getCast(entidad);
                int filaAfectada;

                filaAfectada = DBManager.Ejecutar("UPDATE Administradores Set Usuario = '" + ((clsAdministrador)entidad).Usuario + "', Contraseña = '" + ((clsAdministrador)entidad).Contraseña + "', Nombre = '" + ((clsAdministrador)entidad).Nombre + "', Apellido = '" + ((clsAdministrador)entidad).Apellido + "', Dni = " + ((clsAdministrador)entidad).Dni + ", Telefono = '" + ((clsAdministrador)entidad).Telefono + "', Estado = '" + ((clsAdministrador)entidad).Estado + "' WHERE IdAdministrador =" + entidad.Id + ";", Tipo.ACTUALIZAR);

                if (filaAfectada == 0)
                {
                    throw new ArgumentException("Error al Actualizar");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar(IEntidad entidad)
        {

            try
            {
                entidad = getCast(entidad);
                int filaAfectada;

                filaAfectada = DBManager.Ejecutar("DELETE Administradores WHERE IdAdministrador = "+entidad.Id + ";", Tipo.ELIMINAR);

                if (filaAfectada == 0)
                {
                    throw new ArgumentException("Error al Eliminar");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {

            DataTable dt = new DataTable();
            clsAdministrador A = new clsAdministrador();
            try
            {

                dt = DBManager.Consultar("SELECT * FROM Cuentas WHERE IdAdministrador="+id);

                if (dt == null)
                {
                    throw new ArgumentException("Cuenta Inexistente");
                }
                else
                {
                    A.Id = Convert.ToInt32(dt.Rows[0]["IdAdministrador"]);
                    A.Usuario = dt.Rows[0]["Usuario"].ToString();
                    A.Contraseña = dt.Rows[0]["Contraseña"].ToString();
                    A.Nombre = dt.Rows[0]["Nombre"].ToString();
                    A.Apellido= dt.Rows[0]["Apellido"].ToString();
                    A.Dni = Convert.ToInt32(dt.Rows[0]["Contraseña"]);
                    A.Telefono = dt.Rows[0]["Telefono"].ToString();
                    A.Estado = Convert.ToBoolean(dt.Rows[0]["Estado"]);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return A;

        }

        public List<IEntidad> Lista()
        {
            DataTable dt = new DataTable();
            List<IEntidad> AL = new List<IEntidad>();

            try
            {
                dt = DBManager.Consultar("SELECT * FROM Administradores;");

                foreach (DataRow r in dt.Rows)
                {
                    clsAdministrador A = new clsAdministrador();
                    A.Id = Convert.ToInt32(r["IdAdministrador"]);
                    A.Usuario = r["Usuario"].ToString();
                    A.Contraseña = r["Contraseña"].ToString();
                    A.Nombre = r["Nombre"].ToString();
                    A.Apellido = r["Apellido"].ToString();
                    A.Dni = Convert.ToInt32(r["Dni"]);
                    A.Telefono = r["Telefono"].ToString();
                    A.Estado = Convert.ToBoolean(r["Estado"]);

                    AL.Add(A);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return AL;
        }

        public List<IEntidad> Lista(string filtro)
        {
            DataTable dt = new DataTable();
            List<IEntidad> AL = new List<IEntidad>();

            try
            {
                dt = DBManager.Consultar(filtro);

                foreach (DataRow r in dt.Rows)
                {
                    clsAdministrador A = new clsAdministrador();
                    A.Id = Convert.ToInt32(r["IdAdministrador"]);
                    A.Usuario = r["Usuario"].ToString();
                    A.Contraseña = r["Contraseña"].ToString();
                    A.Nombre = r["Nombre"].ToString();
                    A.Apellido = r["Apellido"].ToString();
                    A.Dni = Convert.ToInt32(r["Dni"]);
                    A.Telefono = r["Telefono"].ToString();
                    A.Estado = Convert.ToBoolean(r["Estado"]);

                    AL.Add(A);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return AL;
        }

        public clsAdministrador Login(string user, string pass)
        {

            DataTable dt = new DataTable();
            clsAdministrador ret = null;

            try
            {

                dt = DBManager.Consultar("SELECT * FROM Administradores;");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow r in dt.Rows)
            {
                if (r["Usuario"].ToString() == user && r["Contraseña"].ToString() == pass)
                {
                    ret = new clsAdministrador();
                    ret.Id = Convert.ToInt32(r["IdAdministrador"]);
                    ret.Usuario = r["Usuario"].ToString();
                    ret.Contraseña = r["Contraseña"].ToString();
                    ret.Nombre = r["Nombre"].ToString();
                    ret.Apellido = r["Apellido"].ToString();
                    ret.Dni = Convert.ToInt32(r["Dni"]);
                    ret.Telefono = r["Telefono"].ToString();
                    ret.Estado = Convert.ToBoolean(r["Estado"]);
                }
            }

            return ret;
        }
    

    }
}
