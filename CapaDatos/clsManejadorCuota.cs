using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using Interfaces;

namespace CapaDatos
{
    public class clsManejadorCuota
    {
        clsDBManager dbManager = new clsDBManager();

        public int InsertarCuota(clsCuota entidad)
        {
            //idCuota, IdAlumno, IdCurso, Fecha
            String query = "insert Cuota values('" + entidad.IdAlumno + "','" + entidad.IdCurso + "','" + entidad.Fecha + "');";
            int filas;

            try
            {
                filas = dbManager.Ejecutar(query, Interfaces.Tipo.INSERTAR);
            }
            catch (Exception e)
            {
                
                throw e;
            }

            return filas;
        }

        public int UpdateCuota(clsCuota entidad)
        {
            int filas;

            string query = "update Cuota set IdCurso= " + entidad.IdCurso
                        + " IdAlumno = " + entidad.IdAlumno
                        + " Fecha = " + entidad.Fecha 
                        + " where IdCuota = " + entidad.Id + ";";

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

        public int DeleteCuota(clsCuota entidad)
        {
            int filas = 0;

            string query = "delete Cuota where IdCuota = " + entidad.Id + ";";

            try
            {
                filas = dbManager.Ejecutar(query, Tipo.ELIMINAR);
            }
            catch (Exception e)
            {

                throw e;
            }

            return filas;
        }

        public List<clsCuota> SelectCuota(clsCuota entidad)
        {
            List<clsCuota> list = new List<clsCuota>();

            return list;
        }

        public List<clsCuota> ListarCuota()
        {
            List<clsCuota> list = new List<clsCuota>();

            return list;
        }
    }
}
