using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public enum NivelSeguridad { ADMINISTRADOR, PROFESOR, ALUMNO }

    public enum RepoType { ADMINISTRADOR, ALUMNO, CURSO, INSCRIPCION, PROFESOR, CUOTA, NOTA}

    public enum Tipo { INSERTAR, ELIMINAR, ACTUALIZAR}

    public interface IRepositorio
    {
        void Agregar(IEntidad entidad);
        void Actualizar(IEntidad entidad);
        void Borrar(IEntidad entidad);
        IEntidad ObtenerPorId(int id);
        List<IEntidad> Lista();
        List<IEntidad> Lista(IEntidad filtro);

    }
}
