//
//Created: 2016-05-20 11:33:37
//Author: 代码生成
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperExtensions.Mapper;
using HY.DataAccess.Utils;

namespace DapperExtensions.Demo.Model.Entities
{
    /// <summary>
    /// HY：实体对象
    /// </summary>
    [Serializable]
    public class UsersEntity
    {
        [DbColumn(ColumnName = "id",Ignore = true)]
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 登录名称
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 状态   1：启用  0禁用
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        //public string Remark1 { get; set; } 

    }




    /// <summary>
    /// Users：实体对象映射关系
    /// </summary>
    [Serializable]
    public class UsersEntityORMMapper : ClassMapper<UsersEntity>
    {
        public UsersEntityORMMapper()
        {
            base.Table("Users");
            //Map(f => f.Remark1).Ignore();//设置忽略 
            //Map(f => f.Name).Key(KeyType.Identity);//设置主键  (如果主键名称不包含字母“ID”，请设置)      
            AutoMap();
        }
    }
    [Serializable]
    public class TSoHeader
    {
        [DbColumn(Ignore = true)]
        public long id { get; set; }
        public string app { get; set; }
        public long unit_id { get; set; }
        public int types { get; set; }
        public int modes { get; set; }
        public int kinds { get; set; }

        public string codec { get; set; }
        public long wms_id { get; set; }
        public long extunio_id { get; set; }
        public long consumer_id { get; set; } //暂时不要
        public DateTime? order_time { get; set; }
        public int payment_type { get; set; }
        public int invoice_type { get; set; }
        public int item_need_qty { get; set; }
        public int item_real_qty { get; set; }
        public int unit_need_qty { get; set; }
        public int unit_real_qty { get; set; }
        public int handle { get; set; }

        public int do_qty { get; set; }
        public int vl_qty { get; set; }
        public int cancel { get; set; }


    }

    /// <summary>
    /// Users：实体对象映射关系
    /// </summary>
    [Serializable]
    public class TSoHeaderORMMapper : ClassMapper<TSoHeader>
    {
        public TSoHeaderORMMapper()
        {
            base.Table("oms_so_header");
            //Map(f => f.Remark1).Ignore();//设置忽略 
            //Map(f => f.Name).Key(KeyType.Identity);//设置主键  (如果主键名称不包含字母“ID”，请设置)      
            AutoMap();
        }
    }
}




