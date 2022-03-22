using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;

namespace TimelyApp.Mapper
{
    public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            // Koristi reverseMap ovdje
            CreateMap<Log, LogDTO>();
            CreateMap<LogDTO, Log>();         
        }
    }
}
