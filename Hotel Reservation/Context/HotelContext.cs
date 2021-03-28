using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Reservation.Entities;
using Hotel_Reservation.Configuration;

namespace Hotel_Reservation.Context
{
    public class HotelContext :DbContext
    {
        public virtual DbSet<Frontend> Frontend { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }

        public virtual DbSet<Reservation> Reservations{ get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog= HotelDB; Integrated Security=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitchen>().HasKey(K => K.UserName);

            modelBuilder.Entity<Kitchen>().Property(K => K.UserName).HasMaxLength(50).IsRequired().HasColumnName("user_name");

            modelBuilder.Entity<Kitchen>().Property(K => K.PassWord).HasMaxLength(50).IsRequired().HasColumnName("pass_word");

            modelBuilder.ApplyConfiguration(new FrontendConfig());


        }
    }
}
