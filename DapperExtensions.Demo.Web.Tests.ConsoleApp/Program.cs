using DapperExtensions.Demo.Model.Entities;
using DapperExtensions.Demo.Tests.performanceTest;
using HY.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions.Lambda;

namespace DapperExtensions.Demo.Tests
{
    class Program
    {
        static Stopwatch _watch = new Stopwatch();
        static int insertNum = 1000;
        static int selectNum = 100;
        static bool isClearData = false; //测试前是否清楚数据


        static void Main(string[] args)
        {










            PerformanceTest();

            //LambdaQueryHelper<UsersEntity> from = DapperExtension.DapperImplementor.LambdaQuery<UsersEntity>((IDbConnection)Common.GetConnByKey(), null, null);



            //int id = 10;
            //int records = 0;
            //var where = new Where<UsersEntity>();
            //where.And(o => o.Status == 1);
            //where.And<UserInfoEntity>((a, b) => b.CardId != "" && b.Age > 0);
            //if (id > 0)
            //    where.And(o => o.UserId > 0);

            //var lambda = from.InnerJoin<UserInfoEntity>((a, b) => a.UserId == b.UserId).Select<UserInfoEntity>((a, b) => new
            //{
            //    a.UserId,
            //    a.LoginName,
            //    a.CreateTime,
            //    b.Age,
            //    b.Name,
            //    b.Sex,
            //    b.CardId,
            //    b.Email,
            //    b.Mobile,
            //    b.Remark
            //}).Where(where);
            //records = lambda.Count();
            //var list = lambda.OrderByDescending(o => o.UserId).Page(2, 2).ToList<UsersEntity>().ToList();













            //var list = from.Select(p => p.UserId)
            //        .AddSelect(p => p.LoginName)
            //        .Page(1, 2).ToList();

            //list = from.Page(2, 2).ToList();

            //Console.WriteLine(from.SqlString);

            //foreach (var item in from.Parameters)
            //{
            //    Console.WriteLine("参数： " + item.Key + "  " + item.Value.ParameterValue.ToString());
            //}



            Console.WriteLine("测试结束");
            Console.ReadLine();
        }



        static void BeginTest(IPerformanceTest test)
        {
            //插入
            //Console.WriteLine();
            //_watch.Restart();
            //int num = test.InsertData(insertNum);
            //_watch.Stop();
            //if (num > 0)
            //{
            //    Console.WriteLine(string.Format("{0}插入{1}条数据用时：{2}毫秒,平均每条耗时{3}毫秒", test.TestName, insertNum, _watch.ElapsedMilliseconds, _watch.ElapsedMilliseconds / insertNum));
            //}

            //return;

            //查询
            _watch.Restart();
            int mapNum = 0;
            for (int i = 0; i < selectNum; i++)
            {
                //test.InsertData(1);
                mapNum = test.GetData(1);
            }
            _watch.Stop();
            Console.WriteLine(string.Format("{0}查询测试：映射{1}条数据,执行{2}次总耗时{3}毫秒,平均耗时{4}毫秒", test.TestName, mapNum, selectNum, _watch.ElapsedMilliseconds, _watch.ElapsedMilliseconds / selectNum));

        }



        static void PerformanceTest()
        {

            IPerformanceTest test;

            Common.TruncateData();
            Common.InsertTestData(500);
            Console.WriteLine("造数完成");
            //return;


            test = new NormalMapping(isClearData);
            BeginTest(test);

            test = new AdoTeset(isClearData);
            BeginTest(test);


            test = new DapperTest(isClearData);
            BeginTest(test);

            //test = new DapperExtensionsTest(isClearData);
            //BeginTest(test);

            //test = new DapperExtensions_LambdaTest(isClearData);
            //BeginTest(test);


            //test = new EF_Test(isClearData);
            //BeginTest(test);

        }


    }
}










