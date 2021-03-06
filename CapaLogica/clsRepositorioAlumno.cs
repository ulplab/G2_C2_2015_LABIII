﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Clases;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class clsRepositorioAlumno : IRepositorio
    {
        clsManejadorAlumno manager = new clsManejadorAlumno();
            
        private clsAlumno getCast(IEntidad e)
        {
            if (e.GetType().Equals(typeof(clsAlumno)))
                return (clsAlumno)e;
            else
                throw new ArgumentException("el tipo '" + e.GetType().ToString() + "' no esta soportado en un repositorio del tipo '" + this.GetType().ToString());
        }

        public void Agregar(IEntidad entidad)
        {
            clsAlumno alumno = new clsAlumno();

            try
            {
                alumno = getCast(entidad);
            }
            catch(Exception e)
            {
                throw e;
            }

            clsAlumno compare = new clsAlumno();
            compare.Dni = alumno.Dni;

            try
            {
                if (manager.SelectAlumno(compare).Count == 0)
                    manager.InsertAlumno(alumno);
                else
                    throw new ArgumentException("El Alumno ingresado ya existe");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Actualizar(IEntidad entidad)
        {
            clsAlumno alumno = new clsAlumno();

            try
            {
                alumno = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.UpdateAlumno(alumno);
                if (filas == 0)
                {
                    throw new ArgumentException("El alumno no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(IEntidad entidad)
        {
            clsAlumno alumno = new clsAlumno();

            try
            {
                alumno = getCast(entidad);
            }
            catch (Exception e)
            {
                throw e;
            }

            int filas;

            try
            {
                filas = manager.DeleteAlumno(alumno);
                if (filas == 0)
                {
                    throw new ArgumentException("El alumno no existe");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEntidad ObtenerPorId(int id)
        {
            clsAlumno alumno = new clsAlumno();
            alumno.Id = id;
            clsAlumno nalumno = null;

            try
            {
                nalumno = manager.SelectAlumno(alumno)[0];
                if (nalumno == null)
                {
                    throw new ArgumentException("El alumno no existe");
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
            clsAlumno alumno = new clsAlumno();

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
        public clsAlumno Login(string usuario, string contraseña)
        {
            clsManejadorAlumno amanager = new clsManejadorAlumno();
            clsAlumno consulta = new clsAlumno();
            clsAlumno result;
            try
            {
                consulta.Dni = usuario;
                consulta.Contraseña = contraseña;

                List<clsAlumno> resultados = amanager.SelectAlumno(consulta);
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

        public List<IEntidad> Alumnos_Formateados(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            List<IEntidad> list = new List<IEntidad>();
            try
            {
                string check = "02/02/1950";
                if (DateTime.Compare(Fecha_Inicio, Convert.ToDateTime(check)) == 0)
                {
                    list.AddRange(manager.AlumnosFormateados());
                }
                else
                {
                    if (DateTime.Compare(Fecha_Inicio, Fecha_Fin) <= 0)
                    {
                        list.AddRange(manager.AlumnosFormateados(Fecha_Inicio,Fecha_Fin));
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