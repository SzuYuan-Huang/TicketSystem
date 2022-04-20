using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbContexts.TicketSystemDb
{
    /// <summary>
    /// TicketSystemDb Context
    /// </summary>
    public class TicketSystemDbContext : IDbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSystemDbContext" /> class.
        /// </summary>
        public TicketSystemDbContext()
        {
            var connectionString = Environment.GetEnvironmentVariable("TicketSystemDBContext");
            this.DbConnection = () => new SqlConnection(connectionString);
        }

        /// <summary>
        /// 資料庫連線。
        /// </summary>
        public Func<IDbConnection> DbConnection { get; }
    }
}
