﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Clases;
using System.Data;
using CapaDatos;

namespace Clases
{
    public class clsRepositorioCuota : IRepositorio
    {
        clsManejadorCuota manager = new clsManejadorCuota();

        private clsCuota getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsCuota)))
                return (clsCuota)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            clsCuota cuota = new clsCuota();

            try
            {
                cuota = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }
            clsCuota compare = new clsCuota();
            compare.IdAlumno = cuota.IdAlumno;
            compare.IdCurso = cuota.IdCurso;
            try
            {
                if (manager.SelectCuota(compare).Count == 0)
                    cuota.Id = manager.InsertarCuota(cuota);
                else
                    throw new ArgumentException("Esta deuda ya existe");
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public void Actualizar(IEntidad entidad)
        {
            clsCuota cuota = new clsCuota();

            try
            {
                cuota = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.UpdateCuota(cuota);
                if (filas == 0)
                {
                    throw new ArgumentException("La deuda ingresada no existe o ya fue pagada");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(IEntidad entidad)
        {
            clsCuota cuota = new clsCuota();

            try
            {
                cuota = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.DeleteCuota(cuota);
                if (filas == 0)
                {
                    throw new ArgumentException("La deuda ingresada no existe o ya fue pagada");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {
            clsCuota cuota = new clsCuota();
            cuota.Id = id;
            clsCuota ncuota = null;

            try
            {
                ncuota = manager.SelectCuota(cuota)[0];
                if (ncuota == null)
                {
                    throw new ArgumentException("La deuda ingresada no existe o ya fue pagada");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return ncuota;
        }

        public List<IEntidad> Lista()
        {
            List<IEntidad> list = new List<IEntidad>();

            try
            {
                list.AddRange(manager.ListarCuota());
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> Lista(IEntidad filtro)
        {
            clsCuota cuota = new clsCuota();

            List<IEntidad> list = new List<IEntidad>();

            try
            {
                cuota = getCast(filtro);
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                list.AddRange(manager.SelectCuota(cuota));
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public List<IEntidad> ListaMorosos()
        {
            clsManejadorAlumno managerAlumno = new clsManejadorAlumno();

            List<IEntidad> listMorosos = new List<IEntidad>();

            List<clsAlumnoFormateado> Morosos = new List<clsAlumnoFormateado>();

            try
            {
                Morosos = managerAlumno.AlumnosFormateados();

                foreach (clsAlumnoFormateado temp in Morosos)
                {
                    if (temp.Pagado < temp.Esperado)
                    {
                        temp.Pagado = (temp.Esperado - temp.Pagado);
                        listMorosos.Add(temp);
                    }
                }
            }
            catch (Exception a)
            {
                throw (a);
            }
            return listMorosos;
        }

        public List<IEntidad> Pagos_Por_Cursos()
        {
            List<IEntidad> result = new List<IEntidad>();

            try
            {
                result.AddRange(manager.ListarCuotaFormateada());
            }
            catch (Exception e)
            {
                throw e;
            }

            return (result);
        }

        public List<IEntidad> Lista_Formateada(DateTime Fecha_Inicio,DateTime Fecha_Fin)
        {
            List<IEntidad> list = new List<IEntidad>();
                try
                {
                    string check = "02/02/1950";
                    if (DateTime.Compare(Fecha_Inicio,Convert.ToDateTime(check)) == 0)
                    {
                        list.AddRange(manager.ListarCuotaFormateada());
                    }
                    else
                    {
                        if (DateTime.Compare(Fecha_Inicio,Fecha_Fin) <= 0)
                        {
                            list.AddRange(manager.ListarCuotaFormateada(Fecha_Inicio, Fecha_Fin));
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            return list;
        }
    }
}