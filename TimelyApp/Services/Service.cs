using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;
using TimelyApp.Repository;
using TimelyApp.Services.Interfaces;

namespace TimelyApp.Services
{
    public class Service : IService
    {
        private readonly ILogRepositoryAsync _logRepository;
        
        public Service( ILogRepositoryAsync LogRepository)
        {           
            _logRepository = LogRepository;
        }

        public async Task addNewLogAsync(Log newLog)
        {           
            await _logRepository.addNewLogAsync(newLog);

            await _logRepository.SaveAsync();
        }

        public async Task deleteLog(int? LogId)
        {
            await _logRepository.deleteLogAsync(LogId);

            await _logRepository.SaveAsync();
        }

        public async Task editLog(Log Log)
        {
            _logRepository.updateLogInformation(Log);

            await _logRepository.SaveAsync();
        }

        public async Task<IEnumerable<Log>> getAllLogs()
        {
            IEnumerable<Log> _allLogs = await _logRepository.getAllAsync();
          
            return _allLogs;
        }
        public async Task<Log> getSingleLog(int? LogID)
        {
            Log singleLog = await _logRepository.getLogByIDAsync(LogID);

            return singleLog;
        }
    }
}
