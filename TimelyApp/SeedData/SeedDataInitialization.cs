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
               new Log() { LogID = 1, ProjectName = "Obitelj" , StartTime="test", EndTime="test", Duration="testIsto"},
               new Log() { LogID = 2, ProjectName = "Prijatelj",  StartTime = "test", EndTime = "test", Duration = "testIsto" },
               new Log() { LogID = 3, ProjectName = "Posao"  ,StartTime = "test", EndTime = "test", Duration = "testIsto" }
                  );
        }
    } 
}
