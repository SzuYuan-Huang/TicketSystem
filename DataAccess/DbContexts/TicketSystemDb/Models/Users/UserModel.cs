namespace DataAccess.DbContexts.TicketSystemDb.Models.Users
{
    /// <summary>
    /// 人員序號
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// 人員序號
        /// </summary>
        public int User_Id { get; set; }

        /// <summary>
        /// 人員名稱
        /// </summary>
        public string User_Name { get; set; }

        /// <summary>
        /// 人員帳號
        /// </summary>
        public string User_Account { get; set; }

        /// <summary>
        /// 人員密碼
        /// </summary>
        public string User_Password { get; set; }

        /// <summary>
        /// 人員角色序號
        /// </summary>
        public string User_RoleId { get; set; }
    }
}
