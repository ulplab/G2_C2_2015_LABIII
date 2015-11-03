using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;
using System.Data;

namespace CapaDatos
{
    public class clsManejadorInscripcion
    {
        clsDBManager dbman = new clsDBManager();

        public int InsertInscripcion(clsInscripcion entidad)
        {
            int filas;
            try
            {
                //NroInscripcion,IdAdministrador,IdCurso,IdAlumno,Estado
                string query = "INSERT INTO Asiste([IdAdministrador],[IdCurso],[IdAlumno],[Estado]) VALUES('" + entidad.IdAdministrador + "','" + entidad.IdCurso + "','" + entidad.IdAlumno + "','" + entidad.Estado + "');";
                filas = dbman.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int UpdateInscripcion(clsInscripcion entidad)
        {
            int filas;
            try
            {
                string query = "UPDATE Asiste Set IdAdministrador = '" + entidad.IdAdministrador + "', IdCurso = '" + entidad.IdCurso + "', IdAlumno = '" + entidad.IdAlumno + "', Estado = '" + entidad.Estado + "' WHERE NroInscripcion =" + entidad.NroInscripcion + ";";
                filas = dbman.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public int DeleteInscripcion(clsInscripcion entidad)
        {
            int filas;
            try
            {
                string query = "UPDATE Asiste SET estado = 0 WHERE IdAlumno= '" + entidad.IdAlumno + "' AND IdCurso ='" + entidad.IdCurso + "';";
                filas = dbman.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

        public List<clsInscripcion> SelectInscripcion(clsInscripcion entidad)
        {
            bool id = false, idAd = false, idC = false, idAl = false;

            string query = "SELECT * FROM Asiste WHERE";
            if (entidad.NroInscripcion != -1)
            {
                query += " NroInscripcion = " + entidad.NroInscripcion;
                id = true;
            }
            if (entidad.IdAdministrador != -1)
            {
                if (id)
                {
                    query += " AND";
                }
                query += " IdAdministrador = " + entidad.IdAdministrador;
                idAd = true;
            }
            if (entidad.IdAlumno != -1)
            {
                if (id || idAd)
                {
                    query += " AND";
                }
                query += " IdAlumno = " + entidad.IdAlumno;
                idAl = true;
            }
            if (entidad.IdCurso != -1)
            {
                if (id || idAd || idAl)
                {
                    query += " AND";
                }
                query += " IdCurso = " + entidad.IdCurso;
            }
            if (entidad.Estado != -1)
            {
                if (id || idAd || idAl || idC)
                {
                    query += " AND";
                }
                query += " Estado = " + entidad.Estado;
            }

            query += ";";

            List<clsInscripcion> list = new List<clsInscripcion>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar(query);
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsInscripcion a = new clsInscripcion();

                a.NroInscripcion = Convert.ToInt32(dr["NroInscripcion"]);
                a.IdAdministrador = Convert.ToInt32(dr["IdAdministrador"]);
                a.IdCurso = Convert.ToInt32(dr["IdCurso"]);
                a.IdAlumno = Convert.ToInt32(dr["IdAlumno"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }

        public List<clsInscripcion> ListarInscripciones()
        {
            List<clsInscripcion> list = new List<clsInscripcion>();
            DataTable dt;

            try
            {
                dt = dbman.Consultar("SELECT * FROM Asiste;");
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                clsInscripcion a = new clsInscripcion();

                a.NroInscripcion = Convert.ToInt32(dr["NroInscripcion"]);
                a.IdAdministrador = Convert.ToInt32(dr["IdAdministrador"]);
                a.IdCurso = Convert.ToInt32(dr["IdCurso"]);
                a.IdAlumno = Convert.ToInt32(dr["IdAlumno"]);
                a.Estado = Convert.ToInt32(dr["Estado"]);

                list.Add(a);
            }

            return list;
        }

        public int Cantidad(int IdCurso)
        {
            DataTable dt = new DataTable();
            int ret = 0;

            try
            {
                //dt = dbman.Consultar("SELECT COUNT(*) as Cantidad FROM Asiste WHERE Estado = 1 AND IdCurso =" + IdCurso);
                dt = dbman.Consultar("SELECT COUNT(*) as Cantidad FROM Asiste a, Cursos c WHERE a.Estado = 1 AND c.IdCurso =" + IdCurso + "and a.IdCurso = c.IdCurso and c.Estado = 1;");
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
                dt = dbman.Consultar("SELECT COUNT(*) as Cantidad FROM Asiste a, Cursos c WHERE a.Estado = 1 AND IdAlumno = " + IdAlumno+ " and c.Estado = 1 and a.IdCurso = c.IdCurso");
                ret = Convert.ToInt32(dt.Rows[0]["Cantidad"]);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        public DataTable AlumnosNoAsistentes(int IdCurso)
        {
            DataTable dt = new DataTable();


            try
            {
                dt = dbman.Consultar(
"select distinct * from Alumnos where Alumnos.IdAlumno not in((select distinct IdAlumno from Asiste where IdCurso ='" + IdCurso.ToString() + "' And Estado = 'True')) and Alumnos.Estado = 'True';");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable CursosNoAsistentes(int IdAlumno)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = dbman.Consultar(
                    "select distinct * from Cursos where Cursos.IdCurso not in((select distinct IdCurso from Asiste where IdAlumno = '" + IdAlumno.ToString() + "' And Estado = 'True')) and Cursos.Estado = 'True';"
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable ListaAlumnos(int IdCurso)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = dbman.Consultar("SELECT A1.IdAlumno,Dni,Nombre,Apellido,Direccion,Telefono,Email,Estado " +
                                            "FROM Alumnos as A1, (SELECT IdAlumno " +
                                             "FROM Asiste " +
                                             "WHERE IdCurso = " + IdCurso + " AND Estado = 1) as A2 " +
                                         "WHERE A1.IdAlumno = A2.IdAlumno");

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;

        }

        public DataTable ListaCursos(int IdAlumno)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = dbman.Consultar("SELECT A1.IdCurso, Nombre, FechaInicio, FechaFin, Descripcion, Estado " +
                                            "FROM Cursos as A1,(SELECT IdCurso " +
                                             "FROM Asiste " +
                                             "WHERE IdAlumno = " + IdAlumno + " AND Estado = 1) as A2 " +
                                         "WHERE A1.IdCurso = A2.IdCurso");

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable CursosMorosos(int idAlumno)
        {
            DataTable dt = new DataTable();

            string query =  "select * " +
                            "from Cursos, " +
                            "( " +
                            "select * " +
                            "from Asiste " +
                            "where Asiste.IdCurso not in " +
                            "( " +
                            "select Cuota.IdCurso " +
                            "from Cuota " +
                            "where IdAlumno = '"+ idAlumno.ToString()+"' " +
                            ") " +
                            "and Asiste.IdAlumno = '" + idAlumno.ToString()+"' " +
                            ") as \"CursosMorosos\" " +
                            "where Cursos.IdCurso = CursosMorosos.IdCurso;";
            try
            {
                dt = dbman.Consultar(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
    }
}
