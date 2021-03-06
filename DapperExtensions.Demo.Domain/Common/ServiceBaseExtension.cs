﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperExtensions;
using HY.DataAccess;
using Autofac;

using HY.Freamework.Demo;
using DapperExtensions.Demo.DAO.Common;

namespace DapperExtensions.Demo.Domain.Common
{
    public abstract class ServiceBaseExtension<T> : RepositoryServiceBase<T>, IDisposable
       where T : class
    {
        public IList<IDisposable> DisposableObjects { get; private set; }

        public ServiceBaseExtension(string connKey = "DefaultConnection")
            : base(connKey)
        {
            DisposableObjects = new List<IDisposable>();
        }


        protected void AddDisposableObject(object obj)
        {
            IDisposable disposable = obj as IDisposable;
            if (null != disposable)
            {
                DisposableObjects.Add(disposable);
            }
        }

        public void Dispose()
        {
            foreach (IDisposable obj in DisposableObjects)
            {
                if (null != obj)
                {
                    obj.Dispose();
                }
            }
        }
    }
}