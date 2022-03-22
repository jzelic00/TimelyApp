using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;

namespace TimelyApp.Repository
{
    public class LogRepository : ILogRepositoryAsync
    {
        private readonly DatabaseContext _db;

        public LogRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task addNewLogAsync(Log newLog)
        {
            await _db.Log.AddAsync(newLog);
        }

        public async Task deleteLogAsync(int? id)
        {
            Log LogToDelete = await _db.Log.Where(p => p.LogID == id)
                               .FirstOrDefaultAsync();

            _db.Remove(LogToDelete);
        }

        public async Task<IEnumerable<Log>> getAllAsync()
        {
            return await _db.Log.AsNoTracking().ToListAsync();
        }

        public async Task<Log> getLogByIDAsync(int? id)
        {
            return await _db.Log.AsNoTracking().Where(p => p.LogID == id)
                                                   .FirstOrDefaultAsync();
        }

        public void updateLogInformation(Log Log)
        {
            _db.Entry(Log).State = EntityState.Modified;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
