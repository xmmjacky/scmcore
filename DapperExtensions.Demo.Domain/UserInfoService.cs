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
using DapperExtensions.Demo.DAO;


namespace HY.Domain
{
    /// <summary>
    /// UserInfo：服务访问对象
    /// </summary>
    public class UserInfoService : ServiceBaseExtension<UserInfoEntity>
    {
        private readonly UserInfoRepository _UserInfoRepository;

        public UserInfoService(UserInfoRepository userInfoRepository)
        {
            _UserInfoRepository = userInfoRepository;
        }


    }
}
