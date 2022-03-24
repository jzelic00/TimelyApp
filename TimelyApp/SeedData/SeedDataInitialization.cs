using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimelyApp.Models;

namespace TimelyApp.SeedData
{
    public static class SeedDataInitialization
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>().HasData(
              new Log() { LogID = 1, ProjectName = "test",
                  StartTime= DateTime.UtcNow,
                  EndTime= DateTime.UtcNow,
                  Duration= 1234
              }
             //new Log()
             //{
             //    LogID = 2,
             //    ProjectName = "test3",
             //    StartTime = new DateTime(2022, 03, 22, 13, 45, 00),
             //    EndTime = new DateTime(2022, 03, 22, 13, 45, 50),
             //    Duration = 1234
             //},
             //new Log()
             //{
             //    LogID = 3,
             //    ProjectName = "test2",
             //    StartTime = new DateTime(2022, 03, 22, 13, 45, 00),
             //    EndTime = new DateTime(2022, 03, 22, 13, 45, 50),
             //    Duration = 12311
             //}
                 );
        }
    } 
}
