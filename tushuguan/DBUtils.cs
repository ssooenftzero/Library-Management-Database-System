using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentData;

namespace tushuguan
{
    class DBUtils
    {
        public static IDbContext QueryDB()
        {
            //return new DbContext().ConnectionStringName("MyDatabase",
            //        new SqlServerProvider());

            return new DbContext().ConnectionString(
            "Data Source=127.0.0.1;Initial Catalog=library1;Integrated Security=True;", new SqlServerProvider());

        }
    }
}
