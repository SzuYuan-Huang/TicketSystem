using Autofac.Features.AttributeFilters;
using Dapper;
using DataAccess.DbContexts;
using DataAccess.DbContexts.TicketSystemDb.Models.Tasks;

namespace DataAccess.Repositories.Tasks
{
    /// <summary>
    /// 工單 Repository
    /// </summary>
    public class TaskRepository : ITaskRepository
    {
        /// <summary>
        /// TicketSystem DBContext
        /// </summary>
        private readonly IDbContext _ticketSystemDbContext;

        /// <summary>
        /// The documentation text within the constructor's summary tag must begin with the text: Initializes a new instance of the <see cref="TaskRepository" /> class.
        /// </summary>
        /// <param name="ticketSystemDbContext">WebStore DBContext</param>
        public TaskRepository(
            [KeyFilter("TicketSystemDB")] IDbContext ticketSystemDbContext)
        {
            this._ticketSystemDbContext = ticketSystemDbContext;
        }

        /// <summary>
        /// 取得工單資料 By 序號
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns>工單資料</returns>
        public TaskModel GetTaskById(int id)
        {
            var sql = @"
            SELECT Task_Id
                  ,Task_Title
                  ,Task_Description
                  ,Task_TypeDef
                  ,Task_StatusDef
                  ,Task_AssignUserId
                  ,Task_CreatedUserId
            FROM dbo.Task WITH (NOLOCK)
            WHERE Task_Id = @TaskId";

            var param = new
            {
                TaskId = id
            };

            using (var connection = this._ticketSystemDbContext.DbConnection())
            {
                return connection.QuerySingleOrDefault<TaskModel>(sql, param);
            }
        }
    }
}
