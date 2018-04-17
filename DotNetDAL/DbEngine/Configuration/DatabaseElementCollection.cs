using DAL.DbEngine.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Arch.Data.DbEngine.Configuration
{
    /// <summary>
    /// 数据库集集合
    /// </summary>
    public sealed class DatabaseElementCollection
    {

        #region collection operator

        public List<DatabaseElement> list()
        {
            //var configModel = ReadConfigModel.GetInstance().configModel;
            //var list = new List<DatabaseElement>();
            //if (configModel.databaseSets.Count == 0)
            //    throw new Exception("databaseSets error");

            //foreach (var item in configModel.databaseSets)
            //{
            //    foreach (var it in item.databaseSet)
            //    {
            //        Common.Enums.DatabaseType databaseType = 
            //            it.databaseType.ToLower().Equals("master") ?
            //            databaseType = Common.Enums.DatabaseType.Master : databaseType = Common.Enums.DatabaseType.Slave;

            //        var _Add_element = new DatabaseElement()
            //        {
            //            ConnectionString = it.connectionString,
            //            DatabaseType = databaseType,
            //            Name = it.name,
            //            Sharding = it.sharding
            //        };
            //        list.Add(_Add_element);
            //    }

            //}

            //var element = new DatabaseElement()
            //{
            //    ConnectionString = "dao_test0",
            //    DatabaseType = Common.Enums.DatabaseType.Master,
            //    Name = "dao_test0",
            //    Sharding = "0"
            //};

            //var element1 = new DatabaseElement()
            //{
            //    ConnectionString = "dao_test1",
            //    DatabaseType = Common.Enums.DatabaseType.Master,
            //    Name = "dao_test1",
            //    Sharding = "1"
            //};
            //list.Add(element);
            //list.Add(element1);
            return null;
        }
        #endregion
    }
}
