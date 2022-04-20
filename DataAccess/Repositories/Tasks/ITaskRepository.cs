using DataAccess.DbContexts.TicketSystemDb.Models.Tasks;

namespace DataAccess.Repositories.Tasks
{
    /// <summary>
    /// 工單 Repository
    /// </summary>
    public interface ITaskRepository
    {
        /// <summary>
        /// 取得工單資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>工單資料</returns>
        TaskModel GetTaskById(int id);
    }
}
