﻿namespace DataAccess.DbContexts.TicketSystemDb.Models.Tasks
{
    /// <summary>
    /// 工單模組
    /// </summary>
    public class TaskModel
    {
        /// <summary>
        /// 工單序號
        /// </summary>
        public int Task_Id { get; set; }

        /// <summary>
        /// 工單標題
        /// </summary>
        public string Task_Title { get; set; }

        /// <summary>
        /// 工單描述
        /// </summary>
        public string Task_Description { get; set; }

        /// <summary>
        /// 工單類型
        /// </summary>
        public string Task_TypeDef { get; set; }

        /// <summary>
        /// 工單狀態
        /// </summary>
        public string Task_StatusDef { get; set; }

        /// <summary>
        /// 工單指派人員序號
        /// </summary>
        public int Task_AssignUserId { get; set; }

        /// <summary>
        /// 工單建立人員序號
        /// </summary>
        public int Task_CreatedUserId { get; set; }
    }
}
