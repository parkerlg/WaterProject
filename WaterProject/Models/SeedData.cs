using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WaterProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            CharityDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<CharityDBContext>();
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Projects.Any())
            {
                context.Projects.AddRange(

                    new Project
                    {
                        Type = "Well Rehab",
                        Program = "Water for Sierra Leone",
                        Impact = 400,
                        Phase = 2,
                        CompletionDate = new DateTime(2010, 08, 01),
                        Features = "WR, LL"
                    },
                    new Project
                    {

                        Type = "Well Rehab",
                        Program = "Wells for Burkina Faso",
                        Impact = 500,
                        Phase = 3,
                        CompletionDate = new DateTime(2013, 08, 01),
                        Features = "WR, LL, CE, HST"
                    }

                    );
                context.SaveChanges();
            }

        }

       
    }
}
