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
        clsManejadorAdministrador manager = new clsManejadorAdministrador();

        private clsAdministrador getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsAdministrador)))
                return (clsAdministrador)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            clsManejadorAlumno amanager = new clsManejadorAlumno();
            clsManejadorProfesor pmanager = new clsManejadorProfesor();

            clsAdministrador administrador = new clsAdministrador();
            clsAlumno alumno = new clsAlumno();
            clsProfesor profesor = new clsProfesor();

            try
            {
                administrador = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            clsAdministrador compare = new clsAdministrador();
            compare.Usuario = administrador.Usuario;
            alumno.Dni = administrador.Usuario;
            profesor.Dni = administrador.Usuario;

            try
            {
                if (manager.SelectAdministrador(compare).Count == 0 && amanager.SelectAlumno(alumno).Count == 0 && pmanager.SelectProfesor(profesor).Count == 0)
                {
                    manager.InsertAdministrador(administrador);
                }
                else
                    throw new ArgumentException("Ese nombre de usuario ya esta en uso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Actualizar(IEntidad entidad)
        {
            clsAdministrador administrador = new clsAdministrador();

            try
            {
                administrador = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.UpdateAdministrador(administrador);
                if (filas == 0)
                {
                    throw new ArgumentException("El usuario no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(IEntidad entidad)
        {
            clsAdministrador administrador = new clsAdministrador();

            try
            {
                administrador = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.DeleteAdministrador(administrador);
                if (filas == 0)
                {
                    throw new ArgumentException("El usuario no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {
            clsAdministrador administrador = new clsAdministrador();
            administrador.Id = id;
            clsAdministrador nadministrador = null;

            try
            {
                nadministrador = manager.SelectAdministrador(administrador)[0];
                if (nadministrador == null)
                {
                    throw new ArgumentException("El usuario no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return nadministrador;
        }

        public List<IEntidad> Lista()
        {
            List<IEntidad> list = new List<IEntidad>();

            try
            {
                list.AddRange(manager.ListarAdministradores());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista(IEntidad filtro)
        {
            clsAdministrador administrador = new clsAdministrador();

            List<IEntidad> list = new List<IEntidad>();

            try
            {
                administrador = getCast(filtro);
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                list.AddRange(manager.SelectAdministrador(administrador));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public IEntidad Login(string usuario, string contraseña, NivelSeguridad nivel)
        {
            if (nivel == NivelSeguridad.ADMINISTRADOR)
            {
                clsAdministrador consulta = new clsAdministrador();
                clsAdministrador result;
                try
                {
                    //consulta.Nombre = string.Empty;
                    consulta.Usuario = usuario;
                    consulta.Contraseña = contraseña;
                    //consulta.Apellido = string.Empty;
                    //consulta.Dni = -1;
                    //consulta.Estado = 1;
                    //consulta.Id = -1;
                    //consulta.Telefono = string.Empty;
                    List<clsAdministrador> resultados = manager.SelectAdministrador(consulta);
                    if (resultados.Count() != 0)
                    {
                        result = resultados[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception a)
                {
                    throw (a);
                }
                return (result);
            }
            else if (nivel == NivelSeguridad.PROFESOR)
            {
                clsManejadorProfesor pmanager = new clsManejadorProfesor();
                clsProfesor consulta = new clsProfesor();
                clsProfesor result;
                try
                {
                    consulta.Dni = Convert.ToInt32(usuario);
                    consulta.Contraseña = contraseña;

                    List<clsProfesor> resultados = pmanager.SelectProfesor(consulta);
                    if (resultados.Count() != 0)
                    {
                        result = resultados[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception a)
                {
                    throw (a);
                }
                return (result);
            }
            else
            {
                clsManejadorAlumno amanager = new clsManejadorAlumno();
                clsAlumno consulta = new clsAlumno();
                clsAlumno result;
                try
                {
                    consulta.Dni = Convert.ToInt32(usuario);
                    consulta.Contraseña = contraseña;

                    List<clsAlumno> resultados = amanager.SelectAlumno(consulta);
                    if (resultados.Count() != 0)
                    {
                        result = resultados[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception a)
                {
                    throw (a);
                }
                return (result);
            }
        }
    }
}
