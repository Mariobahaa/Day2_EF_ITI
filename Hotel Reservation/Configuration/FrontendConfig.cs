using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Hotel_Reservation.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_Reservation.Configuration
{
    class FrontendConfig : IEntityTypeConfiguration<Frontend>
    {

        public void Configure(EntityTypeBuilder<Frontend> builder)
        {
            builder.HasKey(F => F.UserName);
            builder.Property(F => F.UserName).HasMaxLength(50).IsRequired().HasColumnName("user_name");
            builder.Property(F => F.PassWord).HasMaxLength(50).IsRequired().HasColumnName("pass_word");


        }
    }
}
