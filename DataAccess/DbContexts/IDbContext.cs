using System;
using System.Data;

namespace DataAccess.DbContexts
{
    /// <summary>
    /// 定義 DB Context 的方法。
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// 資料庫連線。
        /// </summary>
        Func<IDbConnection> DbConnection { get; }
    }
}
