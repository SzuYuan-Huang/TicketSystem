namespace Entity.Tickets
{
    /// <summary>
    /// 工單 Entity
    /// </summary>
    public class TicketEntity
    {
        /// <summary>
        /// 工單序號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 工單標題
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 工單描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 工單類別
        /// </summary>
        public string TypeDef { get; set; }

        /// <summary>
        /// 工單狀態
        /// </summary>
        public string StatusDef { get; set; }

        /// <summary>
        /// 工單指派人員序號
        /// </summary>
        public int AssignUserId { get; set; }

        /// <summary>
        /// 工單建立人員序號
        /// </summary>
        public int CreatedUserId { get; set; }
    }
}
