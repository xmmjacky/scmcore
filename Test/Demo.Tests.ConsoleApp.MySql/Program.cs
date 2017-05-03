using HY.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions.Lambda;
using DapperExtensions.Demo.Model.Entities;
using DapperExtensions;
using HY.DataAccess;

namespace Demo.Tests.ConsoleApp.MySql
{
    class Program
    {
        static void Main(string[] args)
        {


            var tHeaderobj = new TSoHeader()
            {
                id = 1001,
                cancel = 1,
                codec = "order000001",
                do_qty = 10,
                handle = 1,
                invoice_type = 1,
                item_need_qty = 20
            };
            Common.InsertTestData(tHeaderobj);
            Console.WriteLine("测试结束");
            Console.ReadLine();
        }


        public void LambaTest()
        {
            #region 查询
            var obj =
               DapperExtension.Instance(DataBaseType.MySql)
                   .LambdaQuery<TSoHeader>(Common.GetConnByKey(), null, null);
            var from = obj.Where(p => p.id == 1).Top(1).ToList();
            #endregion

            #region 插入

            //var tHeaderobj = new TSoHeader()
            //{
            //    id = 1000,
            //    cancel = 1,
            //    codec = "order000001",
            //    do_qty = 10,
            //    handle = 1,
            //    invoice_type = 1,
            //    item_need_qty = 20
            //};
            //var insetobj = DapperExtension.Instance().LambdaInsert<TSoHeader>(Common.GetConnByKey(),null,null);
            #endregion

            #region 更新

            var updateobj = DapperExtension.Instance().LambdaUpdate<TSoHeader>(Common.GetConnByKey(), null, null);
            #endregion
        }
    }
}
