using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Interfaces;

namespace CapaDatos
{
    public class clsDBManager : IDBManager
    {

        SqlConnection cnn;

        SqlCommand cmd = new SqlCommand();

        SqlTransaction transaccion;

        string strcnn;
        string usuario = "LaboIII";
        
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string clave = "1234";
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        string server = "NOTEBOOK";

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        string baseDeDatos = "BDExamen1LaboIII";

        public string BaseDeDatos
        {
            get { return baseDeDatos; }
            set { baseDeDatos = value; }
        }

        public clsDBManager()
        {

            cnn = new SqlConnection();
            cnn.ConnectionString = stringConeccion();

        }

        public string stringConeccion()
        {
            strcnn = "Data Source=" + server + ";Initial Catalog=" + baseDeDatos +
                     ";User ID=" + Usuario + ";" +
                     "Password=" + Clave;
            return strcnn;

        }

        private SqlConnection getConnection()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cnn;
        }

        public int Ejecutar(string query, Tipo accion)
        {
            int valor;

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.CommandTimeout = 10;
            

            try
            {
                cmd.Connection = getConnection();
                if ((int)accion == 1 || (int)accion == 2)
                {
                    valor = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText += "SELECT SCOPE_IDENTITY();";
                    valor = Convert.ToInt32(cmd.ExecuteScalar());
                 }
                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return valor;

        }

        public DataTable Consultar(string query)
        {
            DataTable dt = new DataTable();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.CommandTimeout = 10;
            

            try
            {
                cmd.Connection = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return dt;
        }


        public int Ejecutar(string procedimiento, SqlParameter[] param, Tipo accion)
        {
            int valor;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = procedimiento;
            cmd.Parameters.AddRange(param);
            cmd.CommandTimeout = 10;

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            
            try
            {
                cmd.Connection = getConnection();
                if ((int)accion == 1 || (int)accion == 2)
                {
                    valor = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    valor = Convert.ToInt32(returnParameter.Value);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return valor;
        }

        public DataTable Consultar(string procedimiento, SqlParameter[] param)
        {
            DataTable dt = new DataTable();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = procedimiento;
            cmd.Parameters.AddRange(param);
            cmd.CommandTimeout = 10;
            

            try
            {
                cmd.Connection = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return dt;
        }

    }
}
