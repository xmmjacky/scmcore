using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions;
using Dapper;
using System.Data.SqlClient;
using HY.DataAccess;
using System.Configuration;
using System.Data;
using DapperExtensions.Demo.Model.Entities;
using MySql.Data.MySqlClient;

namespace Demo.Tests.ConsoleApp.MySql
{
    public class Common
    {

        public static MySqlConnection GetConnByKey(string connKey = "DefaultConnection")
        {
            string connstr = ConfigurationManager.ConnectionStrings[connKey].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            return con;
        }

        public static void InsertTestData<T>(T entity) where T:class 
        {
           var temp=Convert.ToInt32(DapperExtension.Instance(DataBaseType.MySql).Insert(GetConnByKey(), entity, null,null));


               
        }


    }
}
