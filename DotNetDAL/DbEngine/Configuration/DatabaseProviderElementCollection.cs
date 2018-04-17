using DAL.DbEngine.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Arch.Data.DbEngine.Configuration
{
    /// <summary>
    /// 数据库提供者集合
    /// </summary>
    public sealed class DatabaseProviderElementCollection
    {
        public List<DatabaseProviderElement> ProviderElement()
        {
            try
            {
                var configModel = ReadConfigModel.GetInstance().configModel;
                var prov = new List<DatabaseProviderElement>();
                var database = new DatabaseProviderElement();
                database.Name = configModel.dbEngine.name;
                database.TypeName = configModel.dbEngine.typeName;
                database.Type = Type.GetType(database.TypeName);
                prov.Add(database);
                return prov;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }


        public static List<DatabaseSetElement> DatabaseSetElement()
        {
            var DatabaseSets = new List<DatabaseSetElement>();
            var configModel = ReadConfigModel.GetInstance().configModel;
            foreach (var item in configModel.databaseSets)
            {
                List<DatabaseElement> databaseElements = new List<DatabaseElement>();
                foreach (var it in item.databaseSet)
                {
                    Common.Enums.DatabaseType databaseType =
                        it.databaseType.ToLower().Equals("master") ?
                        databaseType = Common.Enums.DatabaseType.Master : databaseType = Common.Enums.DatabaseType.Slave;
                    databaseElements.Add(new DatabaseElement()
                    {
                        ConnectionString = it.connectionString,
                        DatabaseType = databaseType,
                        Start = it.Start,
                        End = it.End,
                        Name = it.name,
                        Ratio = 1,
                        Sharding = it.sharding,
                    });
                }
                DatabaseSets.Add(new DatabaseSetElement()
                {
                    Databases = databaseElements,
                    Name = item.Name,
                    Provider = item.provider,
                    ShardingStrategy = item.shardingStrategy
                });
            }
            return DatabaseSets;
        }


    }
}
