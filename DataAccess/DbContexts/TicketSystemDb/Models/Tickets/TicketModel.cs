namespace DataAccess.DbContexts.TicketSystemDb.Models.Tickets
{
    /// <summary>
    /// 工單模組
    /// </summary>
    public class TicketModel
    {
        /// <summary>
        /// 工單序號
        /// </summary>
        public int Ticket_Id { get; set; }

        /// <summary>
        /// 工單標題
        /// </summary>
        public string Ticket_Title { get; set; }

        /// <summary>
        /// 工單描述
        /// </summary>
        public string Ticket_Description { get; set; }

        /// <summary>
        /// 工單類別
        /// </summary>
        public string Ticket_TypeDef { get; set; }

        /// <summary>
        /// 工單狀態
        /// </summary>
        public string Ticket_StatusDef { get; set; }

        /// <summary>
        /// 工單指派人員序號
        /// </summary>
        public int Ticket_AssignUserId { get; set; }

        /// <summary>
        /// 工單建立人員序號
        /// </summary>
        public int Ticket_CreatedUserId { get; set; }
    }
}
