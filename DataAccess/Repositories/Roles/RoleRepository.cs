using Autofac.Features.AttributeFilters;
using Dapper;
using DataAccess.DbContexts;
using DataAccess.DbContexts.TicketSystemDb.Models.Roles;

namespace DataAccess.Repositories.Roles
{
    /// <summary>
    /// 角色 Repository
    /// </summary>
    public class RoleRepository : IRoleRepository
    {
        /// <summary>
        /// TicketSystem DBContext
        /// </summary>
        private readonly IDbContext _ticketSystemDbContext;

        /// <summary>
        /// The documentation text within the constructor's summary tag must begin with the text: Initializes a new instance of the <see cref="RoleRepository" /> class.
        /// </summary>
        /// <param name="ticketSystemDbContext">WebStore DBContext</param>
        public RoleRepository(
            [KeyFilter("TicketSystemDB")] IDbContext ticketSystemDbContext)
        {
            this._ticketSystemDbContext = ticketSystemDbContext;
        }

        /// <summary>
        /// 取得角色資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>角色資料</returns>
        public RoleModel GetRoleById(int id)
        {
            var sql = @"
            SELECT Role_Id
                  ,Role_Name
            FROM dbo.Role WITH (NOLOCK)
            WHERE Role_Id = @RoleId";

            var param = new
            {
                RoleId = id
            };

            using (var connection = this._ticketSystemDbContext.DbConnection())
            {
                return connection.QuerySingleOrDefault<RoleModel>(sql, param);
            }
        }
    }
}
