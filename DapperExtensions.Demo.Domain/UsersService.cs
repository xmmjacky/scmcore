//
//Created: 2016-05-20 11:34:00
//Author: 代码生成
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperExtensions;
using DapperExtensions.Demo.Domain.Common;
using DapperExtensions.Demo.Model.Entities;
using HY.Freamework;
using HY.DataAccess;
using DapperExtensions.Lambda;
using DapperExtensions.Demo.DAO;
using System.Data;


namespace HY.Domain
{
    /// <summary>
    /// Users：服务访问对象
    /// </summary>
    public class UsersService : ServiceBaseExtension<UsersEntity>
    {
        private readonly UsersRepository _UsersRepository;
        private UserInfoService _userInfoService;

        public String Str = Guid.NewGuid().ToString("N");

        public UsersService(UsersRepository usersRepository, UserInfoService userInfoService)
        {
            _UsersRepository = usersRepository;
            _userInfoService = userInfoService;

            //UsersEntity u = new UsersEntity();
            //UserInfoEntity ui = new UserInfoEntity();
            //using (HY.DataAccess.Transactions.TransactionScope tranScope = new HY.DataAccess.Transactions.TransactionScope())
            //{
            //    this.Insert(u);
            //    _userInfoService.Insert(ui);
            //    tranScope.Complete();
            //}



            //IDbTransaction tran = this.DBSession.Begin();
            //this.Insert(u,tran);
            //_userInfoService.Insert(ui,tran);
            //tran.Commit();


        }


    }
}
