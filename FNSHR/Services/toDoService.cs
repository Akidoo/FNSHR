using Microsoft.EntityFrameworkCore;
using FNSHR.Data;
using FNSHR.Models;
using System.Threading.Channels;
using TableDependency.SqlClient;

namespace FNSHR.Services
{
    public class toDoService
    {
        private readonly AppDbContext dbContext;

        public toDoService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private readonly SqlTableDependency<toDo> _dependency;
        private readonly string _connectionString;
        public toDoService()
        {
            _connectionString = "Server=DESKTOP-NMGCD6G; Database=Tasks; Trusted_Connection=True;";
            _dependency = new SqlTableDependency<toDo>(_connectionString, "Tasks");
           // _dependency.OnChanged += Changed;
            _dependency.Start();
        }

        public async Task<List<toDo>> GetAllToDo()
        {
            return await dbContext.Tasks.AsNoTracking().ToListAsync();
        }
    }
}
