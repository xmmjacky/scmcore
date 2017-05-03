using DapperExtensions.Demo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExtensions.Demo.Tests.performanceTest
{
    public interface IPerformanceTest
    {
        string TestName { get; }
         
        int InsertData(int num);


        int GetData(int num = 0);
    }
}
