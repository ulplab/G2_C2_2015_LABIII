using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;

namespace CapaDatos
{
    public class clsManejadorNota
    {
        clsDBManager dbManager = new clsDBManager();

        public int InsertarNota(clsNota entidad)
        {
            int filas;

            string query = "insert Nota values('" + entidad.IdAlumno + "','" + entidad.IdCurso + "','" + entidad.Nota + "','" + entidad.Fecha + "','" + entidad.Estado + "');";

            try
            {
                filas = dbManager.Ejecutar(query, Tipo.INSERTAR);
            }
            catch (Exception e)
            {

                throw e;
            }

            return filas;
        }

        public int UpdateNota(clsNota entidad)
        {
            int filas;

            string query = "update Dicta set Nota = '" + entidad.Nota + "', Fecha = '" + String.Format("{0,s}", entidad.Fecha) + "', Estado = '" + entidad.Estado + "' where IdAlumno = " + entidad.IdAlumno + " and IdCurso = " + entidad.IdCurso + ";";

            try
            {
                filas = dbManager.Ejecutar(query, Tipo.ACTUALIZAR);
            }
            catch (Exception e)
            {
                
                throw e;
            }
            return filas;
        }

        public int DeleteNota(clsNota entidad)
        {
            int filas = 0;

            string query = "delete Dicta where IdAlumno = '" + entidad.IdAlumno + "', IdCurso = '" + entidad.IdCurso + "';";

            return filas;
        }

        public List<clsNota> SelectNota(clsNota entidad)
        {
            List<clsNota> list = new List<clsNota>();



            return list;
        }

        public List<clsNota> ListarNota()
        {
            List<clsNota> list = new List<clsNota>();

            return list;
        }
    }
}
