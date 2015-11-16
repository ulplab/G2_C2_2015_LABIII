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
        clsManejadorNota manager = new clsManejadorNota();

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
                if (manager.SelectNota(compare).Count == 0)
                    manager.InsertarNota(nota);
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
                filas = manager.UpdateNota(nota);
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
                filas = manager.DeleteNota(nota);
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
                nalumno = manager.SelectNota(nota)[0];
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

        public IEntidad ObtenerPorId(int idAlumno, int idCurso)
        {
            clsNota nota = new clsNota();
            nota.IdAlumno = idAlumno;
            nota.IdCurso = idCurso;
            clsNota nalumno = null;

            try
            {
                nalumno = manager.SelectNota(nota)[0];
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
                list.AddRange(manager.ListarNota());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista(IEntidad filtro)
        {
            clsNota nota = new clsNota();

            List<IEntidad> list = new List<IEntidad>();

            try
            {
                nota = getCast(filtro);
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                list.AddRange(manager.SelectNota(nota));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista_Formateada()
        {
            List<IEntidad> list = new List<IEntidad>();

            try
            {
                list.AddRange(manager.ListarNotaFormateada());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Notas_Por_Alumno(int id)
        {
            List<IEntidad> list = new List<IEntidad>();

            try
            {
                clsAlumno temp =  new clsAlumno();
                temp.Id = id;
                list.AddRange(manager.Notas_por_Alumno(temp));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Notas_Por_Profesor(int id)
        {

            List<IEntidad> list = new List<IEntidad>();
            clsProfesor temp = new clsProfesor();
            temp.Id = id;
            try
            {
                list.AddRange(manager.Notas_por_Profesor(temp));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }
    }
}
