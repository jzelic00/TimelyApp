using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;

namespace TimelyApp.Repository
{
    public interface ILogRepositoryAsync
    {
        Task deleteLogAsync(int? id);
        Task<Log> getLogByIDAsync(int? id);

        void updateLogInformation(Log Log);
        Task addNewLogAsync(Log newLog);
    
        Task<IEnumerable<Log>> getAllAsync();
        Task SaveAsync();
    }
}
