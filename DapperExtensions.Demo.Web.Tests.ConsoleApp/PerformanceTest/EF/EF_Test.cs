﻿using DapperExtensions.Demo.Model.Entities;
using DapperExtensions.Demo.Tests.PerformanceTest.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExtensions.Demo.Tests.performanceTest
{
    public class EF_Test : IPerformanceTest
    {
        EFModel model = new EFModel();

        public EF_Test(bool isClearData = false)
        {
            if (isClearData)
            {
                Common.TruncateData();
            }
            Common.ClearDBCache();
        }



        public int InsertData(int num)
        {
            Users entity = new Users();
            entity.LoginName = Guid.NewGuid().ToString("N");
            entity.Password = "";
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = DateTime.Now;
            entity.Remark = num.ToString();
            for (int i = 0; i < num; i++)
            {
                entity.Status = i % 2;
                model.Set<Users>().Add(entity);
                model.SaveChanges();
            }

            return num;
        }

        public int GetData(int num = 0)
        {
            var eflist = model.Set<Users>().Where(p => p.Status == num % 2).ToList();

            
            return eflist.Count();

        }

        public string TestName
        {
            get { return "EF6"; }
        }
    }
}
