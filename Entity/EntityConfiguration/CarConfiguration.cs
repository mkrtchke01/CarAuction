﻿using System;
using System.Collections.Generic;
using System.Text;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.EntityConfiguration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasOne(x => x.Brand).WithMany(x => x.Cars).HasForeignKey(x => x.BrandId);
           // builder.HasOne(x => x.Model).WithMany(x => x.Cars).HasForeignKey(x => x.ModelId);
            builder.HasMany(x => x.Lots).WithOne(x => x.Car).HasForeignKey(x => x.CarId);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Year).IsRequired().HasMaxLength(4);
            builder.Property(x => x.Fuel).IsRequired();
            builder.Property(x => x.CarBody).IsRequired();
            builder.Property(x => x.DriveUnit).IsRequired();




            /* builder.HasData(
                 new Car
                 {
                     Id = new Guid("67645961-17a7-4316-853c-7ea15838c135"),
                     Year = 2018,
                     BrandId = new Guid("c360b9e4-455c-4f96-ae93-66d5411a2654"),
                     Fuel = Fuel.Petrol,
                     CarBody = CarBody.Sedan,
                     ModelId = new Guid("e3566a95-b1fd-4547-8721-887a9adcf32b"),
                     DriveUnit = DriveUnit.FrontWheelDrive
                 }
             );*/

        }
    }
}
