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
    public class clsRepositorioInscripcion : IRepositorio
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
                {
                    manager.InsertInscripcion(inscripcion);
                }
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
        public int Inscribir(IEntidad entidad)
        {
            clsInscripcion inscripcion = new clsInscripcion();
            int result = 0;
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
            compare.Estado = 1;

            try
            {
                if (manager.SelectInscripcion(compare).Count == 0)
                {
                    int i = 0;
                    foreach (clsInscripcion a in manager.ListarInscripciones())
                    {
                        if (a.Estado == 1 && a.IdCurso == inscripcion.IdCurso)
                        {
                            i++;
                        }
                    }
                    if (i >= 10)
                    {
                        throw new ArgumentException("El curso ya esta lleno");
                    }
                    else
                    {
                            inscripcion.Estado = 1;
                            result = manager.InsertInscripcion(inscripcion);
                    }
                }
                else
                {
                    throw new ArgumentException("El alumno ya esta inscripto en este curso");
                }
                return (result);
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

        public int Cantidad(int idCurso)
        {
            int i;
            try
            {
                i = manager.CantidadAlumnos(idCurso);
            }
            catch (Exception e)
            {
                
                throw e;
            }
            return i;
        }

        public int CantidadAlumno(int idAlumno)
        {
            int i;
            try
            {
                i = manager.CantidadCursos(idAlumno);
            }
            catch (Exception e)
            {

                throw e;
            }
            return i;
        }

        public List<IEntidad> AlumnosNoAsistentes(int IdCurso)
        {
            List<IEntidad> LAlum = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.AlumnosNoAsistentes(IdCurso).Rows)
                {
                    clsAlumno Alumno = new clsAlumno();
                    Alumno.Id = Convert.ToInt32(r["IdAlumno"]);
                    Alumno.Dni = Convert.ToString(r["Dni"]);
                    Alumno.Nombre = Convert.ToString(r["Nombre"]);
                    Alumno.Apellido = Convert.ToString(r["Apellido"]);
                    Alumno.Direccion = Convert.ToString(r["Direccion"]);
                    Alumno.Telefono = Convert.ToString(r["Telefono"]);
                    Alumno.Email = Convert.ToString(r["Email"]);
                    Alumno.Estado = Convert.ToInt32(r["Estado"]);

                    LAlum.Add(Alumno);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return LAlum;
        }

        public List<IEntidad> CursosNoAsistentes(int idAlumno)
        {
            List<IEntidad> LCurso = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.CursosNoAsistentes(idAlumno).Rows)
                {
                    clsCurso Curso = new clsCurso();
                    Curso.Id = Convert.ToInt32(r["IdCurso"]);
                    Curso.Nombre = Convert.ToString(r["Nombre"]);
                    Curso.FechaInicio = Convert.ToDateTime(r["FechaInicio"]);
                    Curso.FechaFin = Convert.ToDateTime(r["FechaFin"]);
                    Curso.Descripcion = Convert.ToString(r["Descripcion"]);
                    Curso.Estado = Convert.ToInt32(r["Estado"]);

                    LCurso.Add(Curso);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return LCurso;
        }

        public List<IEntidad> ListaAlumnos(int idCurso)
        {
            List<IEntidad> LAlum = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.ListaAlumnos(idCurso).Rows)
                {
                    clsAlumno Alumno = new clsAlumno();
                    Alumno.Id = Convert.ToInt32(r["IdAlumno"]);
                    Alumno.Dni = Convert.ToString(r["Dni"]);
                    Alumno.Nombre = Convert.ToString(r["Nombre"]);
                    Alumno.Apellido = Convert.ToString(r["Apellido"]);
                    Alumno.Direccion = Convert.ToString(r["Direccion"]);
                    Alumno.Telefono = Convert.ToString(r["Telefono"]);
                    Alumno.Email = Convert.ToString(r["Email"]);
                    Alumno.Estado = Convert.ToInt32(r["Estado"]);

                    LAlum.Add(Alumno);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return LAlum;
        }

        public List<IEntidad> ListaCursos(int idAlumno)
        {
            List<IEntidad> LCurso = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.ListaCursos(idAlumno).Rows)
                {
                    clsCurso Curso = new clsCurso();
                    Curso.Id = Convert.ToInt32(r["IdCurso"]);
                    Curso.Nombre = Convert.ToString(r["Nombre"]);
                    Curso.FechaInicio = Convert.ToDateTime(r["FechaInicio"]);
                    Curso.FechaFin = Convert.ToDateTime(r["FechaFin"]);
                    Curso.Descripcion = Convert.ToString(r["Descripcion"]);
                    Curso.Estado = Convert.ToInt32(r["Estado"]);

                    LCurso.Add(Curso);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return LCurso;
        }

        public List<IEntidad> CursosMorosos(int IdAlumno)
        {
            List<IEntidad> LCurso = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.CursosMorosos(IdAlumno).Rows)
                {
                    clsCurso Curso = new clsCurso();
                    Curso.Id = Convert.ToInt32(r["IdCurso"]);
                    Curso.Nombre = Convert.ToString(r["Nombre"]);
                    Curso.FechaInicio = Convert.ToDateTime(r["FechaInicio"]);
                    Curso.FechaFin = Convert.ToDateTime(r["FechaFin"]);
                    Curso.Descripcion = Convert.ToString(r["Descripcion"]);
                    Curso.Estado = Convert.ToInt32(r["Estado"]);

                    LCurso.Add(Curso);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return LCurso;
        }

        public List<IEntidad> ListaCursosSinNota(int idAlumno)
        {
            List<IEntidad> LCurso = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.ListaCursosSinNota(idAlumno).Rows)
                {
                    clsCurso Curso = new clsCurso();
                    Curso.Id = Convert.ToInt32(r["IdCurso"]);
                    Curso.Nombre = Convert.ToString(r["Nombre"]);
                    Curso.FechaInicio = Convert.ToDateTime(r["FechaInicio"]);
                    Curso.FechaFin = Convert.ToDateTime(r["FechaFin"]);
                    Curso.Descripcion = Convert.ToString(r["Descripcion"]);
                    Curso.Estado = Convert.ToInt32(r["Estado"]);

                    LCurso.Add(Curso);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return LCurso;
        }
    }
}
