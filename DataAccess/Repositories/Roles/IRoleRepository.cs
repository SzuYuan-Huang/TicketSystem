using DataAccess.DbContexts.TicketSystemDb.Models.Roles;

namespace DataAccess.Repositories.Roles
{
    /// <summary>
    /// 角色 Repository
    /// </summary>
    public interface IRoleRepository
    {
        /// <summary>
        /// 取得角色資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>角色資料</returns>
        RoleModel GetRoleById(int id);
    }
}
