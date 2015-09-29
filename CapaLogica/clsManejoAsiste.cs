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
    public class clsManejoAsiste
    {
        IDBManager DBManager = new clsDBManager();

        public void Agregar(clsAsiste Asiste)
        {
            DataTable dt = new DataTable();
            DataTable TablaNroInscripcion = new DataTable();

            try
            {
                dt = DBManager.Consultar("SELECT * FROM Asiste;");

                foreach (DataRow r in dt.Rows)
                {
                    if (Convert.ToInt32(r["IdAlumno"]) == Asiste.IdAlumno && Convert.ToInt32(r["IdCurso"]) == Asiste.IdCurso)
                    {
                        throw new ArgumentException("El Alumno ya esta inscripto en el curso");
                    }
                }

                dt = DBManager.Consultar("SELECT * FROM Alumno WHERE IdAlumno=" + Asiste.IdAlumno);
                if (!Convert.ToBoolean(dt.Rows[0]["IdAlumno"]))
                {
                    throw new ArgumentException("No se puede inscribir un alumno inhabilitado");
                }

                dt = DBManager.Consultar("SELECT * FROM Cursos WHERE IdCurso=" + Asiste.IdCurso);
                if (!Convert.ToBoolean(dt.Rows[0]["IdCurso"]))
                {
                    throw new ArgumentException("No se puede inscribir un alumno a un curso inhabilitado");
                }

                dt = DBManager.Consultar("SELECT * FROM Cursos WHERE IdAdministrador=" + Asiste.IdAdministrador);
                if (!Convert.ToBoolean(dt.Rows[0]["IdAdministrador"]))
                {
                    throw new ArgumentException("Un administrador inhabilitado no puede inscribir a un alumno a un curso");
                }

                dt = DBManager.Consultar("SELECT COUNT(*) as Cantidad FROM Asiste WHERE Estado = 1 AND IdCurso =" + Asiste.IdCurso);
                int CantidadAlumnos = Convert.ToInt32(dt.Rows[0]["Cantidad"]);
                if (CantidadAlumnos >= 10)
                {
                    throw new ArgumentException("Cupo maximo alcanzado, no se pudo inscribir el alumno");
                }

                DBManager.Ejecutar("INSERT INTO Asiste VALUES('" + Asiste.IdAdministrador + "','" + Asiste.IdCurso + "','" + Asiste.IdAlumno + "','" + Asiste.Estado + "');", Tipo.INSERTAR);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Actualizar(clsAsiste Asiste)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            try
            {
                int filaAfectada;

                dt1 = DBManager.Consultar("SELECT COUNT(*) as Cantidad FROM Asiste WHERE Estado = 1 AND IdCurso =" + Asiste.IdCurso);
                int CantidadAlumnos = Convert.ToInt32(dt1.Rows[0]["Cantidad"]);

                dt2 = DBManager.Consultar("SELECT * FROM Asiste WHERE IdAdministrador =" + Asiste.IdAdministrador + " AND IdAlumno =" + Asiste.IdAlumno + " AND IdCurso =" + Asiste.IdCurso);

                if (CantidadAlumnos >= 10 && Asiste.Estado && !Convert.ToBoolean(dt2.Rows[0]["Estado"]))
                {
                    throw new ArgumentException("Cupo maximo alcanzado, no se pudo inscribir el alumno");
                }

                dt3 = DBManager.Consultar("SELECT * FROM Asiste WHERE IdCurso =" + Asiste.IdCurso);

                if (!Asiste.Estado && Convert.ToBoolean(dt2.Rows[0]["Estado"]) && Convert.ToDateTime(dt3.Rows[0]["FechaInicio"]) > DateTime.Now)
                {
                    throw new ArgumentException("No se pudo dar de baja la inscripcion, el curso ha iniciado");
                }

               filaAfectada = DBManager.Ejecutar("UPDATE Asiste SET Estado='" + Asiste.Estado + "' WHERE IdAdministrador =" + Asiste.IdAdministrador +" AND IdAlumno =" + Asiste.IdAlumno + " AND IdCurso =" + Asiste.IdCurso +";", Tipo.ACTUALIZAR);

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
        public int DarDeBaja(clsAlumno Alumno, clsCurso Curso)
        {
            DataTable Consultar = new DataTable();
            int filas_afectadas;
            try
            {
                DataTable Existe = DBManager.Consultar("select COUNT(*) as result from Asiste where IdAlumno = '" + Alumno.Id.ToString() + "' and IdCurso = '" + Curso.Id.ToString() + "' and Estado = 'True';");
                int ExisteNro = 0;
                foreach (DataRow temp in Existe.Rows)
                {
                    ExisteNro = Convert.ToInt32(temp["result"].ToString());
                }
                if (ExisteNro > 0)
                {
                    Consultar = DBManager.Consultar("Select * from Asiste where IdCurso = " + Curso.Id + " AND IdAlumno = " + Alumno.Id + ";");
                    if (Consultar.Rows.Count > 0)
                    {
                        bool estado = false;
                        filas_afectadas = DBManager.Ejecutar("UPDATE Asiste SET estado = '" + estado + "' Where IdCurso = " + Curso.Id + "AND IdAlumno =" + Alumno.Id + ";", Tipo.ACTUALIZAR);
                    }
                    else
                    {
                        filas_afectadas = 0;
                    }
                }
                else
                {
                    throw new Exception("La inscripcion actual ya fue dada de baja");
                }
                return (filas_afectadas);
            }
            catch (Exception a)
            {
                throw (a);
            }
        }
        public int inscribir(clsAlumno Alumnos, clsCurso Curso, clsAdministrador Admin)
        {
            int nroInscripcion;
            try
            {
                int check = DateTime.Compare(DateTime.Today, Curso.FechaInicio);
                if (check < 0)
                {
                    DataTable Existe = DBManager.Consultar("select COUNT(*) as result from Asiste where IdAlumno = '"+ Alumnos.Id.ToString() +"' and IdCurso = '" + Curso.Id.ToString() + "';");
                    int ExisteNro = 0;
                    foreach (DataRow temp in Existe.Rows)
                    {
                        ExisteNro = Convert.ToInt32(temp["result"].ToString());
                    }
                    if (ExisteNro == 0)
                    {
                        DataTable count = DBManager.Consultar("select COUNT(*) as result from Asiste,( Select IdAlumno from Alumnos where Estado = 'True') as subconsulta where IdCurso = '" + Curso.Id.ToString() + "' and Asiste.IdAlumno = subconsulta.IdAlumno and Asiste.Estado = 'True';");
                        int Cantidad = 0;
                        foreach (DataRow temp in count.Rows)
                        {
                            Cantidad = Convert.ToInt32(temp["result"].ToString());
                        }
                        if (Cantidad < 10)
                        {
                            nroInscripcion = 0;
                            nroInscripcion = DBManager.Ejecutar("INSERT INTO Asiste([IdAdministrador],[IdCurso],[IdAlumno],[Estado]) values ('" + Admin.Id.ToString() + "','" + Curso.Id.ToString() + "','" + Alumnos.Id.ToString() + "','True');", Tipo.INSERTAR);
                        }
                        else
                        {
                            Exception a = new Exception("El curso se encuentra completo");
                            throw (a);
                        }
                    }
                    else
                    {
                        Exception a = new Exception("La inscripcion ya existe");
                        throw (a);
                    }
                }
                else
                {
                    throw (new Exception("la fecha de inscripcion ha caducado"));
                }
            }
            catch(Exception a)
            {
                throw (a);
            }
            return (nroInscripcion);
        }
        public int Cantidad(int IdCurso)
        {
            DataTable dt = new DataTable();
            int ret = 0;

            try
            {
                dt = DBManager.Consultar("SELECT COUNT(*) as Cantidad FROM Asiste WHERE Estado = 1 AND IdCurso =" + IdCurso);
                ret = Convert.ToInt32(dt.Rows[0]["Cantidad"]);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }
        public int CantidadAlumno(int IdAlumno)
        {
            DataTable dt = new DataTable();
            int ret = 0;

            try
            {
                dt = DBManager.Consultar("SELECT COUNT(*) as Cantidad FROM Asiste WHERE Estado = 1 AND IdAlumno =" + IdAlumno);
                ret = Convert.ToInt32(dt.Rows[0]["Cantidad"]);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }
        public List<clsAlumno> AlumnosNoAsistentes(int IdCurso)
        {
            DataTable dt = new DataTable();
            List<clsAlumno> LAlum = new List<clsAlumno>();


            try
            {
                dt = DBManager.Consultar(
"select distinct * from Alumnos where Alumnos.IdAlumno not in((select distinct IdAlumno from Asiste where IdCurso ='"+ IdCurso.ToString() + "' And Estado = 'True')) and Alumnos.Estado = 'True';");

                foreach (DataRow r in dt.Rows)
                {
                    clsAlumno Alumno = new clsAlumno();
                    Alumno.Id = Convert.ToInt32(r["IdAlumno"]);
                    Alumno.Dni = Convert.ToInt32(r["Dni"]);
                    Alumno.Nombre = Convert.ToString(r["Nombre"]);
                    Alumno.Apellido = Convert.ToString(r["Apellido"]);
                    Alumno.Direccion = Convert.ToString(r["Direccion"]);
                    Alumno.Telefono = Convert.ToString(r["Telefono"]);
                    Alumno.Email = Convert.ToString(r["Email"]);
                    Alumno.Estado = Convert.ToBoolean(r["Estado"]);

                    LAlum.Add(Alumno);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return LAlum;

        }
        public List<clsCurso> CursosNoAsistentes(int IdAlumno)
        {
            DataTable dt = new DataTable();
            List<clsCurso> LCurso = new List<clsCurso>();


            try
            {
                dt = DBManager.Consultar(
                    "select distinct * from Cursos where Cursos.IdCurso not in((select distinct IdCurso from Asiste where IdAlumno = '"+ IdAlumno.ToString() +"' And Estado = 'True')) and Cursos.Estado = 'True';"
                    );

                foreach (DataRow r in dt.Rows)
                {
                    clsCurso Curso = new clsCurso();
                    Curso.Id = Convert.ToInt32(r["IdCurso"]);
                    Curso.Nombre = Convert.ToString(r["Nombre"]);
                    Curso.FechaInicio = Convert.ToDateTime(r["FechaInicio"]);
                    Curso.FechaFin = Convert.ToDateTime(r["FechaFin"]);
                    Curso.Descripcion = Convert.ToString(r["Descripcion"]);
                    Curso.Estado = Convert.ToBoolean(r["Estado"]);

                    LCurso.Add(Curso);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return LCurso;
        }
        public List<clsAlumno> ListaAlumnos(int IdCurso)
        {
            DataTable dt = new DataTable();
            List<clsAlumno> LAlum = new List<clsAlumno>();


            try
            {
                dt = DBManager.Consultar("SELECT A1.IdAlumno,Dni,Nombre,Apellido,Direccion,Telefono,Email,Estado "+
                                            "FROM Alumnos as A1, (SELECT IdAlumno "+
                                             "FROM Asiste "+
                                             "WHERE IdCurso = "+IdCurso+" AND Estado = 1) as A2 "+
                                         "WHERE A1.IdAlumno = A2.IdAlumno");

                foreach (DataRow r in dt.Rows)
                {
                    clsAlumno Alumno = new clsAlumno();
                    Alumno.Id = Convert.ToInt32(r["IdAlumno"]);
                    Alumno.Dni = Convert.ToInt32(r["Dni"]);
                    Alumno.Nombre= Convert.ToString(r["Nombre"]);
                    Alumno.Apellido= Convert.ToString(r["Apellido"]);
                    Alumno.Direccion= Convert.ToString(r["Direccion"]);
                    Alumno.Telefono= Convert.ToString(r["Telefono"]);
                    Alumno.Email= Convert.ToString(r["Email"]);
                    Alumno.Estado = Convert.ToBoolean(r["Estado"]);

                    LAlum.Add(Alumno);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return LAlum;

        }
        public List<clsCurso> ListaCursos(int IdAlumno)
        {
            DataTable dt = new DataTable();
            List<clsCurso> LCurso = new List<clsCurso>();


            try
            {
                dt = DBManager.Consultar("SELECT A1.IdCurso, Nombre, FechaInicio, FechaFin, Descripcion, Estado "+
                                            "FROM Cursos as A1,(SELECT IdCurso "+
                                             "FROM Asiste "+
                                             "WHERE IdAlumno = "+IdAlumno+" AND Estado = 1) as A2 "+
                                         "WHERE A1.IdCurso = A2.IdCurso");

                foreach (DataRow r in dt.Rows)
                {
                    clsCurso Curso = new clsCurso();
                    Curso.Id = Convert.ToInt32(r["IdCurso"]);
                    Curso.Nombre = Convert.ToString(r["Nombre"]);
                    Curso.FechaInicio= Convert.ToDateTime(r["FechaInicio"]);
                    Curso.FechaFin= Convert.ToDateTime(r["FechaFin"]);
                    Curso.Descripcion= Convert.ToString(r["Descripcion"]);
                    Curso.Estado = Convert.ToBoolean(r["Estado"]);

                    LCurso.Add(Curso);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return LCurso;
        }
        public List<clsAsiste> Lista()
        {
            DataTable dt = new DataTable();
            List<clsAsiste> LAsiste = new List<clsAsiste>();

            try
            {
                dt = DBManager.Consultar("SELECT * FROM Asiste;");

                foreach (DataRow r in dt.Rows)
                {
                    clsAsiste Asiste = new clsAsiste();
                    Asiste.IdAdministrador = Convert.ToInt32(r["IdAdministrador"]);
                    Asiste.IdCurso = Convert.ToInt32(r["IdCurso"]);
                    Asiste.IdAlumno = Convert.ToInt32(r["IdAlumno"]);
                    Asiste.NroInscripcion = Convert.ToInt32(r["NroInscripcion"]);
                    Asiste.Estado = Convert.ToBoolean(r["Estado"]);

                    LAsiste.Add(Asiste);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return LAsiste;
        }
        public List<clsAsiste> Lista(string filtro)
        {
            DataTable dt = new DataTable();
            List<clsAsiste> LAsiste = new List<clsAsiste>();

            try
            {
                dt = DBManager.Consultar(filtro);

                foreach (DataRow r in dt.Rows)
                {
                    clsAsiste Asiste = new clsAsiste();
                    Asiste.IdAdministrador = Convert.ToInt32(r["IdAdministrador"]);
                    Asiste.IdCurso = Convert.ToInt32(r["IdCurso"]);
                    Asiste.IdAlumno = Convert.ToInt32(r["IdAlumno"]);
                    Asiste.NroInscripcion = Convert.ToInt32(r["NroInscripcion"]);
                    Asiste.Estado = Convert.ToBoolean(r["Estado"]);

                    LAsiste.Add(Asiste);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return LAsiste;
        }


    
    }
}
