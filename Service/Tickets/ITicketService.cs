using System;
using System.Collections.Generic;
using System.Text;
using Entity.Tickets;

namespace Service.Tickets
{
    /// <summary>
    /// 工單服務
    /// </summary>
    public interface ITicketService
    {
        /// <summary>
        /// 取得工單 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>工單廖</returns>
        TicketEntity GetTicketById(int id);

        /// <summary>
        /// 建立工單
        /// </summary>
        /// <param name="entity">工單資料</param>
        void CreateTicket(CreateTicketEntity entity);
    }
}
