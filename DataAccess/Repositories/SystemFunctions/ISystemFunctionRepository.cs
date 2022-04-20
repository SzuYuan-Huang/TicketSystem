using DataAccess.DbContexts.TicketSystemDb.Models.SystemFunctions;

namespace DataAccess.Repositories.SystemFunctions
{
    /// <summary>
    /// 系統功能 Repository
    /// </summary>
    public interface ISystemFunctionRepository
    {
        /// <summary>
        /// 取得系統功能資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>系統功能角色資料</returns>
        SystemFunctionModel GetSystemFunctionById(int id);
    }
}
