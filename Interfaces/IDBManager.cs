using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces
{
    public interface IDBManager
    {
        int Ejecutar(String sql,Tipo T);
        int Ejecutar(String spNobre, SqlParameter[] sqlParam, Tipo T);
        DataTable Consultar(String sql);
        DataTable Consultar(String spNobre, SqlParameter[] sqlParam);
       
    }
}
