using DataAccess.DbContexts.TicketSystemDb.Models.Users;

namespace DataAccess.Repositories.Users
{
    /// <summary>
    /// 人員 Repository
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// 取得人員資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>人員資料</returns>
        UserModel GetUserById(int id);
    }
}
