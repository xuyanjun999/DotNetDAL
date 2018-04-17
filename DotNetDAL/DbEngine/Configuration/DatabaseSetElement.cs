using System;
using System.Collections.Generic;
using System.Configuration;

namespace Arch.Data.DbEngine.Configuration
{
    /// <summary>
    /// 数据库集配置元素
    /// </summary>
    public sealed class DatabaseSetElement
    {
        #region private fields

        /// <summary>
        /// 名称
        /// </summary>
        private const String c_NameProperty = "name";

        /// <summary>
        /// 提供者名称
        /// </summary>
        private const String c_ProviderProperty = "provider";

        /// <summary>
        /// 分片策略
        /// </summary>
        private const String c_ShardingStrategyProperty = "shardingStrategy";

        #endregion

        /// <summary>
        /// 名称
        /// </summary>
        public String Name
        {
            get; set;
        }

        /// <summary>
        /// 提供者名称
        /// </summary>
        public String Provider
        {
            get; set;
        }

        /// <summary>
        /// 数据库sharding策略配置项
        /// </summary>
        public List<DatabaseElement> Databases { get; set; } = new List<DatabaseElement>();

        /// <summary>
        /// shardStrategyClass属性 
        /// </summary>
        public String ShardingStrategy
        {
            get; set;
        }

    }
}
