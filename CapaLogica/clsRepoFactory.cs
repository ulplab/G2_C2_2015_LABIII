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
            }
            return repo;
        }
    }
}
