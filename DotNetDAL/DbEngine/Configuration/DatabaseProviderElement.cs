using System;
using System.Configuration;

namespace Arch.Data.DbEngine.Configuration
{
    /// <summary>
    /// 数据库提供者
    /// </summary>
    public sealed class DatabaseProviderElement 
    {
        #region private field

        /// <summary>
        /// 名称
        /// </summary>
        private const String c_NameProperty = "name";

        /// <summary>
        /// 类型
        /// </summary>
        private const String c_TypeProperty = "type";

        #endregion

        #region public properties

        /// <summary>
        /// 名称
        /// </summary>
        public String Name
        {
            get;set;
        }

        /// <summary>
        /// 类型
        /// </summary>
        public Type Type
        {
            get { return Type.GetType(TypeName); }
            set { TypeName = value.AssemblyQualifiedName; }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public String TypeName
        {
            get;set;
        }

        #endregion
    }
}
