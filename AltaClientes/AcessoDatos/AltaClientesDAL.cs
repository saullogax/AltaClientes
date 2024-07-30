﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;




namespace AltaClientes.AcessoDatos
{
    class AltaClientesDAL
    {
        #region Elementos

        /// <summary>
        /// Objeto de la instancia Odbc, para la conexión a SQL Server.
        /// </summary>
        private AccesoSqlServer accesoSqlServer;

        #endregion Elementos
        #region Constructor

        /// <summary>
        /// Constructor para instanciar el objeto odbc con la cadena de conexión a SQL Server. 
        /// </summary>
        public AltaClientesDAL()
        {
            accesoSqlServer = new AccesoSqlServer(Program.CadenaConexionSqlServer);
        }

        #endregion Constructor

        /// <summary>
        /// Método para agregar un usuario a la Base de Datos.
        /// </summary>
        /// <param name="u">Entidad usuario con los datos a guardar</param>
        /// <returns>Regresa true si guardó el registro, false si ocurrió un error.</returns>
        public Boolean GuardarCliente(int num, string nombre, string telefono, string fechanac,string domicilio, int numeroint, string estatus )
        {
            Boolean resultado = false;
            string query = String.Empty;

            try
            {
                if (accesoSqlServer.Open())
                {
                    query = String.Format($"EXEC altaclientes.dbo.proc_GuardarClientes @numcliente = {num} ," +
                                        $" @nomcliente = '{nombre}', @telefono = '{telefono}',@fechanac = '{fechanac}', @domicilio = '{domicilio}', @interior ='{numeroint}', @estatus = '{estatus}'");
                    
                    resultado = Convert.ToBoolean(accesoSqlServer.ExecuteQuery(query));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al guardar usuario",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                //Error.Guardar(accesoSqlServer.SqlConexion,
                //              "MAPER001",
                //              "AsignarUsuarioDAL",
                //              "GuardarUsuario",
                //              "proc_MaPer001GuardarUsuarios",
                //              "0",
                //              ex.Message);
            }
            finally
            {
                accesoSqlServer.Close();
            }

            return resultado;

        }

        
        public DataTable CargarClientes()
        {
            String query = String.Empty;
            DataTable dtUsuarios;

            try
            {
                dtUsuarios = new DataTable();
                query = "EXEC altaclientes.dbo.proc_CargarClientes";

                if (accesoSqlServer.Open())
                {
                    dtUsuarios = accesoSqlServer.ExecuteDataTable(query);

                }


            }
            catch (Exception ex)
            {
                dtUsuarios = null;
                MessageBox.Show("Error al cargar clientes",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                
            }
            finally
            {
                accesoSqlServer.Close();
            }

            return dtUsuarios;
        }



        public DataTable CargarEstatus()
        {
            String query = String.Empty;
            DataTable dtEstatus;

            try
            {
                dtEstatus = new DataTable();
                query = "EXEC altaclientes.dbo.proc_CargarEstatus";

                if (accesoSqlServer.Open())
                {
                    dtEstatus = accesoSqlServer.ExecuteDataTable(query);

                }


            }
            catch (Exception ex)
            {
                dtEstatus = null;
                MessageBox.Show("Error al cargar estatus",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }
            finally
            {
                accesoSqlServer.Close();
            }

            return dtEstatus;
        }

        public DataTable ultimoCodigo() {

            String query = String.Empty;
            DataTable dtUltimoCodigo;

            try
            {
                dtUltimoCodigo = new DataTable();
                query = "EXEC altaclientes.dbo.proc_ultimoCodigo";

                if (accesoSqlServer.Open())
                {
                    dtUltimoCodigo = accesoSqlServer.ExecuteDataTable(query);

                    

                }


            }
            catch (Exception ex)
            {
                dtUltimoCodigo = null;
                MessageBox.Show("Error al cargar codigo",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }
            finally
            {
                accesoSqlServer.Close();
            }

            return dtUltimoCodigo;
        }
       

    }
}
