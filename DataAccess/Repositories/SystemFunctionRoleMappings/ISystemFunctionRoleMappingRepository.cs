using DataAccess.DbContexts.TicketSystemDb.Models.SystemFunctionRoleMappings;

namespace DataAccess.Repositories.SystemFunctionRoleMappings
{
    /// <summary>
    /// 系統功能角色 Repostiroy
    /// </summary>
    public interface ISystemFunctionRoleMappingRepository
    {
        /// <summary>
        /// 取得系統功能角色資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>系統功能角色資料</returns>
        SystemFunctionRoleMappingModel GetSystemFunctionRoleMappingById(int id);
    }
}
