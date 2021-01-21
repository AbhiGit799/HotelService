using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelService.HotelClasses
{
    //Command for PAckage Manager
    public class ServiceHotelContextCls :DbContext
    {
        public ServiceHotelContextCls() :base("name=ServiceHotelCon")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ServiceHotelContextCls, HotelService.Migrations.Configuration>());
        }

        public DbSet<Country> countries { get; set; }

        public DbSet<City> cities { get; set; }

        public DbSet<HotelDetails> hotels { get; set; }

        public DbSet<RoomType> roomtypes { get; set; }

        public DbSet<RoomDetails> rooms { get; set; }


    }


}