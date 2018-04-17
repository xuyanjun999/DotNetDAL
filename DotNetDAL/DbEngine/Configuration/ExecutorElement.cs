using System;
using System.Configuration;

namespace Arch.Data.DbEngine.Configuration
{
    public sealed class ExecutorElement 
    {
        /// <summary>
        /// 类型
        /// </summary>
        private const String type = "type";

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
            get
            {
                try
                {
                    return Type.GetType(TypeName);
                }
                catch
                {
                    return null;
                }

            }
            set { TypeName = value.AssemblyQualifiedName; }
        }

    }
}
