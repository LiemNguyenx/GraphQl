using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GraphAPI.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GraphAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //IWebHost host = CreateWebHostBuilder(args).Build();
            //using (IServiceScope scope = host.Services.CreateScope())
            //{
            //    GraphDbContext context = scope.ServiceProvider.GetRequiredService<GraphDbContext>();
            //    var ownerDbEntry1 = context.Owners.Add(new Owner
            //    {
            //        Id = 1,
            //        Name = "Liem1",
            //        PhoneNumber = "123456789",
            //        Address = "Da Nang",
            //        Email = "Liemnguyenx",
            //    });
            //    var ownerDbEntry2 = context.Owners.Add(new Owner
            //    {
            //        Id = 2,
            //        Name = "Liem2",
            //        PhoneNumber = "123456789",
            //        Address = "Da Nang",
            //        Email = "Liemnguyenx",
            //    });
            //    context.Plates.AddRange(new Plate
            //    {
            //        Id = 1,
            //        OwnerId = 1,
            //        Location = "Da Nang123",
            //        Number = "43-K1-12346",
            //        ModifyDate = DateTime.Now,
            //        LastFound = DateTime.Now,
            //        CreateAt = DateTime.Now
            //    }, new Plate
            //    {
            //        Id = 2,
            //        OwnerId = 1,
            //        Number = "43-K1-12347",
            //        Location = "Ha Noi 123",
            //        ModifyDate = DateTime.Now,
            //        LastFound = DateTime.Now,
            //        CreateAt = DateTime.Now
            //    }, new Plate
            //    {
            //        Id = 3,
            //        OwnerId = 2,
            //        Number = "43-K1-12348",
            //        Location = "HCM123",
            //        ModifyDate = DateTime.Now,
            //        LastFound = DateTime.Now,
            //        CreateAt = DateTime.Now
            //    });

            //    context.Faces.AddRange(new Face
            //    {
            //        Id = 1,
            //        OwnerId = 2,
            //        Location = "Nha Trang",
            //        Img = "img1",
            //        ModifyDate = DateTime.Now,
            //        LastFound = DateTime.Now,
            //        CreateAt = DateTime.Now
            //    }, new Face
            //    {
            //        Id = 2,
            //        OwnerId = 2,
            //        Location = "Quy Nhon",
            //        Img = "img1",
            //        ModifyDate = DateTime.Now,
            //        LastFound = DateTime.Now,
            //        CreateAt = DateTime.Now
            //    }, new Face
            //    {
            //        Id = 3,
            //        OwnerId = 1,
            //        Location = "Hue",
            //        Img = "img1",
            //        ModifyDate = DateTime.Now,
            //        LastFound = DateTime.Now,
            //        CreateAt = DateTime.Now
            //    });
            //    context.SaveChanges();

            //}
            //host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
