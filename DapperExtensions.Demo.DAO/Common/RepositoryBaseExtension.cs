using System;
using HY.DataAccess;
using Autofac;
using HY.Freamework.Demo;


namespace DapperExtensions.Demo.DAO.Common
{
    public abstract class RepositoryBaseExtension<T> : RepositoryBase<T>, IDisposable
            where T : class
    {
        protected RepositoryBaseExtension()
            : base(Helper.GetPerHttpRequestDBSession())
        {
        }

        protected RepositoryBaseExtension(IDBSession dbSession)
            : base(dbSession)
        {
        }

        public void Dispose()
        {

        }
    }
}
