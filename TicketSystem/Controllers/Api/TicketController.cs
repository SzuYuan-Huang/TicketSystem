using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Tickets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Tickets;

namespace TicketSystem.Controllers.Api
{
    /// <summary>
    /// 工單 Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        /// <summary>
        /// 工單服務
        /// </summary>
        private readonly ITicketService _ticketService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketController" /> class.
        /// </summary>
        /// <param name="ticketService">工單服務</param>
        public TicketController(
            ITicketService ticketService)
        {
            this._ticketService = ticketService;
        }

        /// <summary>
        /// 取得工單資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>工單資料</returns>
        [Route("GetTicketById")]
        public TicketEntity GetTicketById(int id)
        {
            return this._ticketService.GetTicketById(id);
        }

        /// <summary>
        /// 建立工單
        /// </summary>
        /// <param name="entity">建立工單資料</param>
        [Route("CreateTicket")]
        [HttpPost]
        public void CreateTicket(CreateTicketEntity entity)
        {
            this._ticketService.CreateTicket(entity);
        }

        /// <summary>
        /// 更新工單
        /// </summary>
        /// <param name="entity">更新工單資料</param>
        [Route("UpdateTicket")]
        [HttpPut]
        public void UpdateTicket(UpdateTicketEntity entity)
        {
            this._ticketService.UpdateTicket(entity);
        }

        /// <summary>
        /// 刪除工單
        /// </summary>
        /// <param name="id">序號</param>
        [Route("DeleteTicket")]
        [HttpDelete]
        public void DeleteTicket(int id)
        {
            this._ticketService.DeleteTicket(id);
        }
    }
}
