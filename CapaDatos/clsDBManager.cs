﻿using System;
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

        SqlCommand cmd;

        SqlTransaction transaccion;

        string strcnn;
        string usuario = "LaboIII";
       //hola pablo
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

            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.CommandTimeout = 10;

            try
            {
                cmd.Connection = getConnection();
                transaccion = cnn.BeginTransaction();
                cmd.Transaction = transaccion;

                if ((int)accion == 1 || (int)accion == 2)
                {
                    valor = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText += "SELECT SCOPE_IDENTITY();";
                    valor = Convert.ToInt32(cmd.ExecuteScalar());
                }
                    transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
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

            cmd = new SqlCommand();
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

            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = procedimiento;
            cmd.Parameters.AddRange(param);
            cmd.CommandTimeout = 10;

            try
            {
                cmd.Connection = getConnection();
                cmd.Connection = getConnection();
                transaccion = cnn.BeginTransaction();

                if ((int)accion == 1 || (int)accion == 2)
                {
                    valor = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText += "SELECT SCOPE_IDENTITY();";
                    valor = Convert.ToInt32(cmd.ExecuteScalar());
                }
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
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

            cmd = new SqlCommand();
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