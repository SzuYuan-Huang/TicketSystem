using DataAccess.DbContexts.TicketSystemDb.Models.Tickets;

namespace DataAccess.Repositories.Tickets
{
    /// <summary>
    /// 工單 Repository
    /// </summary>
    public interface ITicketRepository
    {
        /// <summary>
        /// 取得工單資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>工單資料</returns>
        TicketModel GetTicketById(int id);

        /// <summary>
        /// 建立工單
        /// </summary>
        /// <param name="createTicketData">建立工單資料</param>
        void CreateTicket(TicketModel createTicketData);

        /// <summary>
        /// 更新工單
        /// </summary>
        /// <param name="updateTicketData">更新工單資料</param>
        void UpdateTicket(TicketModel updateTicketData);

        /// <summary>
        /// 刪除工單
        /// </summary>
        /// <param name="id">序號</param>
        void DeleteTicket(int id);
    }
}
