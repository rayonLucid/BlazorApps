using Blazored.LocalStorage;
using Club_Portal.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Club_Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // var builder = WebAssemblyHostBuilder.CreateDefault(args);
            //builder.RootComponents.Add<App>("app");

            //builder.Services.AddBlazoredLocalStorage();
            string dbName = "ClubManagement.db";
            if (File.Exists(dbName))
            {
                File.Delete(dbName);
            }
            using (var dbContext = new DbClass())
            {
              //  dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();

                if (!dbContext.UserInformation.Any())
                {
                    dbContext.UserInformation.AddRange(new UserInformation[]
                        {
                             new UserInformation{ UserID="USER-001",
                                 UserName="Master", Password="Master",IsAdmin=true,
                                 FirstName="Master",ClubID="Default",IsActive=true,
                             }
                           
                        });
                    dbContext.SaveChanges();
                }

                if (!dbContext.ClubInformation.Any())
                {
                    dbContext.ClubInformation.AddRange(new ClubInformation[]
                        {
                             new ClubInformation{ ClubID="Default", ClubName="Default"},
                            
                        });
                    dbContext.SaveChanges();
                }
               
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                   // webBuilder.Services.AddTransient<ILogin, LoginService>();
                });
    }
}
