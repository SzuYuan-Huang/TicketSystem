using Autofac.Features.AttributeFilters;
using Dapper;
using DataAccess.DbContexts;
using DataAccess.DbContexts.TicketSystemDb.Models.SystemFunctions;

namespace DataAccess.Repositories.SystemFunctions
{
    /// <summary>
    /// 系統功能 Repository
    /// </summary>
    public class SystemFunctionRepository : ISystemFunctionRepository
    {
        /// <summary>
        /// TicketSystem DBContext
        /// </summary>
        private readonly IDbContext _ticketSystemDbContext;

        /// <summary>
        /// The documentation text within the constructor's summary tag must begin with the text: Initializes a new instance of the <see cref="SystemFunctionRepository" /> class.
        /// </summary>
        /// <param name="ticketSystemDbContext">WebStore DBContext</param>
        public SystemFunctionRepository(
            [KeyFilter("TicketSystemDB")] IDbContext ticketSystemDbContext)
        {
            this._ticketSystemDbContext = ticketSystemDbContext;
        }

        /// <summary>
        /// 取得系統功能資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>系統功能角色資料</returns>
        public SystemFunctionModel GetSystemFunctionById(int id)
        {
            var sql = @"
            SELECT SystemFunction_Id
                  ,SystemFunction_Name
            FROM dbo.SystemFunction WITH (NOLOCK)
            WHERE SystemFunction_Id = @SystemFunctionId";

            var param = new
            {
                SystemFunctionId = id
            };

            using (var connection = this._ticketSystemDbContext.DbConnection())
            {
                return connection.QuerySingleOrDefault<SystemFunctionModel>(sql, param);
            }
        }
    }
}
