using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;

namespace TimelyApp.Services.Interfaces
{
    public interface IService
    {
        //update log
        Task editLog(Log Log);
        //Add log
        Task addNewLogAsync(Log newLog);
        //delete Log
        Task deleteLog(int? LogId);
        //get all Logs
        Task<IEnumerable<Log>> getAllLogs();
       
        //get single Log
        Task<Log> getSingleLog(int? LogID);
    }
}
