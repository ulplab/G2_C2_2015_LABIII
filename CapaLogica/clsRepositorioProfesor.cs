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
            clsProfesor profesor = new clsProfesor();

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

            try
            {
                if (manager.SelectProfesor(compare).Count == 0)
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
                consulta.Dni = usuario;
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

        public DataTable ListarDicta()
        {
            DataTable dt;

            try
            {
                dt = manager.ProfesorDicta(-1, -1);
            }
            catch (Exception e)
            {
                throw e;
            }

            return dt;
        }

        public DataTable ListarDicta(int idProfesor, int idCurso)
        {
            DataTable dt;

            try
            {
                dt = manager.ProfesorDicta(idProfesor, idCurso);
            }
            catch (Exception e)
            {
                throw e;
            }

            return dt;
        }

        public int CantidadProfesores(int idCurso)
        {
            int i;
            try
            {
                i = manager.CantidadProfesores(idCurso);
            }
            catch (Exception e)
            {

                throw e;
            }
            return i;
        }

        public int CantidadCursos(int idProfesor)
        {
            int i;
            try
            {
                i = manager.CantidadProfesores(idProfesor);
            }
            catch (Exception e)
            {

                throw e;
            }
            return i;
        }


        public List<IEntidad> ListaProfesores(int idCurso)
        {
            List<IEntidad> LPro = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.ListaProfesores(idCurso).Rows)
                {
                    clsProfesor Profesor = new clsProfesor();
                    Profesor.Id = Convert.ToInt32(r["IdProfesor"]);
                    Profesor.Dni = Convert.ToString(r["Dni"]);
                    Profesor.Nombre = Convert.ToString(r["Nombre"]);
                    Profesor.Apellido = Convert.ToString(r["Apellido"]);
                    Profesor.Direccion = Convert.ToString(r["Direccion"]);
                    Profesor.Telefono = Convert.ToString(r["Telefono"]);
                    Profesor.Email = Convert.ToString(r["Email"]);
                    Profesor.Estado = Convert.ToInt32(r["Estado"]);

                    LPro.Add(Profesor);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return LPro;
        }

        public List<IEntidad> ListaCursos(int idProfesor)
        {
            List<IEntidad> LCurso = new List<IEntidad>();

            try
            {
                foreach (DataRow r in manager.ListaCursos(idProfesor).Rows)
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

        public List<IEntidad> CursosDisponiblesParaDictar(int idProfesor)
        {
            clsRepositorioCurso repoC = new clsRepositorioCurso();
            DataTable dt;
            List<IEntidad> cursosRet = new List<IEntidad>();
            clsCurso cursos = new clsCurso();
            bool repetido = false;

            try
            {
                dt = manager.ProfesorDicta(-1, -1);

                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["IdProfesor"]) != idProfesor)
                    {
                        cursos = (clsCurso)repoC.ObtenerPorId(Convert.ToInt32(dr["IdProfesor"]));

                        foreach (clsCurso cur in cursosRet)
                        {
                            if (cur.Id == cursos.Id)
                            {
                                repetido = true;
                            }
                        }

                        if (!repetido)
                        {
                            cursosRet.Add(cursos);
                        }

                        repetido = false;
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return cursosRet;
        }
    }
}
 