namespace DataAccess.DbContexts.TicketSystemDb.Models.SystemFunctionRoleMappings
{
    /// <summary>
    /// 系統功能角色模組
    /// </summary>
    public class SystemFunctionRoleMappingModel
    {
        /// <summary>
        /// 系統功能角色序號
        /// </summary>
        public int SystemFunctionRoleMapping_Id { get; set; }

        /// <summary>
        /// 角色序號
        /// </summary>
        public int SystemFunctionRoleMapping_RoleId { get; set; }

        /// <summary>
        /// 系統功能序號
        /// </summary>
        public int SystemFunctionRoleMapping_SystemFunctionId { get; set; }
    }
}
