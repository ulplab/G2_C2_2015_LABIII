using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Clases;

namespace CapaLogica
{
    public class clsRepoFactory : IRepoFactory
    {
        public IRepositorio getRepositorio(RepoType repoType)
        {
            IRepositorio repo = null;
            switch (repoType) { 
                case RepoType.ADMINISTRADOR:
                    repo = new clsRepositorioAdministrador();
                    break;
                case RepoType.ALUMNO:
                    repo = new clsRepositorioAlumno();
                    break;
                case RepoType.CURSO:
                    repo = new clsRepositorioCurso();
                    break;
                case RepoType.INSCRIPCION:
                    repo = new clsRepositorioInscripcion();
                    break;
                case RepoType.PROFESOR:
                    repo = new clsRepositorioProfesor();
                    break;
                case RepoType.CUOTA:
                    repo = new clsRepositorioCuota();
                    break;
                case RepoType.NOTA:
                    repo = new clsRepositorioNota();
                    break;
            }
            return repo;
        }
    }
}
