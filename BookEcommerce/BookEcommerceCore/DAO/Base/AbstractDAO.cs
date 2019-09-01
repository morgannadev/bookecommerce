using BookEcommerceCore.Core;
using BookEcommerceCore.Utils;
using BookEcommerceDominio.Geral;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace BookEcommerceCore.DAO.Base
{
    public class AbstractDAO : ConexaoDB, IDAO
    {
        protected string table { get; set; }
        protected string idTable { get; set; }
        protected new DbConnection dbConnection;

        public AbstractDAO(string table, string idTable)
        {
            this.table = table;
            this.idTable = idTable;
        }

        public AbstractDAO(DbConnection dbConnection, string table, string idTable)
        {
            this.table = table;
            this.idTable = idTable;
            this.dbConnection = dbConnection;
        }

        public void OpenConnection()
        {
            try
            {
                if (dbConnection == null)
                {
                    dbConnection = GetDbConnection();
                    dbConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            if (dbConnection != null)
            {
                dbConnection.Close();
                dbConnection.Dispose();
            }
        }

        public void BeginTransaction()
        {
            try
            {
                dbTransaction = dbConnection.BeginTransaction();
            }
            catch (DbException ex)
            {
                ex.ToString();
                throw ex;
            }
        }

        public void Rollback()
        {
            try
            {
                dbTransaction.Rollback();
            }
            catch (DbException ex)
            {
                ex.ToString();
                throw ex;
            }
        }

        public void Commit()
        {
            try
            {
                dbTransaction.Commit();
            }
            catch (DbException ex)
            {
                ex.ToString();
                throw ex;
            }
        }

        public void Alterar(EntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntidadeDominio> Consultar(IEntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(EntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }

        public void Salvar(EntidadeDominio entidade)
        {
            throw new NotImplementedException();
        }
    }
}
