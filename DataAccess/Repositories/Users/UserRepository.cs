using Autofac.Features.AttributeFilters;
using Dapper;
using DataAccess.DbContexts;
using DataAccess.DbContexts.TicketSystemDb.Models.Users;

namespace DataAccess.Repositories.Users
{
    /// <summary>
    /// 人員 Repository
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// TicketSystem DBContext
        /// </summary>
        private readonly IDbContext _ticketSystemDbContext;

        /// <summary>
        /// The documentation text within the constructor's summary tag must begin with the text: Initializes a new instance of the <see cref="UserRepository" /> class.
        /// </summary>
        /// <param name="ticketSystemDbContext">WebStore DBContext</param>
        public UserRepository(
            [KeyFilter("TicketSystemDB")] IDbContext ticketSystemDbContext)
        {
            this._ticketSystemDbContext = ticketSystemDbContext;
        }

        /// <summary>
        /// 取得人員資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>人員資料</returns>
        public UserModel GetUserById(int id)
        {
            var sql = @"
            SELECT User_Id
                  ,User_Name
                  ,User_Account
                  ,User_Password
                  ,User_RoleId
            FROM dbo.User WITH (NOLOCK)
            WHERE User_Id = @UserId";

            var param = new
            {
                UserId = id
            };

            using (var connection = this._ticketSystemDbContext.DbConnection())
            {
                return connection.QuerySingleOrDefault<UserModel>(sql, param);
            }
        }
    }
}
