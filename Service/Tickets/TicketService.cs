using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.DbContexts.TicketSystemDb.Models.Tickets;
using DataAccess.Repositories.Tickets;
using Entity.Tickets;

namespace Service.Tickets
{
    /// <summary>
    /// 工單服務
    /// </summary>
    public class TicketService : ITicketService
    {
        /// <summary>
        /// 工單 Repository
        /// </summary>
        private readonly ITicketRepository _ticketRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketService" /> class.
        /// </summary>
        /// <param name="ticketRepository">工單 Repository</param>
        public TicketService(
            ITicketRepository ticketRepository)
        {
            this._ticketRepository = ticketRepository;
        }

        /// <summary>
        /// 取得工單 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>工單廖</returns>
        public TicketEntity GetTicketById(int id)
        {
            var data = this._ticketRepository.GetTicketById(id);

            if (data == null)
            {
                return null;
            }

            return new TicketEntity
            {
                Id = data.Ticket_Id,
                Title = data.Ticket_Title,
                Description = data.Ticket_Description,
                TypeDef = data.Ticket_TypeDef,
                StatusDef = data.Ticket_StatusDef,
                AssignUserId = data.Ticket_AssignUserId,
                CreatedUserId = data.Ticket_CreatedUserId
            };
        }

        /// <summary>
        /// 建立工單
        /// </summary>
        /// <param name="entity">工單資料</param>
        public void CreateTicket(CreateTicketEntity entity)
        {
            if (entity == null)
            {
                return;
            }

            this._ticketRepository.CreateTicket(new TicketModel
            {
                Ticket_Title = entity.Title,
                Ticket_Description = entity.Description,
                Ticket_TypeDef = entity.TypeDef,
                Ticket_StatusDef = entity.StatusDef,
                Ticket_AssignUserId = entity.AssignUserId,
                Ticket_CreatedUserId = entity.CreatedUserId
            });
        }
    }
}
