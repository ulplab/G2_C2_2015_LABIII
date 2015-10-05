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
    class clsRepositorioInscripcion : IRepositorio
    {
        clsManejadorInscripcion manager = new clsManejadorInscripcion();

        private clsInscripcion getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsInscripcion)))
                return (clsInscripcion)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            clsInscripcion inscripcion = new clsInscripcion();

            try
            {
                inscripcion = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            clsInscripcion compare = new clsInscripcion();
            compare.IdAlumno = inscripcion.IdAlumno;
            compare.IdCurso = inscripcion.IdCurso;

            try
            {
                if (manager.SelectInscripcion(compare).Count == 0)
                    manager.InsertInscripcion(inscripcion);
                else
                    throw new ArgumentException("El alumno ya esta inscripto en este curso");

                int i = 0;

                foreach (clsInscripcion a in manager.ListarInscripciones())
                {
                    if (a.Estado == 1 && a.IdCurso == inscripcion.IdCurso)
                        i++;
                }

                if(i >= 10)
                    throw new ArgumentException("El curso ya esta lleno");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Actualizar(IEntidad entidad)
        {
            clsInscripcion Inscripcion = new clsInscripcion();

            try
            {
                Inscripcion = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.UpdateInscripcion(Inscripcion);
                if (filas == 0)
                {
                    throw new ArgumentException("La inscripcion no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(IEntidad entidad)
        {
            clsInscripcion Inscripcion = new clsInscripcion();

            try
            {
                Inscripcion = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.DeleteInscripcion(Inscripcion);
                if (filas == 0)
                {
                    throw new ArgumentException("La inscripcion no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {
            clsInscripcion Inscripcion = new clsInscripcion();
            Inscripcion.Id = id;
            clsInscripcion nInscripcion = null;

            try
            {
                nInscripcion = manager.SelectInscripcion(Inscripcion)[0];
                if (nInscripcion == null)
                {
                    throw new ArgumentException("La inscripcion no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return nInscripcion;
        }

        public List<IEntidad> Lista()
        {
            List<IEntidad> list = new List<IEntidad>();

            try
            {
                list.AddRange(manager.ListarInscripciones());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista(IEntidad filtro)
        {
            clsInscripcion Inscripcion = new clsInscripcion();

            List<IEntidad> list = new List<IEntidad>();

            try
            {
                Inscripcion = getCast(filtro);
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                list.AddRange(manager.SelectInscripcion(Inscripcion));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }
    }
}
