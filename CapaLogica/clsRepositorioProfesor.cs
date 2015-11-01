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
    public class clsRepositorioProfesor : IRepositorio
    {
        clsManejadorProfesor manager = new clsManejadorProfesor();

        private clsProfesor getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsProfesor)))
                return (clsProfesor)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            clsManejadorAdministrador amanager = new clsManejadorAdministrador();
            clsManejadorAlumno almanager = new clsManejadorAlumno();

            clsProfesor profesor = new clsProfesor();
            clsAdministrador admin = new clsAdministrador();
            clsAlumno alum = new clsAlumno();

            try
            {
                profesor = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            clsProfesor compare = new clsProfesor();
            compare.Dni = profesor.Dni;
            admin.Usuario = profesor.Dni;
            alum.Dni = profesor.Dni;

            try
            {
                if (manager.SelectProfesor(compare).Count == 0 && amanager.SelectAdministrador(admin).Count == 0 && almanager.SelectAlumno(alum).Count == 0)
                    manager.InsertarProfesor(profesor);
                else
                    throw new ArgumentException("El Profesor ingresado ya existe");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Actualizar(IEntidad entidad)
        {
            clsProfesor profesor = new clsProfesor();

            try
            {
                profesor = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.UpdateProfesor(profesor);
                if (filas == 0)
                {
                    throw new ArgumentException("El profesor no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(IEntidad entidad)
        {
            clsProfesor profesor = new clsProfesor();

            try
            {
                profesor = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.DeleteProfesor(profesor);
                if (filas == 0)
                {
                    throw new ArgumentException("El profesor no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {
            clsProfesor profesor = new clsProfesor();
            profesor.Id = id;
            clsProfesor nalumno = null;

            try
            {
                nalumno = manager.SelectProfesor(profesor)[0];
                if (nalumno == null)
                {
                    throw new ArgumentException("El profesor no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return nalumno;
        }

        public List<IEntidad> Lista()
        {
            List<IEntidad> list = new List<IEntidad>();

            try
            {
                list.AddRange(manager.ListarProfesores());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista(IEntidad filtro)
        {
            clsProfesor alumno = new clsProfesor();

            List<IEntidad> list = new List<IEntidad>();

            try
            {
                alumno = getCast(filtro);
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                list.AddRange(manager.SelectProfesor(alumno));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public void AsignarProfesorACurso(int idProfesor, int idCurso)
        {
            try
            {
                manager.AgregarDictaCurso(idProfesor, idCurso);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ModificarProfesorCurso(int OidProfesor, int OidCurso, int idProfesor, int idCurso)
        {
            try
            {
                manager.UpdateDictaCurso(OidProfesor, OidCurso, idProfesor, idCurso);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void BorrarProfesorACurso(int idProfesor, int idCurso)
        {
            try
            {
                manager.DeleteDictaCurso(idProfesor, idCurso);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public clsProfesor Login(string usuario, string contraseña)
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
        
    }
}
 