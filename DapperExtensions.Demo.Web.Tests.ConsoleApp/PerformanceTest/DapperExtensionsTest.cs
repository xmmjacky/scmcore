using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions;
using Dapper;
using System.Data.SqlClient;
using HY.DataAccess;
using DapperExtensions.Demo.Model.Entities;

namespace DapperExtensions.Demo.Tests.performanceTest
{
    public class DapperExtensionsTest : IPerformanceTest
    {
        public DapperExtensionsTest(bool isClearData = false)
        {
            if (isClearData)
            {
                Common.TruncateData();
            }
            Common.ClearDBCache();
            DapperExtension.ClearCache();
        }



        public int InsertData(int num)
        {

            using (SqlConnection sqlconn = Common.GetConnByKey())
            {
                UsersEntity entity = new UsersEntity();
                entity.LoginName = Guid.NewGuid().ToString("N");
                entity.Password = "";
                entity.CreateTime = DateTime.Now;
                entity.UpdateTime = DateTime.Now;
                entity.Remark = num.ToString();
                for (int i = 0; i < num; i++)
                {
                    entity.Status = i % 2;
                    sqlconn.Insert<UsersEntity>(entity, null, dbType: DataBaseType.SqlServer);
                }
            }
            return num;
        }

        public int GetData(int num = 0)
        {
            IEnumerable<UsersEntity> list = new List<UsersEntity>();
            using (SqlConnection sqlconn = Common.GetConnByKey())
            {

                list = sqlconn.GetList<UsersEntity>(new { Status = num % 2 });

            }
            return list.Count();
        }

        public string TestName
        {
            get { return "DapperExt"; }
        }
    }
}
