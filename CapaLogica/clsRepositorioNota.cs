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
    public class clsRepositorioNota : IRepositorio
    {
        clsManejadorAlumno manager = new clsManejadorAlumno();

        private clsNota getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsNota)))
                return (clsNota)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            clsNota nota = new clsNota();

            try
            {
                nota = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            clsNota compare = new clsNota();
            compare.IdAlumno = nota.IdAlumno;
            compare.IdCurso = nota.IdCurso;

            try
            {
                if (manager.SelectAlumno(compare).Count == 0)
                    manager.InsertAlumno(nota);
                else
                    throw new ArgumentException("Esta nota ya fue registrada");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Actualizar(IEntidad entidad)
        {
            clsNota nota = new clsNota();

            try
            {
                nota = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.UpdateAlumno(nota);
                if (filas == 0)
                {
                    throw new ArgumentException("La nota no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(IEntidad entidad)
        {
            clsNota nota = new clsNota();

            try
            {
                nota = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.DeleteAlumno(nota);
                if (filas == 0)
                {
                    throw new ArgumentException("La nota no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {
            clsNota nota = new clsNota();
            nota.Id = id;
            clsNota nalumno = null;

            try
            {
                nalumno = manager.SelectAlumno(nota)[0];
                if (nalumno == null)
                {
                    throw new ArgumentException("La nota no existe");
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
                list.AddRange(manager.ListarAlumnos());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista(IEntidad filtro)
        {
            clsNota alumno = new clsNota();

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
                list.AddRange(manager.SelectAlumno(alumno));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }
    }
}
