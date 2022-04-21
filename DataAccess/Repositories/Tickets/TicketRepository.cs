﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;
using Dapper;
using DataAccess.DbContexts;
using DataAccess.DbContexts.TicketSystemDb.Models.Tickets;

namespace DataAccess.Repositories.Tickets
{
    /// <summary>
    /// 工單 Repository
    /// </summary>
    public class TicketRepository : ITicketRepository
    {
        /// <summary>
        /// TicketSystem DBContext
        /// </summary>
        private readonly IDbContext _ticketSystemDbContext;

        /// <summary>
        /// The documentation text within the constructor's summary tag must begin with the text: Initializes a new instance of the <see cref="TicketRepository" /> class.
        /// </summary>
        /// <param name="ticketSystemDbContext">WebStore DBContext</param>
        public TicketRepository(
            [KeyFilter("TicketSystemDB")] IDbContext ticketSystemDbContext)
        {
            this._ticketSystemDbContext = ticketSystemDbContext;
        }

        /// <summary>
        /// 取得工單資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>工單資料</returns>
        public TicketModel GetTicketById(int id)
        {
            var sql = @"
            SELECT Ticket_Id
                  ,Ticket_Title
                  ,Ticket_Description
                  ,Ticket_TypeDef
                  ,Ticket_StatusDef
                  ,Ticket_AssignUserId
                  ,Ticket_CreatedUserId
            FROM dbo.Ticket WITH (NOLOCK)
            WHERE Ticket_Id = @TicketId";

            var param = new
            {
                TicketId = id
            };

            using (var connection = this._ticketSystemDbContext.DbConnection())
            {
                return connection.QuerySingleOrDefault<TicketModel>(sql, param);
            }
        }

        /// <summary>
        /// 建立工單
        /// </summary>
        /// <param name="createTicketData">建立工單資料</param>
        public void CreateTicket(TicketModel createTicketData)
        {
            var sql = @" 
            INSERT INTO dbo.Ticket
            (
                Ticket_Title
               ,Ticket_Description
               ,Ticket_TypeDef
               ,Ticket_StatusDef
               ,Ticket_AssignUserId
               ,Ticket_CreatedUserId
            )
            VALUES
            (
                @Title
               ,@Description
               ,@TypeDef
               ,@StatusDef
               ,@AssignUserId
               ,@CreatedUserId
            )";

            var param = new
            {
                Title = createTicketData.Ticket_Title,
                Description = createTicketData.Ticket_Description,
                TypeDef = createTicketData.Ticket_TypeDef,
                StatusDef = createTicketData.Ticket_StatusDef,
                AssignUserId = createTicketData.Ticket_AssignUserId,
                CreatedUserId = createTicketData.Ticket_CreatedUserId
            };

            using (var connection = this._ticketSystemDbContext.DbConnection())
            {
                connection.Execute(sql, param);
            }
        }
    }
}
