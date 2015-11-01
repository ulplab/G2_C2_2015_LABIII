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
    public class clsRepositorioCurso : IRepositorio
    {
        clsManejadorCurso manager = new clsManejadorCurso();
        clsManejadorInscripcion managerI = new clsManejadorInscripcion();

        private clsCurso getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsCurso)))
                return (clsCurso)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            clsCurso curso = new clsCurso();

            try
            {
                curso = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            clsCurso compare = new clsCurso();
            compare.Nombre = curso.Nombre;

            try
            {
                if (manager.SelectCurso(compare).Count == 0 && curso.FechaInicio < curso.FechaFin)
                    manager.InsertCurso(curso);
                else
                    throw new ArgumentException("El Curso ingresado ya existe o es invalido");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Actualizar(IEntidad entidad)
        {
            clsCurso curso = new clsCurso();

            try
            {
                curso = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.UpdateCurso(curso);
                if (filas == 0)
                {
                    throw new ArgumentException("El curso no existe");
                }

                if (curso.Estado == 0)
                {
                    List<clsInscripcion> li = new List<clsInscripcion>();
                    clsInscripcion i = new clsInscripcion();
                    i.IdCurso = curso.Id;

                    li.AddRange(managerI.SelectInscripcion(i));

                    foreach (clsInscripcion ins in li)
                    {
                        i = new clsInscripcion();
                        i.Id = ins.Id;
                        i.Estado = 0;
                        managerI.UpdateInscripcion(i);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(IEntidad entidad)
        {
            clsCurso curso = new clsCurso();

            try
            {
                curso = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.DeleteCurso(curso);
                if (filas == 0)
                {
                    throw new ArgumentException("El curso no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {
            clsCurso curso = new clsCurso();
            curso.Id = id;
            clsCurso ncurso = null;

            try
            {
                ncurso = manager.SelectCurso(curso)[0];
                if (ncurso == null)
                {
                    throw new ArgumentException("El curso no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return ncurso;
        }

        public List<IEntidad> Lista()
        {
            List<IEntidad> list = new List<IEntidad>();

            try
            {
                list.AddRange(manager.ListarCursos());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista(IEntidad filtro)
        {
            clsCurso curso = new clsCurso();

            List<IEntidad> list = new List<IEntidad>();

            try
            {
                curso = getCast(filtro);
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                list.AddRange(manager.SelectCurso(curso));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }
    }
}
