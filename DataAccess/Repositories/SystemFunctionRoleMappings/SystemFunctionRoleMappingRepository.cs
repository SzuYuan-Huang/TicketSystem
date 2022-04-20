using Autofac.Features.AttributeFilters;
using Dapper;
using DataAccess.DbContexts;
using DataAccess.DbContexts.TicketSystemDb.Models.SystemFunctionRoleMappings;

namespace DataAccess.Repositories.SystemFunctionRoleMappings
{
    /// <summary>
    /// 系統功能角色 Repository
    /// </summary>
    public class SystemFunctionRoleMappingRepository : ISystemFunctionRoleMappingRepository
    {
        /// <summary>
        /// TicketSystem DBContext
        /// </summary>
        private readonly IDbContext _ticketSystemDbContext;

        /// <summary>
        /// The documentation text within the constructor's summary tag must begin with the text: Initializes a new instance of the <see cref="SystemFunctionRoleMappingRepository" /> class.
        /// </summary>
        /// <param name="ticketSystemDbContext">WebStore DBContext</param>
        public SystemFunctionRoleMappingRepository(
            [KeyFilter("TicketSystemDB")] IDbContext ticketSystemDbContext)
        {
            this._ticketSystemDbContext = ticketSystemDbContext;
        }

        /// <summary>
        /// 取得系統功能角色資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>系統功能角色資料</returns>
        public SystemFunctionRoleMappingModel GetSystemFunctionRoleMappingById(int id)
        {
            var sql = @"
            SELECT SystemFunctionRoleMapping_Id
                  ,SystemFunctionRoleMapping_RoleId
                  ,SystemFunctionRoleMapping_SystemFunctionId
            FROM dbo.SystemFunctionRoleMapping WITH (NOLOCK)
            WHERE SystemFunctionRoleMapping_Id = @SystemFunctionRoleMappingId";

            var param = new
            {
                SystemFunctionRoleMappingId = id
            };

            using (var connection = this._ticketSystemDbContext.DbConnection())
            {
                return connection.QuerySingleOrDefault<SystemFunctionRoleMappingModel>(sql, param);
            }
        }
    }
}
