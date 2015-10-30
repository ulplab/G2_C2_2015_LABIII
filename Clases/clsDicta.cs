using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Clases
{
    public class clsDicta : IEntidad
    {
        int id;

        public int Id
        {
          get { return id; }
          set { id = value; }
        }

        int idProfesor = -1;

        public int IdProfesor
        {
          get { return idProfesor; }
          set { idProfesor = value; }
        }

        int idCurso = -1;

        public int IdCurso
        {
          get { return idCurso; }
          set { idCurso = value; }
        }

        int estado = -1;

        public int Estado
        {
          get { return estado; }
          set { estado = value; }
        }
    }
}
