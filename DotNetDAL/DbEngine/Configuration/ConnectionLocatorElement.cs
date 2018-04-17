using System;
using System.Configuration;

namespace Arch.Data.DbEngine.Configuration
{
    public sealed class ConnectionLocatorElement
    {
        /// <summary>
        /// 类型
        /// </summary>
        private const String type = "type";

        private const String path = "path";

        /// <summary>
        /// 类型
        /// </summary>
        public String TypeName
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

        public String Path
        {
            get;set;
        }

    }
}
