using Arch.Data.Common.Enums;
using System;
using System.Configuration;

namespace Arch.Data.DbEngine.Configuration
{
    /// <summary>
    /// 物理数据库链接配置元素
    /// </summary>
    public sealed class DatabaseElement 
    {
        #region private fields

        /// <summary>
        /// 名称
        /// </summary>
        private const String c_NameProperty = "name";

        /// <summary>
        /// 数据库主从类型
        /// </summary>
        private const String c_DatabaseTypeProperty = "databaseType";

        /// <summary>
        /// 分片标识
        /// </summary>
        private const String c_ShardingProperty = "sharding";

        /// <summary>
        /// 调用权重
        /// </summary>
        private const String c_RatioProperty = "ratio";

        /// <summary>
        /// 链接字符串名称
        /// </summary>
        private const String c_ConnectionStringProperty = "connectionString";

        /// <summary>
        /// 连续型sharding初始值
        /// </summary>
        private const String c_SequenceStart = "start";

        /// <summary>
        /// 连续型sharding结束值
        /// </summary>
        private const String c_SequenceEnd = "end";

        #endregion

        #region public properties

        /// <summary>
        /// 名称,关键字
        /// </summary>
        public String Name
        {
            get;set;
        }

        /// <summary>
        /// 从库访问权重
        /// </summary>
        public Int32 Ratio
        {
            get;set;
        }

        /// <summary>
        /// 数据库主从类型
        /// </summary>
        public DatabaseType DatabaseType
        {
            get;set;
        }

        /// <summary>
        /// 分片标识
        /// </summary>
        public String Sharding
        {
            get;set;
        }

        /// <summary>
        /// 链接字符串名称
        /// </summary>
        public String ConnectionString
        {
            get;set;
        }

        /// <summary>
        /// 连续型
        /// </summary>
        public String Start
        {
            get;set;
        }

        /// <summary>
        /// 连续型
        /// </summary>
        public String End
        {
            get;set;
        }

        #endregion
    }
}
